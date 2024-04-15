using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class admon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Proveedores_Click(object sender, EventArgs e)
        {
            Response.Redirect("proveedores.aspx");
        }

        protected void Ingresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresarP.aspx");
        }

        protected void RevisarCot_Click(object sender, EventArgs e)
        {
            Response.Redirect("cotizaciones.aspx");
        }
    }
}