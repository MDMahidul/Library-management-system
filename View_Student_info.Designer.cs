namespace Libery_management
{
    partial class View_Student_info
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.student_email = new System.Windows.Forms.TextBox();
            this.student_contact = new System.Windows.Forms.TextBox();
            this.student_sem = new System.Windows.Forms.TextBox();
            this.student_dept = new System.Windows.Forms.TextBox();
            this.student_id = new System.Windows.Forms.TextBox();
            this.student_name = new System.Windows.Forms.TextBox();
            this.Close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Studen\'s Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.student_email);
            this.panel1.Controls.Add(this.student_contact);
            this.panel1.Controls.Add(this.student_sem);
            this.panel1.Controls.Add(this.student_dept);
            this.panel1.Controls.Add(this.student_id);
            this.panel1.Controls.Add(this.student_name);
            this.panel1.Location = new System.Drawing.Point(156, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 267);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(669, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Student Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(642, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Student Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Name";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(406, 195);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(173, 69);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // student_email
            // 
            this.student_email.Location = new System.Drawing.Point(811, 125);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(143, 22);
            this.student_email.TabIndex = 5;
            // 
            // student_contact
            // 
            this.student_contact.Location = new System.Drawing.Point(479, 130);
            this.student_contact.Name = "student_contact";
            this.student_contact.Size = new System.Drawing.Size(151, 22);
            this.student_contact.TabIndex = 4;
            // 
            // student_sem
            // 
            this.student_sem.Location = new System.Drawing.Point(188, 130);
            this.student_sem.Name = "student_sem";
            this.student_sem.Size = new System.Drawing.Size(143, 22);
            this.student_sem.TabIndex = 3;
            // 
            // student_dept
            // 
            this.student_dept.Location = new System.Drawing.Point(811, 24);
            this.student_dept.Name = "student_dept";
            this.student_dept.Size = new System.Drawing.Size(143, 22);
            this.student_dept.TabIndex = 2;
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(479, 24);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(151, 22);
            this.student_id.TabIndex = 1;
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(188, 21);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(143, 22);
            this.student_name.TabIndex = 0;
            // 
            // Close_button
            // 
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(879, 224);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 40);
            this.Close_button.TabIndex = 20;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // View_Student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Student_info";
            this.Text = "View_Student_info";
            this.Load += new System.EventHandler(this.View_Student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox student_email;
        private System.Windows.Forms.TextBox student_contact;
        private System.Windows.Forms.TextBox student_sem;
        private System.Windows.Forms.TextBox student_dept;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Button Close_button;
    }
}