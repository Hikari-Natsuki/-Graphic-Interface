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

namespace NominaDonChucho.ControlesUsuarios
{
    public partial class UC_Nomina : UserControl
    {
        public UC_Nomina()
        {
            InitializeComponent();
        }
        // Metodo para mostrar los datos en el DataGridView

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int identificacio = int.Parse(txtIdentificacion.Text);

            // Buscar la ifentificacion dentro del list
            var emp = Datos.listaEmpleados.FirstOrDefault(x => x.Identificacion == identificacio);

            if (emp != null)
            {
                lblNombres.Text = emp.Nombres;
                lblApellidos.Text = emp.Apellidos;
                lblSalario.Text = emp.Salario_base.ToString();
                lblGenero.Text = emp.Genero;

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
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salud = double.Parse(lblSalario.Text);
            double pension = double.Parse(lblSalario.Text);
            double transporte = double.Parse(lblSalario.Text) < 34000000 ? 250000 : 0;
            double total = double.Parse(lblSalario.Text) - (salud + pension) + transporte;

            lblSalud.Text = salud.ToString("C");
            lblPension.Text = pension.ToString("C");
            lblTransporte.Text = transporte.ToString("C");
            lblPaga.Text = total.ToString("C");
        }
    }
}
