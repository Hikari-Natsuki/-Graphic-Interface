using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmInformacion : Form
    {
        public string nombre;
        public int edad;
        public string carrera;
        public frmInformacion(string nombre, int edad, string carrera)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.edad = edad;
            this.carrera = carrera;
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            lblNombreEst.Text = nombre;
            lblEdadEst.Text = edad.ToString();
            lblCarrera.Text = carrera;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Instanciar form
            frmRegistroEstudiantes frm = new frmRegistroEstudiantes();
            // Mostrar info
            frm.Show();
            // Esconder este form
            this.Hide();
        }
    }
}
