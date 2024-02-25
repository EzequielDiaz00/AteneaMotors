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
        // Lista de productos
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Nissan Rogue", Descripcion = "Rogue", Anio = "2024", Color = "Gris", ImagenUrl = "img2/nr1.jpg", Tipo = "Camioneta"},
            new Producto { Nombre = "Ford Ranger", Descripcion = "Ranger", Anio = "2023", Color = "Rojo", ImagenUrl = "img2/fr1.jpg", Tipo = "PickUp"},
            new Producto { Nombre = "Toyota Corolla", Descripcion = "Corolla", Anio = "2022", Color = "Blanco", ImagenUrl = "img2/tc1.jpg", Tipo = "Sedan"},
            new Producto { Nombre = "Toyota Hiace", Descripcion = "Hiace", Anio = "2021", Color = "Gris", ImagenUrl = "img2/th1.jpg", Tipo = "Microbus"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            rptProductos.DataSource = productos;
            rptProductos.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string tipo = rbTipo.SelectedValue;
            string color = rbColor.SelectedValue;
            string anio = rbAnio.SelectedValue;

            List<Producto> productosFiltrados = FiltrarProductos(tipo, color, anio);

            rptProductos.DataSource = productosFiltrados;
            rptProductos.DataBind();
        }

        private List<Producto> FiltrarProductos(string tipo, string color, string anio)
        {
            List<Producto> productosFiltrados = new List<Producto>();

            foreach (var producto in productos)
            {
                bool tipoCoincide = string.IsNullOrEmpty(tipo) || producto.Tipo == tipo;
                bool colorCoincide = string.IsNullOrEmpty(color) || producto.Color == color;
                bool anioCoincide = string.IsNullOrEmpty(anio) || producto.Anio == anio;

                // Si todos los criterios coinciden, agregar el producto a la lista de productos filtrados
                if (tipoCoincide && colorCoincide && anioCoincide)
                {
                    productosFiltrados.Add(producto);
                }
            }

            return productosFiltrados;
        }

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
