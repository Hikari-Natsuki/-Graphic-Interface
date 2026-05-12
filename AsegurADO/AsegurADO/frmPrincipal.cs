using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsegurADO.Control_usuarios;

namespace AsegurADO
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirControl(UserControl userControl)
        {
            pnlContenedor.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(userControl);
        }
        private void btnSeguros_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Seguros());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Clientes());
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Poliza());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Pago());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
