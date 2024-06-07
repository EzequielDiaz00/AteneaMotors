using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class vistaAuto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Puedes agregar aquí la lógica necesaria al cargar la página, si es necesario.
        }

        protected void btnEnviarReseña_Click(object sender, EventArgs e)
        {
            // Obtener el ID del automóvil desde la URL
            int idAutomovil = ObtenerIdAutomovilDesdeURL();

            // Obtener la reseña y calificación del formulario
            string reseña = txtReseña.Text;
            int calificación = Convert.ToInt32(ddlCalificación.SelectedValue);

            // Guardar la reseña en la base de datos
            GuardarReseñaEnBD(idAutomovil, reseña, calificación);

            // Recargar la página para mostrar la reseña agregada
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        private int ObtenerIdAutomovilDesdeURL()
        {
            string idAutomovilStr = Request.QueryString["idAuto"];

            int idAutomovil = 0;
            if (!string.IsNullOrEmpty(idAutomovilStr) && int.TryParse(idAutomovilStr, out idAutomovil))
            {
                return idAutomovil;
            }
            else
            {
                throw new Exception("No se pudo obtener el ID del automóvil desde la URL.");
            }
        }

        private void GuardarReseñaEnBD(int idAutomovil, string reseña, int calificación)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

            string query = "INSERT INTO Reviews (UserID, CarID, Rating, ReviewText, Fecha) VALUES (@UserID, @CarID, @Rating, @ReviewText, @Fecha)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", ObtenerIdUsuarioActual());
                command.Parameters.AddWithValue("@CarID", idAutomovil);
                command.Parameters.AddWithValue("@Rating", calificación);
                command.Parameters.AddWithValue("@ReviewText", reseña);
                command.Parameters.AddWithValue("@Fecha", DateTime.Now);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    Response.Redirect("catalogoUsuario.aspx");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private int ObtenerIdUsuarioActual()
        {
            // Aquí debes implementar el código para obtener el ID del usuario actual
            // Puedes obtenerlo de la sesión, del usuario autenticado, etc.
            // Por ejemplo:
            return int.Parse(Session["IDUsuario"].ToString());
            // Este es solo un valor de ejemplo, debes reemplazarlo con el código real
        }
    }
}