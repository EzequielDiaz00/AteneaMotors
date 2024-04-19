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
    public partial class pruebaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calFechaP_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaP.Text = calFechaP.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtEmail.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string auto = txtAuto.Text.Trim();
            string fechaP = txtFechaP.Text;

            if (IsValidEmail(correo))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO PruebaManejo (Nombre, Apellido, Correo, Telefono, Auto, Fecha) VALUES (@Nombre, @Apellido, @Correo, @Telefono, @Auto, @Fecha)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Auto", auto);
                    command.Parameters.AddWithValue("@Fecha", fechaP);

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
                            txtAuto.Text = "";
                            txtFechaP.Text = "";
                            Response.Write("<script>alert('Prueba de manejo solicitada');</script>");
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