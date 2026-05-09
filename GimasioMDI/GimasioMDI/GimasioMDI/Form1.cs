using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimasioMDI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void msiSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msiClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void msiServicios_Click(object sender, EventArgs e)
        {
            frmServicio servicio = new frmServicio();
            servicio.MdiParent = this;
            servicio.Show();
        }

        private void tsbClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void tsbServicios_Click(object sender, EventArgs e)
        {
            frmServicio servicio = new frmServicio();
            servicio.MdiParent = this;
            servicio.Show();
        }
    }
}
