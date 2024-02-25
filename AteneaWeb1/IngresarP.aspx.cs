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
    public partial class IngresarP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["NombreDeTuCadenaDeConexion"].ConnectionString;
            string query = "INSERT INTO Productos (Nombre, Descripcion, Anio, Color, ImagenUrl, Tipo) VALUES (@Nombre, @Descripcion, @Anio, @Color, @ImagenUrl, @Tipo)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                command.Parameters.AddWithValue("@Anio", txtAnio.Text);
                command.Parameters.AddWithValue("@Color", txtColor.Text);
                command.Parameters.AddWithValue("@ImagenUrl", txtImagenUrl.Text);
                command.Parameters.AddWithValue("@Tipo", txtTipo.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    // mostrar un mensaje de éxito o redirigir a otra página
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}