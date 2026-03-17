using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmRegistroEstudiantes : Form
    {
        public frmRegistroEstudiantes()
        {
            InitializeComponent();
        }
        // Crear una colección LIST para las carreas
        List<string> listaCarrera = new List<string>() {"Ingenieria de software", "Derecho",
                                        "Contabilid", "Diseño", "Panaderia"};

        private void Limpiar()
        {
            txtNombreEst.Clear();
            txtEdadEst.Clear();
            cboCarrera.Text = "Seleccione...";
            txtNombreEst.Focus();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Instanciar el formulario menú
            frmMenu frm = new frmMenu();
            // Mostrar menú
            frm.Show();
            // Esconder este formulario
            this.Hide();
        }

        private void frmRegistroEstudiantes_Load(object sender, EventArgs e)
        {
            // Listar 
            cboCarrera.DataSource = listaCarrera;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEst.Text;
            int edad = int.Parse(txtEdadEst.Text);
            string carrera = cboCarrera.Text;

            // Invocar al formulario frmInformacion
            frmInformacion frmInfo = new frmInformacion(nombre, edad, carrera);
            frmInfo.Show();

            // Limpiar campos
            Limpiar();
        }
    }
}
