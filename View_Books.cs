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
    public partial class View_Books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R8605NG\SQLSERVER;Initial Catalog=AIUB_Library_Management_System;Integrated Security=True");
        public View_Books()
        {
            InitializeComponent();
        }



        private void View_Books_Load(object sender, EventArgs e)
        {
            display_updated_books();
            
        }

        private void Book_Name_Search_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Author_Name_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_author_name like('%" + textBox2.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                panel2.Visible = false;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            panel2.Visible = true;

           


                try
                {
                    int i;
                    i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                   

                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from books_info where Id=" + i + " ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        booksname.Text = dr["books_name"].ToString();
                        authorname.Text = dr["books_author_name"].ToString();
                        publicationname.Text = dr["books_publication_name"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dr["books_purchase_date"].ToString());
                        booksprice.Text = dr["books_price"].ToString();
                        booksqty.Text = dr["books_quantity"].ToString();


                    }

                    con.Close();
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Selected Row is empty ");
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try 
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update books_info set books_name='" + booksname.Text +"',books_author_name='" + authorname.Text +"', books_publication_name='" +publicationname.Text +"', books_purchase_date='" + dateTimePicker1.Value +"',books_price="+booksprice.Text+" ,books_quantity='"+ booksqty.Text +"' where Id="+i+" ";
                cmd.ExecuteNonQuery();
                con.Close();
                display_updated_books();
                MessageBox.Show("Updated successfully");
                con.Close();
                panel2.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void display_updated_books()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete books_info   where Id=" + i + " ";
                cmd.ExecuteNonQuery();
                con.Close();
                display_updated_books();
                MessageBox.Show("delete successfully");
                con.Close();
                panel2.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info ";
                cmd.ExecuteNonQuery();
                con.Close();
               
               
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


       

        


    

