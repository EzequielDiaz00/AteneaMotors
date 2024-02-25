using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AteneaWeb1
{
    public partial class IngresarP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AteneaMotors;Integrated Security=True";

            string query = "INSERT INTO Autos (Nombre, Descripcion, Anio, Color, ImagenUrl, Tipo) VALUES (@Nombre, @Descripcion, @Anio, @Color, @ImagenUrl, @Tipo)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

                        if (rowsAffected > 0)
                        {
                            Response.Write("<script>alert('Producto agregado correctamente');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('No se pudo agregar el producto');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
}
