using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteneaWeb1
{
    public partial class IngresarProducto : System.Web.UI.Page
    {
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para guardar el producto en una base de datos
            // Por simplicidad, en este ejemplo, solo imprimimos los detalles del producto
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string anio = txtAnio.Text;
            string color = txtColor.Text;
            string imagenUrl = txtImagen.Text;

            // Lógica para guardar el producto en la base de datos o en algún otro lugar
            // (no se muestra en este ejemplo)
            Response.Write($"Producto agregado: {nombre}, {descripcion}, {anio}, {color}, {imagenUrl}");
        }
    }
}