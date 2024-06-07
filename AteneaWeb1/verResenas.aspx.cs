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
    public partial class verResenas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarResenas();
            }

            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("loginAdmon.aspx");
            }
        }

        private void CargarResenas()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "SELECT UserID, CarID, Rating, ReviewText, Fecha FROM Reviews";

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
                    rptResenas.DataSource = dataTable;
                    rptResenas.DataBind();
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