using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class proveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProv();
            }
        }

        protected void AdProvB_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "INSERT INTO Proveedores (Nombre, Descripcion, Marca, Direccion, Telefono, Tipo) VALUES (@Nombre, @Descripcion, @Marca, @Direccion, @Telefono, @Tipo)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", AdProv1.Text);
                    command.Parameters.AddWithValue("@Descripcion", AdProv2.Text);
                    command.Parameters.AddWithValue("@Marca", AdProv3.Text);
                    command.Parameters.AddWithValue("@Direccion", AdProv4.Text);
                    command.Parameters.AddWithValue("@Telefono", AdProv5.Text);
                    command.Parameters.AddWithValue("@Tipo", AdProv6.Text);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Response.Write("<script>alert('Producto agregado correctamente');</script>");

                            AdProv1.Text = "";
                            AdProv2.Text = "";
                            AdProv3.Text = "";
                            AdProv4.Text = "";
                            AdProv5.Text = "";
                            AdProv6.Text = "";

                            CargarProv();
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

        private void CargarProv()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "SELECT ID, Nombre, Descripcion, Marca, Direccion, Telefono, Tipo FROM Proveedores";

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
                    rptProv.DataSource = dataTable;
                    rptProv.DataBind();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante la obtención de datos
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        protected void EliminarProv_Click(object sender, EventArgs e)
        {
            string ID = ((Button)sender).CommandArgument;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            string query = "DELETE FROM Proveedores WHERE ID = @ID";

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
                            CargarProv();
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error al eliminar el proveedor: " + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
}