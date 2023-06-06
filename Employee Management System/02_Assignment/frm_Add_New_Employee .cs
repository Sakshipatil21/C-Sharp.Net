using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Employee_Management_System_Data_Base;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Emp_ID) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }

            tb_Id.Text = Convert.ToString(Cnt);

            Con_Close();
        }

        void clear_controls()
        {
            tb_Name.Clear();
            tb_MobNo.Clear();
            dtp_DOB.Text = "31-12-2009";
            cmb_Des.SelectedIndex = -1;

            Auto_Incr();
            tb_Name.Focus();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Common_Content.Log_Uname;
            clear_controls();
            tb_Name.Focus();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_controls();
        }

        private void btn_Emp_List_Click(object sender, EventArgs e)
        {
            frm_Employee_List obj = new frm_Employee_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Id.Text != "" && tb_Name.Text != "" && tb_MobNo.Text != "" && cmb_Des.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Employee_Details Values(@Id, @Nm, @MobNo, @DOB, @Des)";

                cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Id.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_MobNo.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Des.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                clear_controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Incomplete Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                Con_Close();
        }

        private void lbl_Uname_Click(object sender, EventArgs e)
        {

        }
    }
}
