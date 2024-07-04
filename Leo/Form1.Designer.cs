namespace Leo
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MyLabel = new System.Windows.Forms.Label();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.myButton = new System.Windows.Forms.Button();
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.myUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet = new Leo.MyDatabaseDataSet();
            this.myCheckBox = new System.Windows.Forms.CheckBox();
            this.myUserTableAdapter = new Leo.MyDatabaseDataSetTableAdapters.MyUserTableAdapter();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyLabel
            // 
            this.MyLabel.AutoSize = true;
            this.MyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyLabel.Location = new System.Drawing.Point(12, 9);
            this.MyLabel.Name = "MyLabel";
            this.MyLabel.Size = new System.Drawing.Size(226, 26);
            this.MyLabel.TabIndex = 0;
            this.MyLabel.Text = "Search for someone";
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(17, 38);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(200, 20);
            this.myTextBox.TabIndex = 1;
            // 
            // myButton
            // 
            this.myButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton.Location = new System.Drawing.Point(223, 38);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(75, 23);
            this.myButton.TabIndex = 2;
            this.myButton.Text = "Search";
            this.myButton.UseVisualStyleBackColor = true;
            // 
            // myComboBox
            // 
            this.myComboBox.DataSource = this.myUserBindingSource;
            this.myComboBox.DisplayMember = "FirstName";
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Location = new System.Drawing.Point(17, 64);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(100, 21);
            this.myComboBox.TabIndex = 3;
            // 
            // myUserBindingSource
            // 
            this.myUserBindingSource.DataMember = "MyUser";
            this.myUserBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myCheckBox
            // 
            this.myCheckBox.AutoSize = true;
            this.myCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myCheckBox.Location = new System.Drawing.Point(123, 64);
            this.myCheckBox.Name = "myCheckBox";
            this.myCheckBox.Size = new System.Drawing.Size(69, 17);
            this.myCheckBox.TabIndex = 4;
            this.myCheckBox.Text = "Age > 40";
            this.myCheckBox.UseVisualStyleBackColor = true;
            // 
            // myUserTableAdapter
            // 
            this.myUserTableAdapter.ClearBeforeFill = true;
            // 
            // myDataGridView
            // 
            this.myDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myDataGridView.AutoGenerateColumns = false;
            this.myDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.isMaleDataGridViewCheckBoxColumn,
            this.registerDateDataGridViewTextBoxColumn});
            this.myDataGridView.DataSource = this.myUserBindingSource;
            this.myDataGridView.Location = new System.Drawing.Point(17, 91);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.Size = new System.Drawing.Size(473, 258);
            this.myDataGridView.TabIndex = 5;
            this.myDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // isMaleDataGridViewCheckBoxColumn
            // 
            this.isMaleDataGridViewCheckBoxColumn.DataPropertyName = "IsMale";
            this.isMaleDataGridViewCheckBoxColumn.HeaderText = "Is a Man";
            this.isMaleDataGridViewCheckBoxColumn.Name = "isMaleDataGridViewCheckBoxColumn";
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "Registered At";
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 361);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.myCheckBox);
            this.Controls.Add(this.myComboBox);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.MyLabel);
            this.Name = "MyForm";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.MyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyLabel;
        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.ComboBox myComboBox;
        private System.Windows.Forms.CheckBox myCheckBox;
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource myUserBindingSource;
        private MyDatabaseDataSetTableAdapters.MyUserTableAdapter myUserTableAdapter;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
    }
}

