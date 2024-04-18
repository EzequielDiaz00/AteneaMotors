using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class Master3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("login.aspx");
            }

            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {

                    string nombreUsuario = ObtenerNombre((string)Session["usuario"]);

                    Session["NombreUsuario"] = nombreUsuario;
                }
            }
        }
        string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
        private string ObtenerNombre(string usuario)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT usuario FROM DatosdeRegistrados WHERE usuario = @usuario;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", HttpContext.Current.Session["usuario"]);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader["usuario"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {

                    return null;
                }
            }

        }


        protected void cerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("ConnectionString");
            Session.Remove("usuario");
            Response.Redirect("default.aspx");
        }
    }
}