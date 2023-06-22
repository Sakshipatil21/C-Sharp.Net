
namespace Student_Management_System
{
    partial class frm_Add_Course
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
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Course.Location = new System.Drawing.Point(200, 19);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(330, 65);
            this.lbl_Course.TabIndex = 5;
            this.lbl_Course.Text = "Add Course";
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(441, 245);
            this.tb_Course_Name.MaxLength = 80;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(249, 35);
            this.tb_Course_Name.TabIndex = 2;
            this.tb_Course_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Enabled = false;
            this.tb_Course_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(441, 148);
            this.tb_Course_ID.MaxLength = 5;
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(249, 35);
            this.tb_Course_ID.TabIndex = 1;
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AllowDrop = true;
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Course_Name.Location = new System.Drawing.Point(70, 244);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(185, 36);
            this.lbl_Course_Name.TabIndex = 12;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.AllowDrop = true;
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Course_ID.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Course_ID.Location = new System.Drawing.Point(70, 148);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(145, 36);
            this.lbl_Course_ID.TabIndex = 11;
            this.lbl_Course_ID.Text = "Course ID";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(275, 339);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(107, 47);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_ID);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_ID);
            this.Controls.Add(this.lbl_Course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.frm_Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Label lbl_Course_ID;
        private System.Windows.Forms.Button btn_Save;
    }
}