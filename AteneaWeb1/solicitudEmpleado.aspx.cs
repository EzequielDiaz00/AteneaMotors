using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;

namespace AteneaWeb1
{
    public partial class solicitudEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string nombre = txtNombre.Text.Trim();
            string correo = txtEmail.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string experiencia = txtExperiencia.Text.Trim();

            // Verificar si el correo tiene un formato válido
            if (IsValidEmail(correo))
            {
                // El correo es válido, puedes proceder con la inserción en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO SolicitudEmpleado (Nombre, Correo, Telefono, Direccion, Experiencia) VALUES (@Nombre, @Correo, @Telefono, @Direccion, @Experiencia)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Experiencia", experiencia);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        // Verificar si se insertó correctamente
                        if (rowsAffected > 0)
                        {
                            // Éxito
                            txtNombre.Text = "";
                            txtEmail.Text = "";
                            txtTelefono.Text = "";
                            txtDireccion.Text = "";
                            txtExperiencia.Text = "";
                            Response.Write("<script>alert('La solicitud de empleo ha sido enviada exitosamente.');</script>");
                        }
                        else
                        {
                            // Error
                            Response.Write("<script>alert('No se pudo insertar los datos.');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                    }
                }
            }
            else
            {
                // El correo no es válido, mostrar mensaje de error
                Response.Write("<script>alert('Correo inválido: Debe ser un correo electrónico válido.');</script>");
            }
        }

        // Método para validar el formato del correo electrónico
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
