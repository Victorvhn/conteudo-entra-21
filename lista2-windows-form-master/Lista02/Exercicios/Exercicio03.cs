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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        double numero01 = 0;
        double numero02 = 0;
        string resultado = "";

        private void CalcularEGuardar()
        {

            try
            {
                numero01 = Convert.ToDouble(txtNumero01.Text);
            }
            catch
            {
                MessageBox.Show("Parece que você não colocou um número. Tente novamente!");
                txtNumero01.Focus();
                return;
            }
            try
            {
                numero02 = Convert.ToDouble(txtNumero02.Text);
            }
            catch
            {
                MessageBox.Show("Parece que você não colocou um número. Tente novamente!");
                txtNumero02.Focus();
                return;
            }

            if (radSoma.Checked)
            {
                Somar();
            }
            else if (radSubtracao.Checked)
            {
                Subtrair();
            }
            else if (radMultiplicacao.Checked)
            {
                Multiplicar();
            }
            else if (radDivisao.Checked)
            {
                Dividir();
            }
            else
            {
                MessageBox.Show("Selecione uma opção");
            }

            txtApresentar.Text = resultado;
        }

        private void Somar()
        {
            double soma = numero01 + numero02;
            resultado = resultado = String.Format(
                "A soma de {0} por {1} é {2:n}",
                numero01, numero02, soma
                );
        }

        private void Subtrair()
        {
            double subtracao = numero01 - numero02;
            resultado = resultado = String.Format(
                "A subtração de {0} por {1} é {2:n}",
                numero01, numero02, subtracao
                );
        }

        private void Multiplicar()
        {
            double multiplicacao = numero01 * numero02;
            resultado = resultado = String.Format(
                "A multiplicação de {0} por {1} é {2:n}",
                numero01, numero02, multiplicacao
                );
        }

        private void Dividir()
        {
            double divisao = (numero01 / numero02);
            resultado = String.Format(
                "A divisão de {0} por {1} é {2:n}",
                numero01,numero02,divisao
                );
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularEGuardar();
        }

        private void txtNumero02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularEGuardar();
                btnCalcular.PerformClick();
            }
        }

    }
}
