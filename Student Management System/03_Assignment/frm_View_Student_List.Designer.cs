
namespace Student_Management_System
{
    partial class frm_View_Student_List
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
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.studentListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet1 = new Student_Management_System.Student_Management_System_DBDataSet1();
            this.student_Management_System_DBDataSet = new Student_Management_System.Student_Management_System_DBDataSet();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter = new Student_Management_System.Student_Management_System_DBDataSetTableAdapters.Student_ListTableAdapter();
            this.student_ListTableAdapter1 = new Student_Management_System.Student_Management_System_DBDataSet1TableAdapters.Student_ListTableAdapter();
            this.student_Management_System_DBDataSet2 = new Student_Management_System.Student_Management_System_DBDataSet2();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter = new Student_Management_System.Student_Management_System_DBDataSet2TableAdapters.Student_DetailsTableAdapter();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet4 = new Student_Management_System.Student_Management_System_DBDataSet4();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet3 = new Student_Management_System.Student_Management_System_DBDataSet3();
            this.student_DetailsTableAdapter1 = new Student_Management_System.Student_Management_System_DBDataSet3TableAdapters.Student_DetailsTableAdapter();
            this.student_DetailsTableAdapter2 = new Student_Management_System.Student_Management_System_DBDataSet4TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_View_Student_List.Location = new System.Drawing.Point(128, 19);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(615, 65);
            this.lbl_View_Student_List.TabIndex = 6;
            this.lbl_View_Student_List.Text = "View All Student List";
            // 
            // studentListBindingSource1
            // 
            this.studentListBindingSource1.DataMember = "Student_List";
            this.studentListBindingSource1.DataSource = this.student_Management_System_DBDataSet1;
            // 
            // student_Management_System_DBDataSet1
            // 
            this.student_Management_System_DBDataSet1.DataSetName = "Student_Management_System_DBDataSet1";
            this.student_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_Management_System_DBDataSet
            // 
            this.student_Management_System_DBDataSet.DataSetName = "Student_Management_System_DBDataSet";
            this.student_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataMember = "Student_List";
            this.studentListBindingSource.DataSource = this.student_Management_System_DBDataSet;
            // 
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
            // 
            // student_ListTableAdapter1
            // 
            this.student_ListTableAdapter1.ClearBeforeFill = true;
            // 
            // student_Management_System_DBDataSet2
            // 
            this.student_Management_System_DBDataSet2.DataSetName = "Student_Management_System_DBDataSet2";
            this.student_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet2;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentDetailsBindingSource2;
            this.dgv_Student_List.Location = new System.Drawing.Point(12, 101);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.Size = new System.Drawing.Size(860, 548);
            this.dgv_Student_List.TabIndex = 7;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource2
            // 
            this.studentDetailsBindingSource2.DataMember = "Student_Details";
            this.studentDetailsBindingSource2.DataSource = this.student_Management_System_DBDataSet4;
            // 
            // student_Management_System_DBDataSet4
            // 
            this.student_Management_System_DBDataSet4.DataSetName = "Student_Management_System_DBDataSet4";
            this.student_Management_System_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.student_Management_System_DBDataSet3;
            // 
            // student_Management_System_DBDataSet3
            // 
            this.student_Management_System_DBDataSet3.DataSetName = "Student_Management_System_DBDataSet3";
            this.student_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // student_DetailsTableAdapter2
            // 
            this.student_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.lbl_View_Student_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Student_List";
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private Student_Management_System_DBDataSet student_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private Student_Management_System_DBDataSetTableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private Student_Management_System_DBDataSet1 student_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource studentListBindingSource1;
        private Student_Management_System_DBDataSet1TableAdapters.Student_ListTableAdapter student_ListTableAdapter1;
        private Student_Management_System_DBDataSet2 student_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Management_System_DBDataSet2TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private Student_Management_System_DBDataSet3 student_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private Student_Management_System_DBDataSet3TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private Student_Management_System_DBDataSet4 student_Management_System_DBDataSet4;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource2;
        private Student_Management_System_DBDataSet4TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter2;
    }
}