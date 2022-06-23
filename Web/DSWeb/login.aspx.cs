using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ip_web.ServiceReference1;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace ip_web
{
    public partial class login : System.Web.UI.Page
    {


       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ip_prj;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from staff where id =@pass and user_name=@uname", con);
            //cmd.Parameters.AddWithValue("@uname", TextBox1.Text);
            //cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    Response.Redirect("staff.aspx");Button1_Click1
            //}
            //else
            //{
            //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            //}

            if (TextBox1.Text == "teacher")
            {
                Staff s = new Staff();

                Service1Client service = new Service1Client();
               s = service.WebLogin(TextBox2.Text);
                if (s != null)
                {


                   Session["user"] = s.User_name;
                    Session["id"] = TextBox2.Text;
                    // Label1.Text = "hello"+Session["user"];

                    // Label1.Text = "login successful " + Session["user"] + " !";
                    // ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");

                    Response.Redirect("staff.aspx");


                }
                else if(s==null)
                {

                    Label1.Text = "Invalid user name or password!try again..";
                    //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
                    //Response.Redirect("~/WebForm1.aspx");

                }

            }
            else if (TextBox1.Text == "student")
            {

                Student s = new Student();

                Service1Client service = new Service1Client();
                s = service.WebLogin2(TextBox2.Text);
                if (s != null)
                {
                    Session["section"] = s.User_name;
                    Session["admission_no"] = TextBox2.Text;
                    // Label1.Text = "hello"+Session["user"];

                    // Label1.Text = "login successful " + Session["user"] + " !";
                    // ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");

                    Response.Redirect("Cstudents.aspx");
                }
                else if (s==null)
                {

                    Label1.Text = "Invalid user name or password!try again..";
                    //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
                    //Response.Redirect("~/WebForm1.aspx");

                }

            }




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ip_prj;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from student where id =@pass and user_name=@uname", con);
            //cmd.Parameters.AddWithValue("@uname", TextBox1.Text);
            //cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0 && TextBox1.Text == "ComStudent")
            //{
            //    Response.Redirect("Cstudents.aspx");
            //}
            //else if(dt.Rows.Count > 0 && TextBox1.Text == "MngStudent") { Response.Redirect("Mstudents.aspx"); }
            //else if (dt.Rows.Count > 0 && TextBox1.Text == "EngStudent") { Response.Redirect("Estudents.aspx"); }
            //else
            //{
            //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            //}
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}