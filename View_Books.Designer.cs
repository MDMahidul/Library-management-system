namespace Libery_management
{
    partial class View_Books
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Author_Name_Search = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Book_Name_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Delete_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.booksqty = new System.Windows.Forms.TextBox();
            this.booksprice = new System.Windows.Forms.TextBox();
            this.publicationname = new System.Windows.Forms.TextBox();
            this.authorname = new System.Windows.Forms.TextBox();
            this.booksname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(885, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Author_Name_Search);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Book_Name_Search);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 230);
            this.panel1.TabIndex = 1;
            // 
            // Author_Name_Search
            // 
            this.Author_Name_Search.Location = new System.Drawing.Point(152, 181);
            this.Author_Name_Search.Name = "Author_Name_Search";
            this.Author_Name_Search.Size = new System.Drawing.Size(75, 23);
            this.Author_Name_Search.TabIndex = 5;
            this.Author_Name_Search.Text = "Search";
            this.Author_Name_Search.UseVisualStyleBackColor = true;
            this.Author_Name_Search.Click += new System.EventHandler(this.Author_Name_Search_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Author Name";
            // 
            // Book_Name_Search
            // 
            this.Book_Name_Search.Location = new System.Drawing.Point(152, 105);
            this.Book_Name_Search.Name = "Book_Name_Search";
            this.Book_Name_Search.Size = new System.Drawing.Size(75, 23);
            this.Book_Name_Search.TabIndex = 2;
            this.Book_Name_Search.Text = "Search";
            this.Book_Name_Search.UseVisualStyleBackColor = true;
            this.Book_Name_Search.Click += new System.EventHandler(this.Book_Name_Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Books Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delete_button);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.booksqty);
            this.panel2.Controls.Add(this.booksprice);
            this.panel2.Controls.Add(this.publicationname);
            this.panel2.Controls.Add(this.authorname);
            this.panel2.Controls.Add(this.booksname);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(358, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 154);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(363, 59);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 12;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // booksqty
            // 
            this.booksqty.Location = new System.Drawing.Point(648, 107);
            this.booksqty.Name = "booksqty";
            this.booksqty.Size = new System.Drawing.Size(234, 22);
            this.booksqty.TabIndex = 11;
            // 
            // booksprice
            // 
            this.booksprice.Location = new System.Drawing.Point(648, 59);
            this.booksprice.Name = "booksprice";
            this.booksprice.Size = new System.Drawing.Size(234, 22);
            this.booksprice.TabIndex = 10;
            // 
            // publicationname
            // 
            this.publicationname.Location = new System.Drawing.Point(127, 107);
            this.publicationname.Name = "publicationname";
            this.publicationname.Size = new System.Drawing.Size(214, 22);
            this.publicationname.TabIndex = 8;
            // 
            // authorname
            // 
            this.authorname.Location = new System.Drawing.Point(127, 59);
            this.authorname.Name = "authorname";
            this.authorname.Size = new System.Drawing.Size(214, 22);
            this.authorname.TabIndex = 7;
            // 
            // booksname
            // 
            this.booksname.Location = new System.Drawing.Point(127, 16);
            this.booksname.Name = "booksname";
            this.booksname.Size = new System.Drawing.Size(214, 22);
            this.booksname.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Books Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Books Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Books Purchase date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Author Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publication Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Books Name";
            // 
            // Close_button
            // 
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(1185, 540);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 27);
            this.Close_button.TabIndex = 20;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // View_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 579);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Books";
            this.Text = "View_Books";
            this.Load += new System.EventHandler(this.View_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Book_Name_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Author_Name_Search;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox booksqty;
        private System.Windows.Forms.TextBox booksprice;
        private System.Windows.Forms.TextBox publicationname;
        private System.Windows.Forms.TextBox authorname;
        private System.Windows.Forms.TextBox booksname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Close_button;
    }
}