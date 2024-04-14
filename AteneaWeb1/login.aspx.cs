using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnL1_Click(object sender, EventArgs e)
        {

        }
        protected void btnR1_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}