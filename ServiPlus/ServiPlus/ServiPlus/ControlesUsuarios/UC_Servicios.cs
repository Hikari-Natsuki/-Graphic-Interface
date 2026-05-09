using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiPlus.Data;
using ServiPlus.Modelo;

namespace ServiPlus.ControlesUsuarios
{
    public partial class UC_Servicios : UserControl
    {
        public UC_Servicios()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();

        }
        private void MostrarDatos()
        {
            dgvServicios.DataSource = null;
            dgvServicios.DataSource = Datos.lista_servicios;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) 
                || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Servicio nuevo_servicio = new Servicio
            {
                Id_Servicio = int.Parse(txtCodigo.Text),
                Nombre = txtNombre.Text,
                Precio = double.Parse(txtPrecio.Text)
            };

            Datos.lista_servicios.Add(nuevo_servicio);
            MessageBox.Show("Servicio registrado exitosamente.");
            Limpiar();
        }

        // Listar
        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        // Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            var servicio = Datos.lista_servicios.FirstOrDefault(s => s.Id_Servicio == codigo);

            if (servicio != null)
            {
                txtNombre.Text = servicio.Nombre;
                txtPrecio.Text = servicio.Precio.ToString();
            }
            else
            {
                MessageBox.Show("Servicio no encontrado.");
            }
        }
        // Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            var servicio = Datos.lista_servicios.FirstOrDefault(s => s.Id_Servicio == codigo);
            if (servicio != null)
            {
                servicio.Nombre = txtNombre.Text;
                servicio.Precio = double.Parse(txtPrecio.Text);
                MessageBox.Show("Servicio actualizado exitosamente.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Servicio no encontrado.");
            }
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            var servicio = Datos.lista_servicios.FirstOrDefault(s => s.Id_Servicio == codigo);

            if (servicio != null)
            {
                Datos.lista_servicios.Remove(servicio);
                MessageBox.Show("Servicio eliminado exitosamente.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Servicio no encontrado.");
            }
            Limpiar();
        }
    }
}
