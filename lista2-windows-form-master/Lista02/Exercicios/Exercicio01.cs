using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void Algoritimo()
        {
            int numero = 0;

            try
            {
                numero = Convert.ToInt32(txtNumero.Text);                
            }
            catch
            {
                MessageBox.Show("Parece que você não colocou um número. Tente novamente!");
                txtNumero.Focus();
                return;
            }

            if (numero == 0)
            {
                txtResultado.Text = "Não é Positivo.";
            }
            else if (numero > 0)
            {
                txtResultado.Text = "Positivo.";
            }
            else
            {
                txtResultado.Text = "Não é Positivo.";
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            Algoritimo();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnConferir.PerformClick();
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }
    }
}
