using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AteneaWeb1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnL1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Verificar si el usuario y la contraseña existen en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM DatosdeRegistrados WHERE usuario = @usuario AND contraseña = @contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                try
                {
                    connection.Open();
                    int rowsAffected = (int)command.ExecuteScalar();

                    // Verificar si se encontró una coincidencia
                    if (rowsAffected > 0)
                    {
                        // Inicio de sesión exitoso, redirigir al usuario
                        Response.Redirect("default.aspx");
                    }
                    else
                    {
                        // Los datos no existen, mostrar una notificación
                        successMessage.Style["display"] = "block";
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción
                    Response.Write("Error: " + ex.Message);
                }
            }
        }




        protected void btnR1_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}