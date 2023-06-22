﻿
namespace Student_Management_System
{
    partial class frm_View_Courses_List
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
            this.lbl_Courses_List = new System.Windows.Forms.Label();
            this.dgv_Courses_List = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet5 = new Student_Management_System.Student_Management_System_DBDataSet5();
            this.courses_DetailsTableAdapter = new Student_Management_System.Student_Management_System_DBDataSet5TableAdapters.Courses_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Courses_List
            // 
            this.lbl_Courses_List.AutoSize = true;
            this.lbl_Courses_List.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Courses_List.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Courses_List.Location = new System.Drawing.Point(188, 23);
            this.lbl_Courses_List.Name = "lbl_Courses_List";
            this.lbl_Courses_List.Size = new System.Drawing.Size(353, 65);
            this.lbl_Courses_List.TabIndex = 6;
            this.lbl_Courses_List.Text = "Courses List";
            // 
            // dgv_Courses_List
            // 
            this.dgv_Courses_List.AllowUserToAddRows = false;
            this.dgv_Courses_List.AllowUserToDeleteRows = false;
            this.dgv_Courses_List.AutoGenerateColumns = false;
            this.dgv_Courses_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Courses_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Courses_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Courses_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_Courses_List.DataSource = this.coursesDetailsBindingSource;
            this.dgv_Courses_List.Location = new System.Drawing.Point(12, 103);
            this.dgv_Courses_List.Name = "dgv_Courses_List";
            this.dgv_Courses_List.ReadOnly = true;
            this.dgv_Courses_List.Size = new System.Drawing.Size(710, 296);
            this.dgv_Courses_List.TabIndex = 7;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDetailsBindingSource
            // 
            this.coursesDetailsBindingSource.DataMember = "Courses_Details";
            this.coursesDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet5;
            // 
            // student_Management_System_DBDataSet5
            // 
            this.student_Management_System_DBDataSet5.DataSetName = "Student_Management_System_DBDataSet5";
            this.student_Management_System_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courses_DetailsTableAdapter
            // 
            this.courses_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Courses_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Courses_List);
            this.Controls.Add(this.lbl_Courses_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Courses_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses List";
            this.Load += new System.EventHandler(this.frm_Courses_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Courses_List;
        private System.Windows.Forms.DataGridView dgv_Courses_List;
        private Student_Management_System_DBDataSet5 student_Management_System_DBDataSet5;
        private System.Windows.Forms.BindingSource coursesDetailsBindingSource;
        private Student_Management_System_DBDataSet5TableAdapters.Courses_DetailsTableAdapter courses_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}