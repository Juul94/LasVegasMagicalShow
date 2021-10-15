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
    public partial class index1 : System.Web.UI.Page
    {
        int userlevel; // 1 = logged in, else 0 if not logged in
        ArrayList PersonsArrayList;
        //private ArrayList magicianFavTricks;
        //object userSession;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Hiding our fields till the dropdown has a value
            regStaff.Visible = false;
            regMagician.Visible = false;

            // If it doesn't not exist it will create and put it into the array list, else it wont
            if (Application["Persons"] == null)
            {
                PersonsArrayList = new ArrayList();
                Application["Persons"] = PersonsArrayList;
            }

            PersonsArrayList = (ArrayList)Application["Persons"];

            TextBox_sRegPass.TextMode = TextBoxMode.Password;
            TextBox_mRegPass.TextMode = TextBoxMode.Password;
        }

        protected void Button_sCreate_Click(object sender, EventArgs e)
        {
            string name = TextBox_sRegName.Text.ToLower();
            name = new CultureInfo("en-US").TextInfo.ToTitleCase(name);

            string password = TextBox_sRegPass.Text.ToLower();
            password = new CultureInfo("en-US").TextInfo.ToTitleCase(password);

            string salary = TextBox_sRegSalary.Text.ToLower();
            salary = new CultureInfo("en-US").TextInfo.ToTitleCase(salary);

            if(TextBox_sRegName.Text == "")
            {
                regStaff.Visible = true;
                Label_sInfo.Text = "Error: Enter name";
                
            }

            else if(TextBox_sRegPass.Text == "")
            {
                regStaff.Visible = true;
                Label_sInfo.Text = "Error: Enter password";
            }

            else if(TextBox_sRegSalary.Text == "")
            {
                regStaff.Visible = true;
                Label_sInfo.Text = "Error: Enter salary & password again";
            }

            else
            {
                Staff s = new Staff(name, password, Convert.ToDouble(salary));

                PersonsArrayList.Add(s);

                userlevel = 1;
                Session["mylevel"] = userlevel;

                Response.Redirect("login.aspx");
            }
        }

        protected void Button_mCreate_Click(object sender, EventArgs e)
        {
            string name = TextBox_mRegName.Text.ToLower();
            name = new CultureInfo("en-US").TextInfo.ToTitleCase(name);

            string password = TextBox_mRegPass.Text.ToLower();
            password = new CultureInfo("en-US").TextInfo.ToTitleCase(password);

            string tricks = TextBox_mRegTricks.Text.ToLower();
            tricks = new CultureInfo("en-US").TextInfo.ToTitleCase(tricks);

            if (TextBox_mRegName.Text == "" || TextBox_mRegName.Text == null)
            {
                regMagician.Visible = true;
                Label_mInfo.Text = "Error: Enter name";

            }

            else if (TextBox_mRegPass.Text == "")
            {
                regMagician.Visible = true;
                Label_mInfo.Text = "Error: Enter password";
            }

            if(TextBox_mRegPass.Text != "" && TextBox_mRegName.Text != "")
            {
                if (TextBox_mRegTricks.Text != "")
                {
                    Magician m = new Magician(name, password, tricks);
                    PersonsArrayList.Add(m);

                    userlevel = 1;
                }

                else
                {
                    Magician m = new Magician(name, password);
                    PersonsArrayList.Add(m);

                    userlevel = 1;
                }

                Session["mylevel"] = userlevel;
                Response.Redirect("login.aspx");
            }
        }

        protected void DropDownList_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList_Role.SelectedItem.Text == "Staff")
            {
                regStaff.Visible = true;
                regMagician.Visible = false;

                TextBox_sRegName.Text = "";
                TextBox_sRegPass.Text = "";
                TextBox_sRegSalary.Text = "";
                TextBox_mRegName.Text = "";
                TextBox_mRegPass.Text = "";
                TextBox_mRegTricks.Text = "";
            }

            else if (DropDownList_Role.SelectedItem.Text == "Magician")
            {
                regStaff.Visible = false;
                regMagician.Visible = true;

                TextBox_sRegName.Text = "";
                TextBox_sRegPass.Text = "";
                TextBox_sRegSalary.Text = "";
                TextBox_mRegName.Text = "";
                TextBox_mRegPass.Text = "";
                TextBox_mRegTricks.Text = "";
            }

            else
            {
                regStaff.Visible = false;
                regMagician.Visible = false;
            }
        }
    }
}