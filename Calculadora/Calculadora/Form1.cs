using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Clases;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        CalculadoraClase operacion = new CalculadoraClase();
        double num1, num2;
        private void btnSumar_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text);
            lblResultado.Text = operacion.Sumar(num1, num2).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text);
            lblResultado.Text = operacion.Restar(num1, num2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text);
            lblResultado.Text = operacion.Multiplicar(num1, num2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtNumero1.Text);
                num2 = double.Parse(txtNumero2.Text);
                lblResultado.Text = Math.Round(operacion.Dividir(num1, num2)).ToString();
            } catch (ArgumentException ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
