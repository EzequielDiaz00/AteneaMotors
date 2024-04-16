using System;
using System.Collections.Generic;
using System.Configuration;
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
            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("loginAdmon.aspx");
            }
            else
            {
                string connectionString = Session["ConnectionString"].ToString();
                string usuario = Session["usuario"].ToString();
            }
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

        protected void cerrarSS_Click(object sender, EventArgs e)
        {
            Session.Remove("ConnectionString");
            Session.Remove("usuario");
            Response.Redirect("loginAdmon.aspx");
        }
    }
}