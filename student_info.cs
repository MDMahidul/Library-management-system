using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Libery_management
{
    public partial class student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R8605NG\SQLSERVER;Initial Catalog=AIUB_Library_Management_System;Integrated Security=True");
        string student;


        public student_info()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (studentname.Text == "" || studentid.Text == "" || studentdepartment.Text == "" || studentsemester.Text == "" || studentcontact.Text == "" || studentemail.Text == "" || username.Text == "" || password.Text == "")
            {


                MessageBox.Show("Please Fill all the Requirements");

            }
            else{
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into student_info values('" + studentname.Text + "','" + studentid.Text + "','" + studentdepartment.Text + "','" + studentsemester.Text + "','" + studentcontact.Text + "','" + studentemail.Text + "','" + username.Text + "','" + password.Text + "')";
                cmd.ExecuteNonQuery();
                

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into log_in values('"+ username.Text +"','"+ password.Text  +"','"+  radioButton1.Text+"')";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Successfull");

                this.Hide();
                log_in l = new log_in();
                l.Show();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            }

        }

        private void student_info_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
