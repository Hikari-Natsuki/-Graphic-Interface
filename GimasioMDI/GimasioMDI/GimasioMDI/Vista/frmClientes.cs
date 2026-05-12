using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GimasioMDI.Controlador;
using GimasioMDI.Repositorio;

namespace GimasioMDI
{
    public partial class frmClientes : Form
    {
        private ClienteController cliCont = new ClienteController();
        public frmClientes()
        {
            InitializeComponent();
            dgvClientes.DataSource = cliCont.ListarClientes();
        }
        


        private void LimpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtFiltro.Clear();
        }

        // Metodo para cargar el grafico 
        private void CargarGrafico()
        {
            DataTable dt = cliCont.EstadisticaCliente();
            // Limbiar las series
            chtEstadistica.Series.Clear();
            // Crear una serie 
            chtEstadistica.Series.Add("Edad");
            var serie = chtEstadistica.Series["Edad"];

            // Indicar el tipo de grafico 
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Indicar loes miebros del eje X y del eje Y 
            serie.XValueMember = "Nombre";
            serie.YValueMembers = "Edad";

            // Agregar titulo al grafico 
            chtEstadistica.Titles.Clear();
            chtEstadistica.Titles.Add("Clientes por Edad");

            //Cambia la fuente 
            chtEstadistica.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
            chtEstadistica.Titles[0].ForeColor = Color.DarkBlue;
            chtEstadistica.Titles[0].Alignment = ContentAlignment.TopCenter;

            //Cambiar la fuente del titulo del eje x
            chtEstadistica.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            //Rotar lAS LEYENDADs del eje x 
            chtEstadistica.ChartAreas[0].AxisX.LabelStyle.Angle = -90;

            chtEstadistica.DataSource = dt;
            foreach (DataRow row in dt.Rows)
                chtEstadistica.DataBind();
        } 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEdad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Cliente cliente = new Cliente
            {
                Identificacion = int.Parse(txtIdentificacion.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            cliCont.InsertarCliente(cliente);
            // Actualizar el DataGridView después de insertar un nuevo cliente
            dgvClientes.DataSource = cliCont.ListarClientes();

            // Limpiar
            LimpiarCampos();

            // Botones
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdentificacion.Text);
            var cliente = cliCont.BuscarCliente(id);
            if(cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEdad.Text = cliente.Edad.ToString();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }

            // Botones
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Identificacion = int.Parse(txtIdentificacion.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            cliCont.ActualizarCliente(cliente);

            // Actualizar el DataGridView después de actualizar un cliente
            dgvClientes.DataSource = cliCont.ListarClientes();

            // Limpiar
            LimpiarCampos();

            // Botones
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdentificacion.Text);
            DialogResult resultado = MessageBox.Show("¿Desea eliminar al cliente?", "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (resultado == DialogResult.No) return;
            else
            {
                
                cliCont.EliminarCliente(id);
            }
                

            // Actualizar el DataGridView después de eliminar un cliente
            dgvClientes.DataSource = cliCont.ListarClientes();

            // Limpiar
            LimpiarCampos();

            // Botones
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = true;
        }
        private void btnGrafico_Click(object sender, EventArgs e)
        {
            CargarGrafico();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        int id = 0, edad = 0;
        string nombre = "", apellido = "";

        // Evento para cargar los datos del cliente seleccionado en el DataGridView a los campos de texto
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIdentificacion.Text = id.ToString();

            nombre = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNombre.Text = nombre;

            apellido = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtApellido.Text = apellido;

            edad = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtEdad.Text = edad.ToString();

            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = true;
        }
        // Filtro
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            var clientes = cliCont.FiltrarCliente(txtFiltro.Text);
            dgvClientes.DataSource = clientes;
        }

        // FUNCIONES ADICIONALES -----------------------------------------------------------------------------
        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Habilitar tecla enter
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtIdentificacion.Focus(); // Mantener el foco en el campo de identificación
                txtIdentificacion.BackColor = Color.LightGreen; // Cambiar el fondo a verde claro para indicar que se ha realizado la búsqueda
                e.Handled = true; // Evitar que el sonido de error se reproduzca
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Habilitar tecla enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNombre.Focus(); 
                txtNombre.BackColor = Color.LightGreen; 
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtApellido.Focus();
                txtApellido.BackColor = Color.LightGreen;
                e.Handled = true;
            }
        }

        

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEdad.Focus();
                txtEdad.BackColor = Color.LightGreen;
                e.Handled = true;
            }
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.Aquamarine; 
        }

        
    }
}
