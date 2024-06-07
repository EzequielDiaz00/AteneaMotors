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
    public partial class solicitudesEmpleo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarSolicitudesEmpleo();
            }

            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("loginAdmon.aspx");
            }
        }

        private void CargarSolicitudesEmpleo()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "SELECT Nombre, Correo, Telefono, Direccion, Experiencia FROM SolicitudEmpleado";

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
                    rptSolicitudes.DataSource = dataTable;
                    rptSolicitudes.DataBind();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante la obtención de datos
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}