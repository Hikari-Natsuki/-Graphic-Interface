using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaDonChucho.Data;
using NominaDonChucho.Modelo;

namespace NominaDonChucho.ControlesUsuarios
{
    public partial class UC_Empleado : UserControl
    {
        public UC_Empleado()
        {
            InitializeComponent();
        }
        // Metodo para mostrar los datos en el DataGridView

        private void MostrarDatos()
        {
            dgvEmpleados.DataSource = null; // Limpiar el DataGridView antes de asignar la nueva fuente de datos
            dgvEmpleados.DataSource = Datos.listaEmpleados;
        }
        public void Limpiar()
        {
            txtApellidos.Clear();
            txtIdentificacion.Focus();
            txtNombres.Clear();
            txtSalario.Clear();
            cboGenero.Text = "Seleccione...";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("Por favor, ingrese la identificación del empleado.",
                                "Gestión de Nómina Don Chucho", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            Empleado emp = new Empleado()
            {
                Identificacion = Convert.ToInt32(txtIdentificacion.Text),
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Salario_base = Convert.ToDouble(txtSalario.Text),
                Genero = cboGenero.Text
            };
            Datos.listaEmpleados.Add(emp);
            MessageBox.Show("Se ha guardado el empleado con éxito",
                            "Gestión de Nómina Don Chucho", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Limpiar();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int identificacio = int.Parse(txtIdentificacion.Text);

            // Buscar la ifentificacion dentro del list
            var emp = Datos.listaEmpleados.FirstOrDefault(x => x.Identificacion == identificacio);

            if(emp != null)
            {
                txtNombres.Text = emp.Nombres;
                txtApellidos.Text = emp.Apellidos;
                txtSalario.Text = emp.Salario_base.ToString();
                cboGenero.Text = emp.Genero;
            } 
            else
            {
                MessageBox.Show("El empleado no está registrado.",
                                "Gestión de Nómina Don Chucho", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int identificacio = int.Parse(txtIdentificacion.Text);

            // Buscar la ifentificacion dentro del list
            var emp = Datos.listaEmpleados.FirstOrDefault(x => x.Identificacion == identificacio);

            if (emp != null)
            {
                emp.Nombres = txtNombres.Text;
                emp.Apellidos = txtApellidos.Text;
                emp.Salario_base = double.Parse(txtSalario.Text);
                emp.Genero = cboGenero.Text;

                MessageBox.Show("Se ha actualizado al empleado.",
                                "Gestión de Nómina Don Chucho", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El empleado no está registrado.",
                                "Gestión de Nómina Don Chucho", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int identificacio = int.Parse(txtIdentificacion.Text);

            // Buscar la ifentificacion dentro del list
            var emp = Datos.listaEmpleados.FirstOrDefault(x => x.Identificacion == identificacio);

            if (emp != null)
            {
                Datos.listaEmpleados.Remove(emp);
                MessageBox.Show("Se ha eliminado al empleado.",
                                "Gestión de Nómina Don Chucho", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El empleado no está registrado.",
                                "Gestión de Nómina Don Chucho", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            Limpiar();
        }
    }
}
