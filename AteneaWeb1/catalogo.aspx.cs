﻿using System;
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
    public partial class catalogo : System.Web.UI.Page
    {
        // Lista de productos
        List<Producto> productos = new List<Producto>
        {
            /*new Producto { Nombre = "Nissan Rogue", Descripcion = "Rogue", Anio = "2024", Color = "Gris", ImagenUrl = "img2/nr1.jpg", Tipo = "Camioneta"},
            new Producto { Nombre = "Ford Ranger", Descripcion = "Ranger", Anio = "2023", Color = "Rojo", ImagenUrl = "img2/fr1.jpg", Tipo = "PickUp"},
            new Producto { Nombre = "Toyota Corolla", Descripcion = "Corolla", Anio = "2022", Color = "Blanco", ImagenUrl = "img2/tc1.jpg", Tipo = "Sedan"},
            new Producto { Nombre = "Toyota Hiace", Descripcion = "Hiace", Anio = "2021", Color = "Gris", ImagenUrl = "img2/th1.jpg", Tipo = "Microbus"}*/
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
            //Codido para lista de productos.
            //rptProductos.DataSource = productos;
            //rptProductos.DataBind();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AteneaMotors;Integrated Security=True";
            string query = "SELECT Nombre, Descripcion, Anio, Color, ImagenUrl, Tipo FROM Autos";

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
                    rptProductos.DataSource = dataTable;
                    rptProductos.DataBind();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante la obtención de datos
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string tipo = rbTipo.SelectedValue;
            string color = rbColor.SelectedValue;
            string anio = rbAnio.SelectedValue;

            List<Producto> productosFiltrados = FiltrarProductosBD(tipo, color, anio);

            rptProductos.DataSource = productosFiltrados;
            rptProductos.DataBind();
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            // Aquí manejas el evento de clic del botón de reset
            // Reseteas las selecciones de los RadioButtonList
            rbTipo.SelectedIndex = -1;
            rbColor.SelectedIndex = -1;
            rbAnio.SelectedIndex = -1;

            // Luego vuelves a cargar todos los productos sin filtros
            CargarProductos();
        }

        private List<Producto> FiltrarProductosLL(string tipo, string color, string anio)
        {
            List<Producto> productosFiltrados = new List<Producto>();

            foreach (var producto in productos)
            {
                bool tipoCoincide = string.IsNullOrEmpty(tipo) || producto.Tipo == tipo;
                bool colorCoincide = string.IsNullOrEmpty(color) || producto.Color == color;
                bool anioCoincide = string.IsNullOrEmpty(anio) || producto.Anio == anio;

                if (tipoCoincide && colorCoincide && anioCoincide)
                {
                    productosFiltrados.Add(producto);
                }
            }

            return productosFiltrados;
        }
        private List<Producto> FiltrarProductosBD(string tipo, string color, string anio)
        {
            List<Producto> productosFiltrados = new List<Producto>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AteneaMotors;Integrated Security=True";
            string query = "SELECT Nombre, Descripcion, Anio, Color, ImagenUrl, Tipo FROM Autos WHERE (@Tipo IS NULL OR Tipo = @Tipo) AND (@Color IS NULL OR Color = @Color) AND (@Anio IS NULL OR Anio = @Anio)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tipo", string.IsNullOrEmpty(tipo) ? DBNull.Value : (object)tipo);
                command.Parameters.AddWithValue("@Color", string.IsNullOrEmpty(color) ? DBNull.Value : (object)color);
                command.Parameters.AddWithValue("@Anio", string.IsNullOrEmpty(anio) ? DBNull.Value : (object)anio);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Construir la lista de productos a partir de los datos obtenidos
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Producto producto = new Producto
                        {
                            Nombre = row["Nombre"].ToString(),
                            Descripcion = row["Descripcion"].ToString(),
                            Anio = row["Anio"].ToString(),
                            Color = row["Color"].ToString(),
                            ImagenUrl = row["ImagenUrl"].ToString(),
                            Tipo = row["Tipo"].ToString()
                        };

                        productosFiltrados.Add(producto);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante la obtención de datos
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Devolver la lista de productos filtrados
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
