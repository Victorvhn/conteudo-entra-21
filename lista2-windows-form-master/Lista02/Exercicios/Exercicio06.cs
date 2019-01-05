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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        int numero = 0;
        string diferente1 = "";

        private void PegarInformacoesEVerificar()
        {
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Por favor, informe um número válido.");
                txtNumero.Focus();
                return;
            }


            // diferente 1
            if (numero == 1)
            {
                txtInformacoes.Text = String.Format("O número é igual a 1.");
            }
            else if (numero != 1)
            {
               txtInformacoes.Text = String.Format("O número é diferente de 1.");
            }

        }
        private void btnConferir_Click(object sender, EventArgs e)
        {
            PegarInformacoesEVerificar();
        }

        private void lblIntroducao_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}