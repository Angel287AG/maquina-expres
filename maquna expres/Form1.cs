using pryMaquinaExpendedora;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace maquina_expres
{
    public partial class Form1 : Form
    {
        List<Producto> catalogo = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
            catalogo.Add(new Producto("Coca Cola", 20, 10));
            catalogo.Add(new Producto("Sabritas", 18, 15));
            catalogo.Add(new Producto("Chocolate", 12, 20));
            catalogo.Add(new Producto("Agua", 15, 8));

            cmbProductos.DataSource = catalogo;


        }

        private void CargarProductos()
        {
            catalogo.Add(new Producto("Coca Cola", 20, 10));
            catalogo.Add(new Producto("Sabritas", 18, 15));
            catalogo.Add(new Producto("Chocolate", 12, 20));
            catalogo.Add(new Producto("Agua", 15, 8));

            cmbProductos.DataSource = catalogo;
            cmbProductos.DisplayMember = "nombre";


            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstProductos.Items.Clear();

            foreach (Producto Producto in catalogo)
            {
                lstProductos.Items.Add(
                    Producto.nombre + " $" +
                    Producto.precio + " Stock: " +
                    Producto.inventario);
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            Producto Producto = (Producto)cmbProductos.SelectedItem;

            int cantidad = (int)nudCantidad.Value;

            float total;

            if (Producto.ProcesarCompra(cantidad, out total))
            {
                MessageBox.Show(
                    "Compra exitosa\nTotal: $" + total,
                    "Compra",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

             
                ActualizarLista();
            }
            else
            {
                MessageBox.Show(
                    "Stock insuficiente",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ActualizarEtiquetas()
        {
            Producto productoSeleccionado =
                (Producto)cmbProductos.SelectedItem;

            if (productoSeleccionado != null)
            {
                lblPrecio.Text =
                    "PRECIO: $" + productoSeleccionado.precio;

                lblInventario.Text =
                    "INVENTARIO: " + productoSeleccionado.inventario;
            }
        }





        private void cmbProductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblInventario_Click(object sender, EventArgs e)
        {

        }
    }
}