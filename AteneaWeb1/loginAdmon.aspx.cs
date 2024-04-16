using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AteneaWeb1
{
    public partial class loginAdmon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnL1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            string usuario = txtL1.Text.Trim();
            string contrasena = txtL2.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM UsuarioAdmin WHERE usuario = @usuario AND contrasena = @contrasena";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                try
                {
                    connection.Open();
                    int rowsAffected = (int)command.ExecuteScalar();

                    if (rowsAffected > 0)
                    {
                        Session["ConnectionString"] = connectionString;
                        Session["usuario"] = usuario;

                        Response.Write("<script>alert('Sesion iniciada');</script>");
                        Response.Redirect("admon.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo iniciar sesion');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }
        }
    }
}