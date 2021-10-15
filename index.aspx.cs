using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class register : System.Web.UI.Page
    {
        int userlevel;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (userlevel == 1)
            {
                Response.Redirect("profile.aspx");
            }
        }
    }
}