using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Libery_management
{
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R8605NG\SQLSERVER;Initial Catalog=AIUB_Library_Management_System;Integrated Security=True");
        public add_books()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books_info values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "'," + textBox5.Text + "," + textBox6.Text + " ," + textBox6.Text + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Books added successfully");
            

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";       
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void add_books_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
