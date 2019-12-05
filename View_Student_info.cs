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
    public partial class View_Student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R8605NG\SQLSERVER;Initial Catalog=AIUB_Library_Management_System;Integrated Security=True");
        

        public View_Student_info()
        {
            InitializeComponent();
        }

        private void View_Student_info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            Fill_Grid();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try 
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_name like ('%"+ textBox1.Text +"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info where id="+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                student_name.Text = dr["student_name"].ToString();
                student_id.Text = dr["student_id"].ToString();
                student_dept.Text = dr["student_department"].ToString();
                student_sem.Text = dr["student_sem"].ToString();
                student_contact.Text = dr["student_contact"].ToString();
                student_email.Text = dr["student_email"].ToString();



            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update student_info  set student_name='"+ student_name.Text +"', student_id='"+ student_id.Text +"' , student_department ='"+ student_dept.Text+"' , student_sem='"+ student_sem.Text +"' , student_contact='"+ student_contact.Text +"' , student_email='"+ student_email.Text +"' where id="+i+" ";
            cmd.ExecuteNonQuery();
            Fill_Grid();
            MessageBox.Show("Updated Successfully");
        }

        public void Fill_Grid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
