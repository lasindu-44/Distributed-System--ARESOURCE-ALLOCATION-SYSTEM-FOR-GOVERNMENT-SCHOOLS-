using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ip_prj
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            datetime();      }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
    if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Login Successful..!!");
                
                Form1 ad = new Form1();
                this.Hide();
                ad.ShowDialog();
                
                this.Close();
                
            }
            else {
                MessageBox.Show("Login Failed..!");
            }

        }

        

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        private void datetime() {
            String date = DateTime.Today.ToString("yyyy-MM-dd");
            textBox3.Text = date;
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }
    }
}
