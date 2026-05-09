using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiPlus.ControlesUsuarios;

namespace ServiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AbrirControl(UserControl userControl)
        {
            pnlContenedor.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(userControl);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Clientes());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Servicios());
        }

        private void btnAdquisiciones_Click(object sender, EventArgs e)
        {
            AbrirControl(new UC_Adquisiciones());
        }
    }
}
