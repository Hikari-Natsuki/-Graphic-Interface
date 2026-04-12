using CadenaDonChucho.Modelo;
using CadenaDonChucho.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenaDonChucho
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        void Limpiar_cliente()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }
        ClienteServicio clienteServicio = new ClienteServicio(); 
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            // Crear un nuevo cliente con los datos ingresados para crear varios
            // clientes sin necesidad de cerrar el formulario
            Cliente cliente = new Cliente();
            cliente.codigo = int.Parse(txtCodigo.Text);
            cliente.nombre = txtNombre.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.direccion = txtDireccion.Text;

            //Limpiar los campos al registrar
            Limpiar_cliente();

            // Registrar al cliente
            clienteServicio.registrar_usuario(cliente);

            MessageBox.Show("Cliente registrado correctamente");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            Cliente clienteEncontrado = clienteServicio.buscar_clientes(codigo);

            if (clienteEncontrado == null)
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            txtNombre.Text = clienteEncontrado.nombre;
            txtTelefono.Text = clienteEncontrado.telefono;
            txtDireccion.Text = clienteEncontrado.direccion;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
