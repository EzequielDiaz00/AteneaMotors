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
    public partial class register : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnL1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void btnR1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string usuario = txtUsuario.Text.Trim();
            string correo = txtEmail.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string confirmarContraseña = txtConfirContraseña.Text.Trim();

            // Verificar si el correo tiene un formato válido
            if (IsValidEmail(correo))
            {
                // Verificar si el nombre de usuario ya existe en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM DatosdeRegistrados WHERE usuario = @usuario";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);

                    try
                    {
                        connection.Open();
                        int rowsAffected = (int)command.ExecuteScalar();

                        // Verificar si se encontró una coincidencia
                        if (rowsAffected > 0)
                        {
                            // El nombre de usuario ya existe, mostrar un mensaje de error
                            errorLabel.Text = "El nombre de usuario ya está en uso.";
                            errorLabel.Visible = true;
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción
                        Response.Write("Error: " + ex.Message);
                    }
                }
                // Verificar que la contraseña y la confirmación de contraseña coincidan
                if (contraseña != confirmarContraseña)
                {
                    // La contraseña y la confirmación de contraseña no coinciden, mostrar un mensaje de error
                    errorLabel.Text = "La confirmación de contraseña es incorrecta.";
                    errorLabel.Visible = true;
                    return;
                }

                // El correo es válido, puedes proceder con la inserción en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO DatosdeRegistrados (usuario, correo, contraseña) VALUES (@usuario, @correo, @contraseña)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        // Verificar si se insertó correctamente
                        if (rowsAffected > 0)
                        {
                            // Éxito
                            txtUsuario.Text = "";
                            txtEmail.Text = "";
                            txtContraseña.Text = "";
                            successMessage.Attributes.Add("style", "display:block;");
                            Response.AddHeader("REFRESH", "5;URL=login.aspx");
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
                errorLabel.Text = "Correo inválido: Debe ser un correo electrónico válido.";
                errorLabel.Visible = true;
                return;
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