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
    public partial class cotizaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarCot();
            }

            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("loginAdmon.aspx");
            }
            else
            {
                string connectionString = Session["ConnectionString"].ToString();
                string usuario = Session["usuario"].ToString();
            }
        }

        private void CargarCot()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "SELECT Nombre, Apellido, Correo, Telefono FROM DatosUsuario";

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
                    rptCot.DataSource = dataTable;
                    rptCot.DataBind();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante la obtención de datos
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string Correo = ((Button)sender).CommandArgument;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            string query = "DELETE FROM DatosUsuario WHERE Correo = @Correo";

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
                            CargarCot();
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error al eliminar la cotizacion: " + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
}