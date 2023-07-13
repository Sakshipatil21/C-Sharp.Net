
namespace Student_Management_System
{
    partial class frm_Add_Student_Details
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Add_Student_Details = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(336, 516);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(107, 47);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AllowDrop = true;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Name.Location = new System.Drawing.Point(88, 192);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 36);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AllowDrop = true;
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Roll_No.Location = new System.Drawing.Point(88, 114);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(125, 36);
            this.lbl_Roll_No.TabIndex = 6;
            this.lbl_Roll_No.Text = "Roll No.";
            // 
            // lbl_Add_Student_Details
            // 
            this.lbl_Add_Student_Details.AutoSize = true;
            this.lbl_Add_Student_Details.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Student_Details.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Add_Student_Details.Location = new System.Drawing.Point(158, 9);
            this.lbl_Add_Student_Details.Name = "lbl_Add_Student_Details";
            this.lbl_Add_Student_Details.Size = new System.Drawing.Size(568, 65);
            this.lbl_Add_Student_Details.TabIndex = 4;
            this.lbl_Add_Student_Details.Text = "Add Student Details";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AllowDrop = true;
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_DOB.Location = new System.Drawing.Point(88, 354);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(82, 36);
            this.lbl_DOB.TabIndex = 10;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AllowDrop = true;
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Course.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Course.Location = new System.Drawing.Point(88, 436);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(103, 36);
            this.lbl_Course.TabIndex = 11;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AllowDrop = true;
            this.lbl_Mob_No.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Mob_No.Location = new System.Drawing.Point(88, 275);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(162, 36);
            this.lbl_Mob_No.TabIndex = 12;
            this.lbl_Mob_No.Text = "Mobile No.";
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Enabled = false;
            this.tb_Roll_No.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(564, 114);
            this.tb_Roll_No.MaxLength = 3;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(249, 35);
            this.tb_Roll_No.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(564, 192);
            this.tb_Name.MaxLength = 40;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(249, 35);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(564, 354);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(249, 35);
            this.dtp_DOB.TabIndex = 4;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(564, 275);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(249, 35);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "BSc.CS",
            "MCA",
            "MCS"});
            this.cmb_Course.Location = new System.Drawing.Point(564, 435);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(249, 35);
            this.cmb_Course.TabIndex = 5;
            // 
            // frm_Add_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(859, 571);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Add_Student_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Details";
            this.Load += new System.EventHandler(this.frm_Add_Student_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Add_Student_Details;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.ComboBox cmb_Course;
    }
}