using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class pruebasmanejo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPM();
            }

            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("loginAdmon.aspx");
            }
        }

        private void CargarPM()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "SELECT Nombre, Apellido, Correo, Telefono, Auto, Fecha FROM PruebaManejo";

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
                    rptPM.DataSource = dataTable;
                    rptPM.DataBind();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string Correo = ((Button)sender).CommandArgument;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            string query = "DELETE FROM PruebaManejo WHERE Correo = @Correo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", Correo);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            CargarPM();
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error al eliminar la prueba de manejo: " + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
}