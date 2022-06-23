using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ip_web.ServiceReference1;

namespace ip_web
{
    public partial class staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            

            if (Session["id"] == null)
            {
                Response.Redirect("login.aspx");


            }
            else
            {
                currenttimetbl();
            }
           
        }

        protected void currenttimetbl()
        {
            Service1Client com = new Service1Client();
            GridView2.DataSource = com.GetCurrentComTimeTable();
            GridView2.DataBind();

            GridView3.DataSource = com.GetCurrentEngTimeTable();
            GridView3.DataBind();

            GridView5.DataSource = com.GetCurrentMngTimeTable();
            GridView5.DataBind();
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Service1Client com = new Service1Client();
            GridView1.DataSource = com.GetComTimeTable();
            GridView1.DataBind();
            
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Service1Client com = new Service1Client();
            GridView1.DataSource = com.GetmngTimeTable();
            GridView1.DataBind();
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Service1Client com = new Service1Client();
            GridView1.DataSource = com.GetengTimeTable();
            GridView1.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Session.Remove("user");
            Session.Remove("id");
            Response.Redirect("login.aspx");
        }

        protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}