using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiPlus.Data;
using ServiPlus.Modelo;

namespace ServiPlus.ControlesUsuarios
{
    public partial class UC_Clientes : UserControl
    {
        public UC_Clientes()
        {
            InitializeComponent();
        }

        private void UC_Consultas_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtId.Clear();
            cboSede.Text = "Seleccionar sede";
        }
        // Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) 
                || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Cliente nuevoCliente = new Cliente
            {
                Id_cliente = int.Parse(txtId.Text),
                Nombre = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Sede = cboSede.SelectedItem.ToString()
            };

            Datos.lista_clientes.Add(nuevoCliente);
            MessageBox.Show("Cliente registrado exitosamente.");
            Limpiar();
        }

        // Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int identificacion = int.Parse(txtId.Text);

            var cliente = Datos.lista_clientes.FirstOrDefault(x => x.Id_cliente == identificacion);

            if(cliente != null)
            {
                txtNombres.Text = cliente.Nombre;
                txtApellidos.Text = cliente.Apellidos;
                txtCorreo.Text = cliente.Correo;
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
                cboSede.SelectedItem = cliente.Sede;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }
        // Listar
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cboSede.SelectedItem == null || cboSede.Text == "Todas")
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = Datos.lista_clientes;
            }
            else
            {
                string sede = cboSede.SelectedItem.ToString();

                var lista = Datos.lista_clientes
                    .Where(x => x.Sede == sede)
                    .ToList();

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = lista;
            }
        }
        // Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cliente = Datos.lista_clientes.FirstOrDefault(x => x.Id_cliente == int.Parse(txtId.Text));
            if (cliente != null)
            {
                cliente.Id_cliente = int.Parse(txtId.Text);
                cliente.Nombre = txtNombres.Text;
                cliente.Apellidos = txtApellidos.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Sede = cboSede.SelectedItem.ToString();
                MessageBox.Show("Cliente actualizado exitosamente.");
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
            Limpiar();
        }

        // Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificacion = int.Parse(txtId.Text);

            var cliente = Datos.lista_clientes.FirstOrDefault(x => x.Id_cliente == identificacion);

            if(cliente != null)
            {
                Datos.lista_clientes.Remove(cliente);
                MessageBox.Show("Cliente eliminado exitosamente.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
            Limpiar();
        }
    }
}
