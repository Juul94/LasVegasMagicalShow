using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class login : System.Web.UI.Page
    {
        static ArrayList PersonsArrayList;
        int userlevel;
        object userSession;

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox_LoginPassword.TextMode = TextBoxMode.Password;

            if (Application["Persons"] == null)
            {
                PersonsArrayList = new ArrayList();
                Application["Persons"] = PersonsArrayList;
            }

            PersonsArrayList = (ArrayList)Application["Persons"];
        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            string name = TextBox_LoginName.Text.ToLower();
            name = new CultureInfo("en-US").TextInfo.ToTitleCase(name);

            string password = TextBox_LoginPassword.Text.ToLower();
            password = new CultureInfo("en-US").TextInfo.ToTitleCase(password);

            if(PersonsArrayList.Count == 0)
            {
                Label_ShowInfo.Text = "User not found!";
            }

            else
            {
                for (int i = 0; i < PersonsArrayList.Count; i++)
                {
                    if (((Person)PersonsArrayList[i]).Title == "Staff")
                    {
                        if (((Staff)PersonsArrayList[i]).PersonName == name && ((Staff)PersonsArrayList[i]).PersonPassword == password)
                        {
                            //Title = "Staff";

                            userlevel = 1;
                            Session["mylevel"] = userlevel;

                            userSession = PersonsArrayList[i];
                            Session["currentUser"] = userSession;

                            PersonsArrayList = (ArrayList)Application["Persons"];

                            Response.Redirect("profile.aspx");
                        }

                        else
                        {
                            Label_ShowInfo.Text = "Wrong details! Please try again";
                        }
                    }

                    else if (((Person)PersonsArrayList[i]).Title == "Magician")
                    {
                        if (((Magician)PersonsArrayList[i]).PersonName == name && ((Magician)PersonsArrayList[i]).PersonPassword == password)
                        {
                            //Title = "Magician";

                            userlevel = 1;
                            Session["mylevel"] = userlevel;

                            userSession = PersonsArrayList[i];
                            Session["currentUser"] = userSession;

                            PersonsArrayList = (ArrayList)Application["Persons"];

                            Response.Redirect("profile.aspx");
                        }

                        else
                        {
                            Label_ShowInfo.Text = "Wrong details! Please try again";
                        }
                    }
                }
            }
        }
    }
}