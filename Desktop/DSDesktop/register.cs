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


namespace ip_prj
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void dgv1stf()
        {
            dataGridView1.Columns["id"].DisplayIndex = 0;
            dataGridView1.Columns["first_name"].DisplayIndex = 1;
            dataGridView1.Columns["last_name"].DisplayIndex = 2;
            dataGridView1.Columns["user_name"].DisplayIndex = 3;
            dataGridView1.Columns["nic"].DisplayIndex = 4;

            dataGridView1.Columns["designation"].DisplayIndex = 5;
            dataGridView1.Columns["date_of_birth"].DisplayIndex = 6;
            dataGridView1.Columns["age"].DisplayIndex = 7;

            dataGridView1.Columns["qualifications"].DisplayIndex = 8;
            dataGridView1.Columns["joined_date"].DisplayIndex = 9;
            dataGridView1.Columns["phone"].DisplayIndex = 10;


        }
        private void dgv1stu()
        {
            dataGridView1.Columns["id"].DisplayIndex = 0;
            dataGridView1.Columns["first_name"].DisplayIndex = 1;
            dataGridView1.Columns["last_name"].DisplayIndex = 2;
            dataGridView1.Columns["user_name"].DisplayIndex = 3;
            dataGridView1.Columns["admission_no"].DisplayIndex = 4;

            dataGridView1.Columns["section"].DisplayIndex = 5;
            dataGridView1.Columns["grade"].DisplayIndex = 6;
            dataGridView1.Columns["class"].DisplayIndex = 7;
            dataGridView1.Columns["email"].DisplayIndex = 8;

            dataGridView1.Columns["phone"].DisplayIndex = 9;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Service1Client stafft = new Service1Client();
            dataGridView1.DataSource = stafft.getstf();
            dgv1stf();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Service1Client stud = new Service1Client();
            dataGridView1.DataSource = stud.getstu();
            dgv1stu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox13.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Value = 20;
            comboBox2.SelectedItem = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox2.Text = "";
            label24.Text = "";
            label23.Text = "";
            textBox6.Text = "";
            textBox12.Text = "";
        }
        private void reset_staff()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox13.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Value = 20;
            comboBox2.SelectedItem = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox2.Text = "";
            label24.Text = "";
            label23.Text = "";
            textBox6.Text = "";
            textBox12.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Id = textBox1.Text;

            Service1Client service = new Service1Client();
            int ans = service.Delstaff(s);
            if (ans == 1)
            {
                MessageBox.Show("Successfully Deleted");
                reset_staff();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Staff up = new Staff();
            up.Id = textBox1.Text;
            up.First_name = textBox2.Text;
            up.Last_name = textBox3.Text;
            up.User_name = textBox13.Text;
            up.NIC = textBox5.Text;
            up.Designation = comboBox1.SelectedItem.ToString();
            up.Date_of_birth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            up.Age = numericUpDown1.Value.ToString();
            up.Qualifications = comboBox2.SelectedItem.ToString();
            up.Joined_date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            up.Phone = textBox6.Text;
            up.Email = textBox12.Text;

            Service1Client service = new Service1Client();
            int ans = service.UpStaffTable(up);
            if (ans == 1)
            {
                MessageBox.Show("Successfully Updated");
                reset_staff();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();

            Service1Client service = new Service1Client();
            s = service.SearchStaff(textBox1.Text);
            if (s != null)
            {
                textBox2.Text = s.First_name;
                textBox3.Text = s.Last_name;
                textBox13.Text = s.User_name;
                textBox5.Text = s.NIC;
                comboBox1.Text = s.Designation;
                //label23.Text = s.Date_of_birth;
                numericUpDown1.Text = s.Age;
                comboBox2.Text = s.Qualifications;
               // label24.Text = s.Joined_date;
                textBox6.Text = s.Phone;
                textBox12.Text = s.Email;
                dateTimePicker1.Value = Convert.ToDateTime(s.Date_of_birth);
                dateTimePicker2.Value = Convert.ToDateTime(s.Joined_date);


            }

            else
            {

                MessageBox.Show("Invalid ID");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Staff rg = new Staff();
            rg.Id = textBox1.Text;
            rg.First_name = textBox2.Text;
            rg.Last_name = textBox3.Text;
            rg.User_name = textBox13.Text;
            rg.NIC = textBox5.Text;
            rg.Designation = comboBox1.SelectedItem.ToString();
            rg.Date_of_birth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            rg.Age = numericUpDown1.Value.ToString();
            rg.Qualifications = comboBox2.SelectedItem.ToString();
            rg.Joined_date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            rg.Phone = textBox6.Text;
            rg.Email = textBox12.Text;

            Service1Client service = new Service1Client();
            int ans = service.AddStaffTable(rg);
            if (ans == 1)
            {
                MessageBox.Show("Details Inserted Successfully");
                reset_staff();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void StuBtnDelete_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Id = textBox8.Text;

            Service1Client service = new Service1Client();
            int ans = service.Delstudent(s);
            if (ans == 1)
            {
                MessageBox.Show("Successfully Deleted..");

            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void StuBtnUpdate_Click(object sender, EventArgs e)
        {
            Student up = new Student();
            up.Id = textBox8.Text;
            up.First_name = textBox4.Text;
            up.Last_name = textBox7.Text;
            up.User_name = textBox14.Text;
            up.Admission_no = textBox9.Text;
            up.Section = comboBox5.SelectedItem.ToString();
            up.Grade = comboBox6.SelectedItem.ToString();
            up.Class = comboBox7.SelectedItem.ToString();
            up.Email = textBox10.Text;
            up.Phone = textBox11.Text;

            Service1Client service = new Service1Client();
            int ans = service.UpStudentTable(up);
            if (ans == 1)
            {
                MessageBox.Show("Successfully Updated");
                reset_students();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private String id_stu;
        private void StuBtnSearch_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            Service1Client service = new Service1Client();
            s = service.SearchStudent(textBox8.Text);
            if (s != null)
            {
                id_stu = s.Id;
                textBox4.Text = s.First_name;
                textBox7.Text = s.Last_name;
                textBox14.Text = s.User_name;
                textBox9.Text = s.Admission_no;
                comboBox5.Text = s.Section;
                comboBox6.Text = s.Grade;
                comboBox7.Text = s.Class;
                textBox11.Text = s.Phone;
                textBox10.Text = s.Email;


            }

            else
            {

                MessageBox.Show("Invalid ID");
            }
        }

        private void StuBtnSave_Click(object sender, EventArgs e)
        {

            if(textBox8.Text == id_stu)
            {
                MessageBox.Show("Duplicated value!");
            }
            else { 
            Student rg = new Student();
            rg.Id = textBox8.Text;
            rg.First_name = textBox4.Text;
            rg.Last_name = textBox7.Text;
            rg.User_name = textBox14.Text;
            rg.Admission_no = textBox9.Text;
            rg.Section = comboBox5.SelectedItem.ToString();
            rg.Grade = comboBox6.SelectedItem.ToString();
            rg.Class = comboBox7.SelectedItem.ToString();
            rg.Email = textBox10.Text;
            rg.Phone = textBox11.Text;

            Service1Client service = new Service1Client();
            int ans = service.AddStudentTable(rg);
            if (ans == 1)
            {
                MessageBox.Show("Student Details Saved Successfully!");
                reset_students();

            }
            else
            {
                MessageBox.Show("Error...");

            }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void StuBtnReset_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox14.Text = "";
            textBox9.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
        }

        private void reset_students()
        {
            textBox8.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox14.Text = "";
            textBox9.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
