using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_Employee_List : Form
    {
        public frm_Employee_List()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void frm_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_System_Data_Base_01DataSet3.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter4.Fill(this.employee_Management_System_Data_Base_01DataSet3.Employee_Details);
            // TODO: This line of code loads data into the 'employee_Management_System_Data_Base_01DataSet2.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter3.Fill(this.employee_Management_System_Data_Base_01DataSet2.Employee_Details);
            // TODO: This line of code loads data into the 'employee_Management_System_Data_Base_01DataSet1.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter2.Fill(this.employee_Management_System_Data_Base_01DataSet1.Employee_Details);
            // TODO: This line of code loads data into the 'employee_Management_System_Data_Base_01DataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter1.Fill(this.employee_Management_System_Data_Base_01DataSet.Employee_Details);
            // TODO: This line of code loads data into the 'employee_Management_System_Data_BaseDataSet1.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Management_System_Data_BaseDataSet1.Employee_Details);
        }
    }
}
