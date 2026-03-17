namespace Escuela
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarEst_Click(object sender, EventArgs e)
        {
            // Instanciar un objeto del formulario a invocar
            frmRegistroEstudiantes frm = new frmRegistroEstudiantes();
            // Mostrar el formulario del registro
            frm.Show();
            // Esconder ESTE form
            this.Hide();
        }
    }
}
