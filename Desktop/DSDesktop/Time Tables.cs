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
    public partial class Time_Tables : Form
    {
        private string[] SE = new[] { "SE01", "SE02", "SE03", "SE04", "CN03", "CN04" };
        private string[] CN = new[] { "CN01", "CN02", "CN03", "CN04", "SE02", "SE03" };
        private string[] CSCU = new[] { "CSCU01", "CSCU02", "CSCU03", "CSCU04", "CN03", "SE03" };
        private string[] CS = new[] { "CS01", "CS02", "CS03", "CS04" };

        private string[] SE01 = new[] { "viraj", "chaminda" };
        private string[] SE02 = new[] { "kasun", "ashen" };
        private string[] SE03 = new[] { "kushan" };
        private string[] SE04 = new[] { "gayan" };
        private string[] CN01 = new[] { "nimal", "udesh" };
        private string[] CN02 = new[] { "saliya", "damithra" };
        private string[] CN03 = new[] { "sujeewa" };
        private string[] CN04 = new[] { "manoja", "dileeka" };
        private string[] CSCU01 = new[] { "kushan", "gayan" };
        private string[] CSCU02 = new[] { "udesh" };
        private string[] CSCU03 = new[] { "dileeka" };
        private string[] CSCU04 = new[] { "viraj", "chaminda" };
        private string[] CS01 = new[] { "viraj" };
        private string[] CS02 = new[] { "tissa", "malith" };
        private string[] CS03 = new[] { "saliya", "kasun" };
        private string[] CS04 = new[] { "udesh", "nimal" };

        private string[] LH = new[] { "lec001", "lec002","lec003","lec004","lec005" };
        private string[] Lb = new[] { "lab001", "lab002","lab003" };

        private string[] HRM  = new[] { "HRM", "RM","MP" };
        private string[] BM = new[] { "Acc", "marketing" };

        private string[] HRMm = new[] { "udara", "sara" };
        private string[] RM = new[] { "kamal" };
        private string[] MP = new[] { "tharidu" };
        private string[] Acc = new[] { "yapa", "anton" };
        private string[] marketing = new[] { "savi" };


        public Time_Tables()
        {
            InitializeComponent();
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            comboBox13.SelectedIndexChanged += comboBox13_SelectedIndexChanged;
            comboBox11.SelectedIndexChanged += comboBox11_SelectedIndexChanged;

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox3.SelectedItem as string;
            switch (selectedValue)
            {
                case "SE01":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(SE01);
                    break;
                case "SE02":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(SE02);
                    break;
                case "SE03":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(SE03);
                    break;
                case "SE04":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(SE04);
                    break;
                case "CN01":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CN01);
                    break;
                case "CN02":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CN02);
                    break;
                case "CN03":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CN03);
                    break;
                case "CN04":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CN04);
                    break;
                case "CSCU01":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CSCU01);
                    break;
                case "CSCU02":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CSCU02);
                    break;
                case "CSCU03":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CSCU03);
                    break;
                case "CSCU04":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CSCU04);
                    break;
                case "CS01":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CS01);
                    break;
                case "CS02":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CS02);
                    break;
                case "CS03":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CS03);
                    break;
                case "CS04":
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(CS04);
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem as string;

            switch (selectedValue)
            {
                case "Software Engineering":
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(SE);
                    break;
                case "Computer Networks":
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(CN);
                    break;
                case "Computer Security":
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(CSCU);
                    break;
                case "Computer Science":
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(CS);
                    break;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox6.SelectedItem as string;

            switch (selectedValue)
            {
                case "Lecture Hall":
                    comboBox7.Items.Clear();
                    comboBox7.Items.AddRange(LH);
                    break;
                case "Lab":
                    comboBox7.Items.Clear();
                    comboBox7.Items.AddRange(Lb);
                    break;
                

            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox13.SelectedItem as string;

            switch (selectedValue)
            {
                case "HRM":
                    comboBox12.Items.Clear();
                    comboBox12.Items.AddRange(HRM);
                    break;
                case "BM":
                    comboBox12.Items.Clear();
                    comboBox12.Items.AddRange(BM);
                    break;
                

            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox12.SelectedItem as string;

            switch (selectedValue)
            {
                case "HRMm":
                    comboBox11.Items.Clear();
                    comboBox11.Items.AddRange(HRMm);
                    break;
                case "RM":
                    comboBox11.Items.Clear();
                    comboBox11.Items.AddRange(RM);
                    break;
                case "MP":
                    comboBox11.Items.Clear();
                    comboBox11.Items.AddRange(MP);
                    break;
                case "Acc":
                    comboBox11.Items.Clear();
                    comboBox11.Items.AddRange(Acc);
                    break;
                case "marketing":
                    comboBox11.Items.Clear();
                    comboBox11.Items.AddRange(marketing);
                    break;


            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
           
            }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Time_Tables_Load(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TimeTable t = new TimeTable();

            Service1Client service = new Service1Client();
            t = service.SearchComputingTable(textBox3.Text);
            if (t != null)
            {
                comboBox1.Text = t.Grade;
                comboBox2.Text = t.Class;
                comboBox3.Text = t.Subject;
                comboBox4.Text = t.Teacher;
                dateTimePicker1.Value = Convert.ToDateTime(t.Date);
                //label28.Text = t.Date;
                comboBox5.Text = t.Time;
                comboBox6.Text = t.Class_Room_Lab;
                comboBox7.Text = t.Class_Room_Lab_ID;



            }

            else
            {

                MessageBox.Show("Invalid ID");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            TimeTable t = new TimeTable();

            Service1Client service = new Service1Client();
            t = service.SearchManagementTable(textBox2.Text);
            if (t != null)
            {
                comboBox14.Text = t.Grade;
                comboBox13.Text = t.Class;
                comboBox12.Text = t.Subject;
                comboBox11.Text = t.Teacher;
                //label29.Text = t.Date;
                dateTimePicker2.Value = Convert.ToDateTime(t.Date);
                comboBox10.Text = t.Time;
                comboBox9.Text = t.Class_Room_Lab;
                comboBox8.Text = t.Class_Room_Lab_ID;



            }

            else
            {

                MessageBox.Show("Invalid ID");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            TimeTable t = new TimeTable();

            Service1Client service = new Service1Client();
            t = service.SearchengineeringTable(textBox1.Text);
            if (t != null)
            {
                comboBox21.Text = t.Grade;
                comboBox20.Text = t.Class;
                comboBox19.Text = t.Subject;
                comboBox18.Text = t.Teacher;
                // label30.Text = t.Date;
                dateTimePicker3.Value = Convert.ToDateTime(t.Date);
                comboBox17.Text = t.Time;
                comboBox16.Text = t.Class_Room_Lab;
                comboBox15.Text = t.Class_Room_Lab_ID;



            }

            else
            {

                MessageBox.Show("Invalid ID");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void CombtnReset_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            label28.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void reset_tab2()
        {
            comboBox14.Text = "";
            comboBox13.Text = "";
            comboBox12.Text = "";
            comboBox11.Text = "";
            label29.Text = "";
            comboBox10.Text = "";
            comboBox9.Text = "";
            comboBox8.Text = "";
            dateTimePicker2.Value = DateTime.Now;
        }

        private void reset()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            label28.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void CombtnDelete_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            tt.No = textBox3.Text;

            Service1Client service = new Service1Client();
            int ans = service.DelcomineeringTimeTable(tt);
            if (ans == 1)
            {
                MessageBox.Show("Deleted..");
                reset();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void CombtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTable tt = new TimeTable();
                tt.No = textBox3.Text;
                tt.Grade = comboBox1.SelectedItem.ToString();
                tt.Class = comboBox2.SelectedItem.ToString();
                tt.Subject = comboBox3.SelectedItem.ToString();
                tt.Teacher = comboBox4.SelectedItem.ToString();
                tt.Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                tt.Time = comboBox5.SelectedItem.ToString();
                tt.Class_Room_Lab = comboBox6.SelectedItem.ToString();
                tt.Class_Room_Lab_ID = comboBox7.SelectedItem.ToString();

                Service1Client service = new Service1Client();
                int ans = service.UpcomineeringTimeTable(tt);
                if (ans == 1)
                {
                    MessageBox.Show("Updated..");
                    reset();
                }
                else
                {
                    MessageBox.Show("Error...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTable tt = new TimeTable();
                tt.Grade = comboBox1.SelectedItem.ToString();
                tt.Class = comboBox2.SelectedItem.ToString();
                tt.Subject = comboBox3.SelectedItem.ToString();
                tt.Teacher = comboBox4.SelectedItem.ToString();
                tt.Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                tt.Time = comboBox5.SelectedItem.ToString();
                tt.Class_Room_Lab = comboBox6.SelectedItem.ToString();
                tt.Class_Room_Lab_ID = comboBox7.SelectedItem.ToString();
                

                Service1Client service = new Service1Client();
                int ans = service.AddComputingTimeTable(tt);
                if (ans == 1)
                {
                    MessageBox.Show("Inserted..");
                    reset();
                }
                else
                {
                    MessageBox.Show("Error...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManbtnReset_Click(object sender, EventArgs e)
        {
            comboBox14.Text = "";
            comboBox13.Text = "";
            comboBox12.Text = "";
            comboBox11.Text = "";
            label29.Text = "";
            comboBox10.Text = "";
            comboBox9.Text = "";
            comboBox8.Text = "";
            dateTimePicker2.Value = DateTime.Now;
        }

        private void ManbtnDelete_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            tt.No = textBox2.Text;

            Service1Client service = new Service1Client();
            int ans = service.DelmngineeringTimeTable(tt);
            if (ans == 1)
            {
                MessageBox.Show("Deleted..");
                reset_tab2();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void ManbtnUpdate_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            tt.No = textBox2.Text;
            tt.Grade = comboBox14.SelectedItem.ToString();
            tt.Class = comboBox13.SelectedItem.ToString();
            tt.Subject = comboBox12.SelectedItem.ToString();
            tt.Teacher = comboBox11.SelectedItem.ToString();
            tt.Date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            tt.Time = comboBox10.SelectedItem.ToString();
            tt.Class_Room_Lab = comboBox9.SelectedItem.ToString();
            tt.Class_Room_Lab_ID = comboBox8.SelectedItem.ToString();

            Service1Client service = new Service1Client();
            int ans = service.UpmngineeringTimeTable(tt);
            if (ans == 1)
            {
                MessageBox.Show("Updated..");
                reset_tab2();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void ManbtnSave_Click(object sender, EventArgs e)//click event
        {
            TimeTable tt = new TimeTable();
            tt.Grade = comboBox14.SelectedItem.ToString();
            tt.Class = comboBox13.SelectedItem.ToString();
            tt.Subject = comboBox12.SelectedItem.ToString();
            tt.Teacher = comboBox11.SelectedItem.ToString();
            tt.Date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            tt.Time = comboBox10.SelectedItem.ToString();
            tt.Class_Room_Lab = comboBox9.SelectedItem.ToString();
            tt.Class_Room_Lab_ID = comboBox8.SelectedItem.ToString();

            Service1Client service = new Service1Client();
            int ans = service.AddManagementTimeTable(tt);
            if (ans == 1)
            {
                MessageBox.Show("Inserted..");
                reset_tab2();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void EngbtnReset_Click(object sender, EventArgs e)
        {

            comboBox21.Text = "";
            comboBox20.Text = "";
            comboBox19.Text = "";
            comboBox18.Text = "";
            label30.Text = "";
            comboBox17.Text = "";
            comboBox16.Text = "";
            comboBox15.Text = "";
            dateTimePicker3.Value = DateTime.Now;
        }

        private void reset_tab3()
        {
            comboBox21.Text = "";
            comboBox20.Text = "";
            comboBox19.Text = "";
            comboBox18.Text = "";
            label30.Text = "";
            comboBox17.Text = "";
            comboBox16.Text = "";
            comboBox15.Text = "";
            dateTimePicker3.Value = DateTime.Now;
        }



      

        private void EngbtnDelete_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            tt.No = textBox1.Text;

            Service1Client service = new Service1Client();
            int ans = service.DelEngineeringTimeTable(tt);
            if (ans == 1)
            {
                MessageBox.Show("Delelted..");
                reset_tab3();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void EngbtnUpdate_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            tt.No = textBox1.Text;
            tt.Grade = comboBox21.SelectedItem.ToString();
            tt.Class = comboBox20.SelectedItem.ToString();
            tt.Subject = comboBox19.SelectedItem.ToString();
            tt.Teacher = comboBox18.SelectedItem.ToString();
            tt.Date = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            tt.Time = comboBox17.SelectedItem.ToString();
            tt.Class_Room_Lab = comboBox16.SelectedItem.ToString();
            tt.Class_Room_Lab_ID = comboBox15.SelectedItem.ToString();

            Service1Client service = new Service1Client();
            int ans = service.UpEngineeringTimeTable(tt);
            if (ans == 1)
            {
                MessageBox.Show("Updated..");
                reset_tab3();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void EngbtnSave_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            tt.Grade = comboBox21.SelectedItem.ToString();
            tt.Class = comboBox20.SelectedItem.ToString();
            tt.Subject = comboBox19.SelectedItem.ToString();
            tt.Teacher = comboBox18.SelectedItem.ToString();
            tt.Date = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            tt.Time = comboBox17.SelectedItem.ToString();
            tt.Class_Room_Lab = comboBox16.SelectedItem.ToString();
            tt.Class_Room_Lab_ID = comboBox15.SelectedItem.ToString();

            Service1Client service = new Service1Client();
            int ans = service.AddEngineeringTimeTable(tt);
            if (ans == 1)
            {
                MessageBox.Show("Inserted..");
                reset_tab3();
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
