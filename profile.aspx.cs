using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class profile : System.Web.UI.Page
    {
        static ArrayList PersonsArrayList;
        int userlevel;
        object userSession;

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
                SetUpPage();
            }

            if (Application["Persons"] == null)
            {
                PersonsArrayList = new ArrayList();
                Application["Persons"] = PersonsArrayList;
            }

            PersonsArrayList = (ArrayList)Application["Persons"];

            // Checking session from login (if it's correct)
            userSession = Session["currentUser"];
            //Label_sInfo.Text = "User: --> " + userSession + " <--";
            //Label_mInfo.Text = "User: --> " + userSession + " <--";

            staff.Visible = false;
            magician.Visible = false;

            for (int i = 0; i < PersonsArrayList.Count; i++)
            {
                if ((PersonsArrayList[i]).GetType().Name == "Staff" && (Person)PersonsArrayList[i] == userSession)
                {
                    staff.Visible = true;
                    magician.Visible = false;

                    Label_suserTitle.Text = ((Staff)PersonsArrayList[i]).PersonName + " (" + ((Staff)PersonsArrayList[i]).Title + ")";

                    if (!Page.IsPostBack)
                    {
                        foreach (Person p in PersonsArrayList)
                        {
                            ListBox_Persons.Items.Add(p.ToString());
                        }
                    }

                    Label_Persons.Text = "All Persons";
                }

                else if ((PersonsArrayList[i]).GetType().Name == "Magician" && (Person)PersonsArrayList[i] == userSession)
                {
                    staff.Visible = false;
                    magician.Visible = true;

                    Label_muserTitle.Text = ((Magician)PersonsArrayList[i]).PersonName + " (" + ((Magician)PersonsArrayList[i]).Title + ")";

                    if (!Page.IsPostBack)
                    {
                        foreach (Person p in PersonsArrayList)
                        {
                            if (p.Title == "Magician")
                            {
                                ListBox_Persons.Items.Add(p.ToString());
                            }
                        }
                    }

                    Label_Persons.Text = "All Magicians";
                }
            }
        }

        private void SetUpPage()
        {
            if (userlevel != 1)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void Button_sUpdate_Click(object sender, EventArgs e)
        {
            string name = TextBox_sName.Text.ToLower();
            name = new CultureInfo("en-US").TextInfo.ToTitleCase(name);

            string password = TextBox_sPass.Text.ToLower();
            password = new CultureInfo("en-US").TextInfo.ToTitleCase(password);

            string salary = TextBox_sSalary.Text.ToLower();
            salary = new CultureInfo("en-US").TextInfo.ToTitleCase(salary);

            if (TextBox_sName.Text == "")
            {
                Label_sInfo.Text = "Error: Enter name";
            }

            else if (TextBox_sPass.Text == "")
            {
                Label_sInfo.Text = "Error: Enter password";

            }

            else if(TextBox_sSalary.Text == "")
            {
                Label_sInfo.Text = "Error: Enter salary";
            }

            else
            {
                for (int i = 0; i < PersonsArrayList.Count; i++)
                {
                    if ((Person)PersonsArrayList[i] == userSession)
                    {
                        Staff s = (Staff)PersonsArrayList[i];

                        s.PersonName = name;
                        s.PersonPassword = password;
                        s.StaffSalary = Convert.ToDouble(salary);

                        userSession = s;
                        Session["currentUser"] = userSession;

                        Response.Redirect("profile.aspx");
                    }
                }
            }
        }

        protected void Button_mUpdate_Click(object sender, EventArgs e)
        {
            string name = TextBox_mName.Text.ToLower();
            name = new CultureInfo("en-US").TextInfo.ToTitleCase(name);

            string password = TextBox_mPass.Text.ToLower();
            password = new CultureInfo("en-US").TextInfo.ToTitleCase(password);

            if (TextBox_mName.Text == "")
            {
                Label_mInfo.Text = "Error: Enter name";
            }

            else if (TextBox_mPass.Text == "")
            {
                Label_mInfo.Text = "Error: Enter password";

            }
            else
            {
                for (int i = 0; i < PersonsArrayList.Count; i++)
                {
                    if ((Person)PersonsArrayList[i] == userSession)
                    {

                        Magician m = (Magician)PersonsArrayList[i];

                        m.PersonName = name;
                        m.PersonPassword = password;

                        userSession = m;
                        Session["currentUser"] = userSession;

                        Response.Redirect("profile.aspx");
                    }
                }
            }
        }

        protected void Button_AddTrick_Click(object sender, EventArgs e)
        {
            string tricks = TextBox_mTricks.Text.ToLower();
            tricks = new CultureInfo("en-US").TextInfo.ToTitleCase(tricks);

            if (TextBox_mTricks.Text == "")
            {
                Label_mInfo2.Text = "Error: Enter a trick";
            }

            else
            {
                for (int i = 0; i < PersonsArrayList.Count; i++)
                {
                    if ((Person)PersonsArrayList[i] == userSession)
                    {
                        Magician m = (Magician)PersonsArrayList[i];

                        m.AddFavouriteTrick(tricks);

                        userSession = m;
                        Session["currentUser"] = userSession;

                        Response.Redirect("profile.aspx");
                    }
                }
            }
        }
    }
}