using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AteneaWeb1
{
    public partial class cotizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtEmail.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            // Verificar si el correo tiene un formato válido
            if (IsValidEmail(correo))
            {
                // El correo es válido, puedes proceder con la inserción en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO DatosUsuario (Nombre, Apellido, Correo, Telefono) VALUES (@Nombre, @Apellido, @Correo, @Telefono)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        // Verificar si se insertó correctamente
                        if (rowsAffected > 0)
                        {
                            // Éxito
                            txtNombre.Text = "";
                            txtApellido.Text = "";
                            txtEmail.Text = "";
                            txtTelefono.Text = "";
                            Response.Write("Datos insertados correctamente.");
                        }
                        else
                        {
                            // Error
                            Response.Write("No se pudo insertar los datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                // El correo no es válido, mostrar mensaje de error
                Response.Write("Correo inválido: Debe ser un correo electrónico válido.");
            }
        }

        // Método para validar el formato del correo electrónico
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }
    }
}
