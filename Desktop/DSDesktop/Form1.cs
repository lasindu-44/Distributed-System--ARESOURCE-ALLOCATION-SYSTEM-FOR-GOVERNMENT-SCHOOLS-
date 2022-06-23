using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ip_prj.ServiceReference1;
using System.Net;
using System.Net.Mail;

namespace ip_prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            viewstfidandemail();

        }


        MailMessage message;
        SmtpClient smtp;

        private void dgv1()
        {
            dataGridView1.Columns["no"].DisplayIndex = 0;
            dataGridView1.Columns["grade"].DisplayIndex = 5;
            dataGridView1.Columns["class"].DisplayIndex = 2;
            dataGridView1.Columns["subject"].DisplayIndex = 3;
            dataGridView1.Columns["teacher"].DisplayIndex = 4;
            dataGridView1.Columns["date"].DisplayIndex = 1;
            dataGridView1.Columns["time"].DisplayIndex = 8;
             dataGridView1.Columns["class_room_lab"].DisplayIndex = 6;
            dataGridView1.Columns["class_room_lab_id"].DisplayIndex = 7;

            dataGridView1.Columns[0].Width = 55;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 160;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 25;
            dataGridView1.Columns[8].Width = 140;
        }
        private void viewstfidandemail() {
   
            Service1Client com = new Service1Client();
            
            dataGridView2.DataSource = com.getstfIDnEmail();
            dataGridView2.Columns["id"].DisplayIndex = 0;
            dataGridView2.Columns["email"].DisplayIndex = 1;
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Time_Tables tt = new Time_Tables();
            tt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client com = new Service1Client();
            dataGridView1.DataSource = com.GetComTimeTable();
            dgv1();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Service1Client mng = new Service1Client();
            dataGridView1.DataSource = mng.GetmngTimeTable();
           dgv1();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service1Client eng = new Service1Client();
            dataGridView1.DataSource = eng.GetengTimeTable();
           dgv1();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Service1Client com = new Service1Client();
            dataGridView1.DataSource = com.GetComTimeTable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Service1Client mng = new Service1Client();
            dataGridView1.DataSource = mng.GetmngTimeTable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Service1Client eng = new Service1Client();
            dataGridView1.DataSource = eng.GetengTimeTable();
        }

   

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                button6.Enabled = false;
                button7.Visible = true;
                message = new MailMessage();

                if (Class1.IsValidEmail(textBox1.Text))
                {
                    message.To.Add(textBox1.Text);
                }

                if (Class1.IsValidEmail(textBox2.Text))
                {
                    message.CC.Add(textBox3.Text);
                }
                message.Subject = textBox4.Text;
                message.From = new MailAddress("pramudika.dana@gmail.com");
                message.Body = textBox2.Text;
                if (linkLabel1.Text.Length > 0)
                {
                    if (System.IO.File.Exists(linkLabel1.Text))
                    {
                        message.Attachments.Add(new Attachment(linkLabel1.Text));
                    }
                }

                // set smtp details
                smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("pramudika.dana@gmail.com", "19950119m");
                smtp.SendAsync(message, message.Subject);
                smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                button7.Visible = false;
                button6.Enabled = true;
            }
        }

        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Email sending cancelled!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Email sent sucessfully!");
            }

            button7.Visible = false;
            button6.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                linkLabel1.Text = openFileDialog1.FileName;
                linkLabel1.Visible = true;
                linkLabel1.Visible = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
