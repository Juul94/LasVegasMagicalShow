using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class Page : System.Web.UI.MasterPage
    {
        int userlevel;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                userlevel = (int)Session["mylevel"];
            }

            catch (NullReferenceException nre)
            {
                userlevel = 0;
                Session["mylevel"] = userlevel;
            }

            finally
            {
                SetupPage();
            }

            // Get URL & Change Nav active class depending

            string getURL = HttpContext.Current.Request.Url.AbsolutePath;

            if(getURL == "/index.aspx")
            {
                body.Attributes["class"] = "addBgImage";
                Button_Home.Attributes["class"] = "active";
                Button_Register.Attributes["class"] = "";
                Button_Login.Attributes["class"] = "";
                Button_Profile.Attributes["class"] = "";
            }

            else if(getURL == "/register.aspx")
            {
                body.Attributes["class"] = "addBgImage_2";
                Button_Home.Attributes["class"] = "";
                Button_Register.Attributes["class"] = "active";
                Button_Login.Attributes["class"] = "";
                Button_Profile.Attributes["class"] = "";
            }

            else if (getURL == "/login.aspx")
            {
                body.Attributes["class"] = "addBgImage_2";
                Button_Home.Attributes["class"] = "";
                Button_Register.Attributes["class"] = "";
                Button_Login.Attributes["class"] = "active";
                Button_Profile.Attributes["class"] = "";
            }

            else if (getURL == "/profile.aspx")
            {
                body.Attributes["class"] = "addBgImage_2";
                Button_Home.Attributes["class"] = "";
                Button_Register.Attributes["class"] = "";
                Button_Login.Attributes["class"] = "";
                Button_Profile.Attributes["class"] = "active";
            }
        }

        private void SetupPage()
        {
            string getURL = HttpContext.Current.Request.Url.AbsolutePath;

            if (userlevel == 1 && getURL != "/login.aspx" && getURL != "/register.aspx" && getURL != "/index.aspx")
            {
                nav_profile.Visible = true;
                nav_logout.Visible = true;
                nav_login.Visible = false;
                nav_register.Visible = false;
                nav_home.Visible = false;
            }

            else
            {
                nav_profile.Visible = false;
                nav_logout.Visible = false;
                nav_login.Visible = true;
                nav_register.Visible = true;
                nav_home.Visible = true;
            }
        }

        protected void Button_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
        protected void Button_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
        protected void Button_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button_Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

        protected void Button_SignOut_Click(object sender, EventArgs e)
        {
            userlevel = 0;
            Session["mylevel"] = userlevel;
            Response.Redirect("login.aspx");
            SetupPage();
        }
    }
}