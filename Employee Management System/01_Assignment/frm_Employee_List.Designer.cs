namespace Employee_Management_System
{
    partial class frm_Employee_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee_List));
            this.lbl_Employee_List = new System.Windows.Forms.Label();
            this.employeeDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_Data_Base_01DataSet1 = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSet1();
            this.employeeDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_Data_Base_01DataSet = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSet();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_Data_BaseDataSet1 = new Employee_Management_System.Employee_Management_System_Data_BaseDataSet1();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.employee_Management_System_Data_BaseDataSet = new Employee_Management_System.Employee_Management_System_Data_BaseDataSet();
            this.employeeManagementSystemDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_Management_System_Data_BaseDataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.employee_DetailsTableAdapter1 = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSetTableAdapters.Employee_DetailsTableAdapter();
            this.employee_DetailsTableAdapter2 = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.employee_Management_System_Data_Base_01DataSet2 = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSet2();
            this.employeeDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter3 = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSet2TableAdapters.Employee_DetailsTableAdapter();
            this.dgv_Employee_List = new System.Windows.Forms.DataGridView();
            this.employee_Management_System_Data_Base_01DataSet3 = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSet3();
            this.employeeDetailsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter4 = new Employee_Management_System.Employee_Management_System_Data_Base_01DataSet3TableAdapters.Employee_DetailsTableAdapter();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_List
            // 
            this.lbl_Employee_List.AutoSize = true;
            this.lbl_Employee_List.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Employee_List.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Employee_List.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Employee_List.Location = new System.Drawing.Point(295, 26);
            this.lbl_Employee_List.Name = "lbl_Employee_List";
            this.lbl_Employee_List.Size = new System.Drawing.Size(241, 42);
            this.lbl_Employee_List.TabIndex = 0;
            this.lbl_Employee_List.Text = "Employee List";
            // 
            // employeeDetailsBindingSource2
            // 
            this.employeeDetailsBindingSource2.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource2.DataSource = this.employee_Management_System_Data_Base_01DataSet1;
            // 
            // employee_Management_System_Data_Base_01DataSet1
            // 
            this.employee_Management_System_Data_Base_01DataSet1.DataSetName = "Employee_Management_System_Data_Base_01DataSet1";
            this.employee_Management_System_Data_Base_01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource1
            // 
            this.employeeDetailsBindingSource1.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource1.DataSource = this.employee_Management_System_Data_Base_01DataSet;
            // 
            // employee_Management_System_Data_Base_01DataSet
            // 
            this.employee_Management_System_Data_Base_01DataSet.DataSetName = "Employee_Management_System_Data_Base_01DataSet";
            this.employee_Management_System_Data_Base_01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Management_System_Data_BaseDataSet1;
            // 
            // employee_Management_System_Data_BaseDataSet1
            // 
            this.employee_Management_System_Data_BaseDataSet1.DataSetName = "Employee_Management_System_Data_BaseDataSet1";
            this.employee_Management_System_Data_BaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(290, 509);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(216, 40);
            this.btn_Add_New_Employee.TabIndex = 1;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_LogOut.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F);
            this.btn_LogOut.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_LogOut.Location = new System.Drawing.Point(806, 3);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(75, 28);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // employee_Management_System_Data_BaseDataSet
            // 
            this.employee_Management_System_Data_BaseDataSet.DataSetName = "Employee_Management_System_Data_BaseDataSet";
            this.employee_Management_System_Data_BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeManagementSystemDataBaseDataSetBindingSource
            // 
            this.employeeManagementSystemDataBaseDataSetBindingSource.DataSource = this.employee_Management_System_Data_BaseDataSet;
            this.employeeManagementSystemDataBaseDataSetBindingSource.Position = 0;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // employee_DetailsTableAdapter1
            // 
            this.employee_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // employee_DetailsTableAdapter2
            // 
            this.employee_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // employee_Management_System_Data_Base_01DataSet2
            // 
            this.employee_Management_System_Data_Base_01DataSet2.DataSetName = "Employee_Management_System_Data_Base_01DataSet2";
            this.employee_Management_System_Data_Base_01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource3
            // 
            this.employeeDetailsBindingSource3.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource3.DataSource = this.employee_Management_System_Data_Base_01DataSet2;
            // 
            // employee_DetailsTableAdapter3
            // 
            this.employee_DetailsTableAdapter3.ClearBeforeFill = true;
            // 
            // dgv_Employee_List
            // 
            this.dgv_Employee_List.AllowUserToAddRows = false;
            this.dgv_Employee_List.AllowUserToDeleteRows = false;
            this.dgv_Employee_List.AutoGenerateColumns = false;
            this.dgv_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Employee_List.DataSource = this.employeeDetailsBindingSource4;
            this.dgv_Employee_List.Location = new System.Drawing.Point(12, 87);
            this.dgv_Employee_List.Name = "dgv_Employee_List";
            this.dgv_Employee_List.ReadOnly = true;
            this.dgv_Employee_List.Size = new System.Drawing.Size(848, 401);
            this.dgv_Employee_List.TabIndex = 3;
            // 
            // employee_Management_System_Data_Base_01DataSet3
            // 
            this.employee_Management_System_Data_Base_01DataSet3.DataSetName = "Employee_Management_System_Data_Base_01DataSet3";
            this.employee_Management_System_Data_Base_01DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource4
            // 
            this.employeeDetailsBindingSource4.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource4.DataSource = this.employee_Management_System_Data_Base_01DataSet3;
            // 
            // employee_DetailsTableAdapter4
            // 
            this.employee_DetailsTableAdapter4.ClearBeforeFill = true;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgv_Employee_List);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_Employee_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frm_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_Base_01DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_List;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.BindingSource employeeManagementSystemDataBaseDataSetBindingSource;
        private Employee_Management_System_Data_BaseDataSet employee_Management_System_Data_BaseDataSet;
        private Employee_Management_System_Data_BaseDataSet1 employee_Management_System_Data_BaseDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Management_System_Data_BaseDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private Employee_Management_System_Data_Base_01DataSet employee_Management_System_Data_Base_01DataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource1;
        private Employee_Management_System_Data_Base_01DataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter1;
        private Employee_Management_System_Data_Base_01DataSet1 employee_Management_System_Data_Base_01DataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource2;
        private Employee_Management_System_Data_Base_01DataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter2;
        private Employee_Management_System_Data_Base_01DataSet2 employee_Management_System_Data_Base_01DataSet2;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource3;
        private Employee_Management_System_Data_Base_01DataSet2TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter3;
        private System.Windows.Forms.DataGridView dgv_Employee_List;
        private Employee_Management_System_Data_Base_01DataSet3 employee_Management_System_Data_Base_01DataSet3;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource4;
        private Employee_Management_System_Data_Base_01DataSet3TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
    }
}