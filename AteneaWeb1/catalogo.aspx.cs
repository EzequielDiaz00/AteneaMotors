using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AteneaWeb1
{
    public partial class catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Ejemplo de carga de datos de productos
                CargarProductos();
            }
        }

        private void CargarProductos()
        {

            List<Producto> productos = new List<Producto>
            {
                new Producto { Nombre = "Nissan Rogue", Descripcion = "Rogue", Anio = "2024", Color = "Gris", ImagenUrl = "img2/nr1.jpg", Tipo = "Camioneta"},
                new Producto { Nombre = "Ford Ranger", Descripcion = "Ranger", Anio = "2023", Color = "Rojo", ImagenUrl = "img2/fr1.jpg", Tipo = "PickUp"},
                new Producto { Nombre = "Toyota Corolla", Descripcion = "Corolla", Anio = "2022", Color = "Blanco", ImagenUrl = "img2/tc1.jpg", Tipo = "Sedan"},
                new Producto { Nombre = "Toyota Hiace", Descripcion = "Hiace", Anio = "2021", Color = "Gris", ImagenUrl = "img2/th1.jpg", Tipo = "Microbus"}
            };

            rptProductos.DataSource = productos;
            rptProductos.DataBind();
        }

        // Clase de ejemplo para representar un producto
        public class Producto
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Anio { get; set; }
            public string Color { get; set; }
            public string ImagenUrl { get; set; }
            public string Tipo { get; set; }
        }
    }
}