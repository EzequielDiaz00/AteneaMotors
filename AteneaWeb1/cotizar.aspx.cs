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

            if (IsValidEmail(correo))
            {
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
                        if (rowsAffected > 0)
                        {
                            txtNombre.Text = "";
                            txtApellido.Text = "";
                            txtEmail.Text = "";
                            txtTelefono.Text = "";
                            Response.Write("<script>alert('Cotizacion enviada');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Error al enviar datos');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error: ');</script>" + ex.Message);
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Ingrese un correo valido');</script>");
            }
        }
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
