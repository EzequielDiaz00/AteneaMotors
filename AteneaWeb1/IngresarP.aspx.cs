using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class IngresarP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarAutos();
            }

            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("loginAdmon.aspx");
            }
        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

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

                            txtNombre.Text = "";
                            txtDescripcion.Text = "";
                            txtAnio.Text = "";
                            txtColor.Text = "";
                            txtImagenUrl.Text = "";
                            txtTipo.Text = "";

                            CargarAutos();
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

        private void CargarAutos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "SELECT ID, Nombre, Descripcion, Anio, Color, ImagenUrl, Tipo FROM Autos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Vincular los resultados al Repeater
                    rptAuto.DataSource = dataTable;
                    rptAuto.DataBind();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante la obtención de datos
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        protected void EliminarAuto_Click(object sender, EventArgs e)
        {
            string ID = ((Button)sender).CommandArgument;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            string query = "DELETE FROM Autos WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Si la eliminación fue exitosa, recargar la lista de autos
                            CargarAutos();
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error al eliminar el auto: " + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
}
