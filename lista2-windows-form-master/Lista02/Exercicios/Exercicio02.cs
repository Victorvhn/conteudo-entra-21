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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void RealizaContaESalta()
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
                txtResultado.Text = "Não é Negativo.";
            }
            else if (numero > 0)
            {
                txtResultado.Text = "Não é Negativo.";
            }
            else
            {
                txtResultado.Text = "Negativo.";
            }
        }


        private void btnConferir_Click(object sender, EventArgs e)
        {
            RealizaContaESalta();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RealizaContaESalta();
                btnConferir.PerformClick();
            }
        }

                
    }
}
