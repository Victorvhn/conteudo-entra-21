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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        int numero = 0;
        string resultado = "";

        private void PegarInformacoesEVerificar()
        {
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNumero.Focus();
                return;
            }

            if (numero == 0)
            {
                resultado = "neutro";
            }
            else if (numero % 2 == 0)
            {
                resultado = "par";
            }
            else // (numero % 2 != 0)
            {
                resultado = "não é par";
            }

            if ((resultado == "par") || (resultado == "neutro"))
            {
                txtResultado.Text = String.Format("O número {0} é {1}.", numero, resultado);
            }
            else
            {
                txtResultado.Text = String.Format("O número {0} {1}", numero, resultado);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            PegarInformacoesEVerificar();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PegarInformacoesEVerificar();
                btnVerificar.PerformClick();
            }
        }
    }
}
