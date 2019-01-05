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
    public partial class Exercicio07 : Form
    {
        public Exercicio07()
        {
            InitializeComponent();
        }

        int numero = 0;
        string parImparNeutro = "";
        string negativoPositivo = "";
        string maiorMenorQueDez = "";
        string menorIgual50 = "";
        string menorMenos10 = "";
        string maiorIgual30 = "";
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

            // par, ímpar e neutro
            if (numero == 0)
            {
                parImparNeutro = "neutro";
            }
            else if (numero % 2 == 0)
            {
                parImparNeutro = "par";
            }
            else
            {
                parImparNeutro = "ímpar";
            }

            // negativo positivo
            if (numero > 0)
            {
                negativoPositivo = "positivo";
            }
            else if (numero < 0)
            {
                negativoPositivo = "negativo";
            }

            // maior menor 10
            if (numero > 10)
            {
                maiorMenorQueDez = "maior que 10";
            }
            else
            {
                maiorMenorQueDez = "menor que 10";
            }

            // menor igual 50
            if (numero == 50)
            {
                menorIgual50 = "igual 50";
            }
            else if (numero < 50)
            {
                menorIgual50 = "menor que 50";
            }

            // menor -10
            if (numero < -10)
            {
                menorMenos10 = "é menor que -10";
            }
            else
            {
                menorMenos10 = "não é menor que -10";
            }

            // maior igual 30
            if (numero == 30)
            {
                maiorIgual30 = "é igual a 30";
            }
            else if (numero > 30)
            {
                maiorIgual30 = "é maior que 30";
            }
            else
            {
                maiorIgual30 = "não é maior ou igual a 30";
            }

            // diferente 1
            if (numero == 1)
            {
                diferente1 = "não é diferente de 1";
            }
            else if (numero != 1)
            {
                diferente1 = "é diferente de 1";
            }

            if (numero == 0)
            {
                txtInformacoes.Text = String.Format(
                   @"O número {0} é {1};

O número {0} é {2};

O número {0} é {3};

O número {0} {4};

O número {0} {5};

O número {0} {6}",
                   numero, parImparNeutro, maiorMenorQueDez, menorIgual50, menorMenos10, maiorIgual30, diferente1);

            }
            else
            {
                txtInformacoes.Text = String.Format(
                    @"O número {0} é {1};

O número {0} é {2};

O número {0} é {3};

O número {0} é {4};

O número {0} {5};

O número {0} {6};

O número {0} {7}",
                    numero, parImparNeutro, negativoPositivo, maiorMenorQueDez, menorIgual50, menorMenos10, maiorIgual30, diferente1);
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            PegarInformacoesEVerificar();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PegarInformacoesEVerificar();
                btnConferir.PerformClick();
            }
        }
    }
}
