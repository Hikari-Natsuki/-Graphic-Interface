using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadenaDonChucho.Modelo;
using CadenaDonChucho.Servicio;

namespace CadenaDonChucho
{
    public partial class frmRegistrarProducto : Form
    {
        public frmRegistrarProducto()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }
        static ProductoService servicio = new ProductoService();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int codigo;
            double precio;
            int cantidad;

            if (txtCodigo.Text.Trim() == ""  || txtNombre.Text.Trim() == "" ||
                txtPrecio.Text.Trim() == ""  || txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Error: hay campos vacíos o con espacios en blanco");
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Error: el código debe ser un número");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Error: el precio debe ser un número");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Error: la cantidad debe ser un número entero");
                return;
            }

            Producto existe = servicio.buscar_producto(codigo);

            if (existe != null)
            {
                MessageBox.Show("Error: ya existe un producto con ese código");
                return;
            }

            Producto nuevo = new Producto();
            nuevo.codigo = codigo;
            nuevo.nombre = txtNombre.Text;
            nuevo.precio = precio;
            nuevo.cantidad_disponible = cantidad;

            servicio.registrar_producto(nuevo);

            MessageBox.Show("Producto registrado correctamente");
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            Producto p = servicio.buscar_producto(codigo);

            if (p != null)
            {
                txtNombre.Text = p.nombre;
                txtPrecio.Text = p.precio.ToString();
                txtCantidad.Text = p.cantidad_disponible.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int codigo;
            double precio;
            int cantidad;

            if (txtCodigo.Text.Trim() == "" || txtNombre.Text.Trim() == ""  
                || txtPrecio.Text.Trim() == "" || txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Error: hay campos vacíos o con espacios en blanco");
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Error: el código debe ser un número");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Error: el precio debe ser un número");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Error: la cantidad debe ser un número entero");
                return;
            }

            Producto encontrado = servicio.buscar_producto(codigo);

            if (encontrado == null)
            {
                MessageBox.Show("Error: el producto no existe");
                return;
            }

            encontrado.nombre = txtNombre.Text;
            encontrado.precio = precio;
            encontrado.cantidad_disponible = cantidad;

            MessageBox.Show("Producto actualizado correctamente");
            Limpiar();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
