using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leo
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();

            // Register the event handler for the CheckBox CheckedChanged event
            myCheckBox.CheckedChanged += new EventHandler(myCheckBox_CheckedChanged);

            // Register the event handler for the Button Click event
            myButton.Click += new EventHandler(myButton_Click);
        }

        /// <summary>
        /// Handles the Click event of the myButton control.
        /// Executes a search based on the text entered in myTextBox, updates myUserBindingSource with the search results.
        /// </summary>
        /// <param name="sender">The object that raised the event (myButton).</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void myButton_Click(object sender, EventArgs e)
        {
            string searchTerm = myTextBox.Text.Trim();

            DataView dv = SearchData(searchTerm);
            myUserBindingSource.DataSource = dv;
        }

        /// <summary>
        /// Searches for data in the MyUser table based on the provided search term.
        /// </summary>
        /// <param name="searchTerm">The term to search for in ID, FirstName, or LastName fields.</param>
        /// <returns>A DataTable containing the search results from the MyUser table.</returns>
        private DataView SearchData(string searchTerm)
        {
            string query;
            string connectionString = ConfigurationManager.ConnectionStrings["Leo.Properties.Settings.MyDatabaseConnectionString"].ConnectionString;
            DataTable dt = new DataTable();


            // Construct SQL query with placeholders for parameterized queries to prevent SQL injection
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = "SELECT * FROM MyUser " +
                    "WHERE CONVERT(VARCHAR(MAX), ID) LIKE @searchTerm " +
                    "OR FirstName LIKE @searchPattern " +
                    "OR LastName LIKE @searchPattern ";
            }
            else
            {
                // If searchTerm is empty or null, retrieve all records from MyUser table
                query = "SELECT * FROM MyUser";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection)) // TODO ADD CONNECTION
                {
                    // Add parameters to SqlCommand to handle search terms safely
                    cmd.Parameters.AddWithValue("@searchTerm", searchTerm); // <-- SqlParameter type
                    cmd.Parameters.AddWithValue("@searchPattern", $"%{searchTerm}%");

                    // Use SqlDataAdapter to execute the command and fill DataTable dt with results
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            // Create a DataView from the DataTable and return it
            DataView dv = new DataView(dt)
            {
                // I had no idea what to do with the DataView so I just did that
                Sort = "FirstName ASC"
            };
            return dv;
        }

        private void myCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox.Checked)
            {
                // Apply the filter to the BindingSource
                myUserBindingSource.Filter = "Age > 40";
            }
            else
            {
                // Remove the filter to display all records
                myUserBindingSource.RemoveFilter();
            }
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.MyUser' table. You can move, or remove it, as needed.
            this.myUserTableAdapter.Fill(this.myDatabaseDataSet.MyUser);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void myDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
