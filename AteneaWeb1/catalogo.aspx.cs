using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatosAutos();
            }
        }

        private void CargarDatosAutos()
        {
            // Aquí es donde recuperarías los datos de la base de datos
            List<Autos1> autos = ObtenerAutosDesdeBaseDeDatos();

            // Enlaza los datos al GridView
            gridAutos.DataSource = autos;
            gridAutos.DataBind();
        }

        private List<Autos1> ObtenerAutosDesdeBaseDeDatos()
        {
            // Aquí es donde escribirías el código para obtener los datos de la base de datos
            // Puedes usar ADO.NET, Entity Framework u otro ORM
            // Por ejemplo:
            List<Autos1> autos = new List<Autos1>();
            // Lógica para obtener los datos de la base de datos y llenar la lista de autos
            return autos;
        }
    }
}