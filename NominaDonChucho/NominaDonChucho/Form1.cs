using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaDonChucho.ControlesUsuarios;

namespace NominaDonChucho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AbrirControl(UserControl userControl)
        {
            pnlContenedor.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(userControl);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Empleado());
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Nomina());
        }
    }
}
