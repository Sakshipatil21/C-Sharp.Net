﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_Assignment
{
    public partial class Use_CheckBox_CheckListBox : Form
    {
        public Use_CheckBox_CheckListBox()
        {
            InitializeComponent();
        }

        private void Use_CheckBox_CheckListBox_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true;

            if (tb_Name.Text != "")
            {
                Result += tb_Name.Text + " is From Department ";
                lbl_Name_Err.Visible = false;
            }
            else
            {
                lbl_Name_Err.Text = "Enter Employee Name";
                lbl_Name_Err.Visible = true;
                Flag = false;
            }

            if(cmb_Dept.Text != "")
            {
                Result += cmb_Dept.Text;
                lbl_Dept_Err.Visible = false;
            }
            else
            {
                lbl_Dept_Err.Text = "Select Employee Dept";
                lbl_Dept_Err.Visible = true;
                Flag = false;
            }

            if(rb_Male.Checked == true)
            {
                Result += ", is " + rb_Male.Text + " And He Knows ";
                lbl_Gender_Err.Visible = false;
            }
            else if(rb_Female.Checked == true)
            {
                Result += ", is " + rb_Female.Text + " And She Knows ";
                lbl_Gender_Err.Visible = false;
            }
            else
            {
                lbl_Gender_Err.Text = "Select Employee Gender";
                lbl_Gender_Err.Visible = true;
                Flag = false;
            }

            if (cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text;
                lbl_Lang_Err.Visible = false;

                if (cb_Hindi.Checked == true)
                {
                    Result += ", " + cb_Hindi.Text;
                    lbl_Lang_Err.Visible = false;

                    if (cb_English.Checked == true)
                    {
                        Result += ", " + cb_English.Text;
                        lbl_Lang_Err.Visible = false;

                        if (cb_French.Checked == true)
                        {
                            Result += ", " + cb_French.Text;
                            lbl_Lang_Err.Visible = false;
                        }
                    }
                }
            }
            else
            {
                lbl_Lang_Err.Visible = true;
                lbl_Lang_Err.Text = "Select Languages";
                Flag = false;
            }

            int Cnt = clb_Hobbies.CheckedItems.Count;

            if (Cnt > 0)
            {
                lbl_Hobby_Err.Visible = false;
                Result += " And Has Hobbies are ";
            }
            else
            {
                lbl_Hobby_Err.Text = "Select Hobbies";
                lbl_Hobby_Err.Visible = true;
                Flag = false;
            }

            for(int i = 0; i < clb_Hobbies.Items.Count - 1; i++)
            {
                if(clb_Hobbies.GetItemChecked(i))
                {
                    if(Cnt > 1)
                    {
                        Result += clb_Hobbies.Items[i] + " ,";
                    }
                    else
                    {
                        Result += clb_Hobbies.Items[i] + ".";
                    }

                    Cnt--;
                }
            }

            if (Flag == false)
            {
                lbl_Result.Visible = false;
            }
            else
            {
                lbl_Result.Text = Result;
                lbl_Result.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            cmb_Dept.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;

            for(int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
                clb_Hobbies.SelectedIndex = -1;
            }

            lbl_Result.Visible = false;
        }
    }
}
