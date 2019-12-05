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
    public partial class log_in : Form

    {
        public string con = @"Data Source=DESKTOP-R8605NG\SQLSERVER;Initial Catalog=AIUB_Library_Management_System;Integrated Security=True";
        
        public log_in()
        {
            InitializeComponent();
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill the username and password properly");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else 
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                if (sql.State == ConnectionState.Open)
                {
                    string query1 = " Select * from log_in Where username = '" + textBox1.Text.Trim() + "' and password= '" + textBox2.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query1, sql);
                    SqlDataAdapter sda = new SqlDataAdapter(query1, sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);


                    if (dt.Rows.Count == 1)
                    {
                        SqlConnection sql2 = new SqlConnection(con);
                        sql2.Open();
                        if (sql.State == ConnectionState.Open)
                        {
                            string typeq = "Select usertype from log_in Where username= '" + textBox1.Text.Trim() + "'";
                            SqlCommand cmd2 = new SqlCommand(typeq, sql2);
                            cmd2.ExecuteNonQuery();
                            string type = (string)cmd2.ExecuteScalar();
                            if (type == "admin")
                            {

                                this.Hide();
                                mdi_user mu1 = new mdi_user();
                                mu1.Show();

                            }
                            if (type == "student")
                            {

                                this.Hide();
                                Student_MDI_Form mu2 = new Student_MDI_Form();
                                mu2.Show();
                                
                               
                                

                            }


                        }
                        else
                            MessageBox.Show("Member doesn't exist!");

                    }
                    else
                        MessageBox.Show("Incorrect email or password!");


                }
            }
        }

        private void Create_Account_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_info st = new student_info();
            st.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }

       
    }

