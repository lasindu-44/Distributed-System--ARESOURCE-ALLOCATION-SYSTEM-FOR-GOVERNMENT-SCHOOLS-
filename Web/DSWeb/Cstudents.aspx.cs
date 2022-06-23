using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ip_web.ServiceReference1;

namespace ip_web
{
    public partial class Cstudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admission_no"] == null)
            {
                Response.Redirect("login.aspx");

               
            }
           else if (Session["section"] != null)
            {
                Label1.Text = Session["section"] + "";

                if (Label1.Text == "Grade 6 - 9 ")
                {
                    Service1Client com = new Service1Client();
                    GridView2.DataSource = com.GetCurrentComTimeTable();
                    GridView2.DataBind();
                    Label2.Text = "Today Student Time Table (Grade 6-9)";
                }
                if (Label1.Text == "Grade 10 - 11 O/L ")
                {
                    Service1Client com = new Service1Client();
                    GridView2.DataSource = com.GetCurrentMngTimeTable();
                    GridView2.DataBind();
                    Label2.Text = "Today Student Time Table (Grade 10-11) ";

                }
                if (Label1.Text == "Grade 12 - 13 A/L")
                {
                    Service1Client com = new Service1Client();
                    GridView2.DataSource = com.GetCurrentEngTimeTable();
                    GridView2.DataBind();
                    Label2.Text = "Today Student Time Table(Grade 12-13)";

                }


            }
            
          

            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
             if (Label1.Text == "Grade 6 - 9 ")
            {
                Service1Client com = new Service1Client();
                GridView1.DataSource = com.GetComTimeTable();
                GridView1.DataBind();
            }
            else if (Label1.Text == "Grade 10 - 11 O/L ")
            {
                Service1Client com = new Service1Client();
                GridView1.DataSource = com.GetmngTimeTable();
                GridView1.DataBind();

            }
            else if (Label1.Text == "Grade 12 - 13 A/L")
            {
                Service1Client com = new Service1Client();
                GridView1.DataSource = com.GetengTimeTable();
                GridView1.DataBind();

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Session.Remove("id");
            Response.Redirect("login.aspx");
        }
    }
}