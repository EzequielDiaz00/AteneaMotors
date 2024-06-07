using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;

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
                    UsuarioInfo usuarioInfo = ObtenerUsuarioInfo((string)Session["usuario"]);

                    if (usuarioInfo != null)
                    {
                        Session["NombreUsuario"] = usuarioInfo.Nombre;
                        Session["IDUsuario"] = usuarioInfo.ID;
                    }
                }
            }
        }

        string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

<<<<<<< HEAD
        private UsuarioInfo ObtenerUsuarioInfo(string usuario)
=======
        private string ObtenerNombre(string usuario)
>>>>>>> b7df3a1d5cdc93048e0ca84d8c819edd2bb55370
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID, usuario FROM DatosdeRegistrados WHERE usuario = @usuario;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        UsuarioInfo usuarioInfo = new UsuarioInfo
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Nombre = reader["usuario"].ToString()
                        };
                        return usuarioInfo;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que pueda ocurrir
                    Console.WriteLine("Error al obtener información del usuario: " + ex.Message);
                    return null;
                }
            }
        }

        protected void cerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("ConnectionString");
            Session.Remove("usuario");
            Session.Remove("NombreUsuario");
            Session.Remove("IDUsuario");
            Response.Redirect("default.aspx");
        }
    }

    public class UsuarioInfo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}
