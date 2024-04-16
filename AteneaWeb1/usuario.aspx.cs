using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class usuario : System.Web.UI.Page
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
                    
                    string nombreUsuario = ObtenerNombreUsuarioDesdeLaBaseDeDatos((string)Session["usuario"]);

                    Session["NombreUsuario"] = nombreUsuario;
                }
            }
        }
        string connectionString = ConfigurationManager.ConnectionStrings["connectionDB2"].ConnectionString;

        private string ObtenerNombreUsuarioDesdeLaBaseDeDatos(string usuario)
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


    }
}