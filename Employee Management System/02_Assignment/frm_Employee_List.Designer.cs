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
            this.dgv_Empl_List = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_Data_BaseDataSet1 = new Employee_Management_System.Employee_Management_System_Data_BaseDataSet1();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.employee_Management_System_Data_BaseDataSet = new Employee_Management_System.Employee_Management_System_Data_BaseDataSet();
            this.employeeManagementSystemDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_Management_System_Data_BaseDataSet1TableAdapters.Employee_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empl_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataBaseDataSetBindingSource)).BeginInit();
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
            // dgv_Empl_List
            // 
            this.dgv_Empl_List.AllowUserToAddRows = false;
            this.dgv_Empl_List.AllowUserToDeleteRows = false;
            this.dgv_Empl_List.AutoGenerateColumns = false;
            this.dgv_Empl_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Empl_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Empl_List.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Empl_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Empl_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empl_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Empl_List.DataSource = this.employeeDetailsBindingSource;
            this.dgv_Empl_List.Location = new System.Drawing.Point(12, 95);
            this.dgv_Empl_List.Name = "dgv_Empl_List";
            this.dgv_Empl_List.ReadOnly = true;
            this.dgv_Empl_List.Size = new System.Drawing.Size(860, 394);
            this.dgv_Empl_List.TabIndex = 1;
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
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
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
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Uname.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Uname.Location = new System.Drawing.Point(8, 7);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(81, 21);
            this.lbl_Uname.TabIndex = 11;
            this.lbl_Uname.Text = "Username";
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
            // frm_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.dgv_Empl_List);
            this.Controls.Add(this.lbl_Employee_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_List";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frm_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empl_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_Data_BaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataBaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_List;
        private System.Windows.Forms.DataGridView dgv_Empl_List;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.BindingSource employeeManagementSystemDataBaseDataSetBindingSource;
        private Employee_Management_System_Data_BaseDataSet employee_Management_System_Data_BaseDataSet;
        private Employee_Management_System_Data_BaseDataSet1 employee_Management_System_Data_BaseDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Management_System_Data_BaseDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
    }
}