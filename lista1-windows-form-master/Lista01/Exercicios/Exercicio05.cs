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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }

        string nomeCarro = "";
        double valorCarro = 0;
        double valorParcelas = 0;
        int quantidadeParcelas = 0;

        double valorTotalFinanciamento = 0;
        double diferencaFinanciamento = 0;

        private void MostrarInformacoes()
        {
            string informacoes = String.Format(
                    "Nome do carro: {0}\r\n" +
                    "Valor do carro: {1:n}\r\n" +
                    "Valor de cada parcela: R$ {2:n}\r\n" +
                    "Quantidade de parcelas: R$ {3}\r\n" +
                    "Valor total do financiamento: R$ {4:n}\r\n" +
                    "Diferença dos valores: R$ {5:n}",
                    nomeCarro, valorCarro, valorParcelas, quantidadeParcelas, valorTotalFinanciamento, diferencaFinanciamento
                    );

            txtInformacoes.Text = informacoes;
        }

        private void Algoritimo()
        {
            nomeCarro = txtNomeCarro.Text;

            try
            {
                if (nomeCarro.Length <= 2)
                {
                    MessageBox.Show("Informe um nome válido. O nome do carro deve conter pelo menos dois caracteres");
                    txtNomeCarro.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Parece que esta faltando algo.");
            }


            if (mtbValorCarro.Text.Replace(".", "") == "")
            {
                MessageBox.Show("Valor do carro deve ser preenchido!");
                mtbValorCarro.Focus();
                return;
            }
            try
            {
                valorCarro = Convert.ToDouble(mtbValorCarro.Text);
            }
            catch
            {
                MessageBox.Show("Opss... O valor do carro deve ser preenchido!");
                mtbValorCarro.Focus();
                return;
            }

            if (mtbValorParcelas.Text.Replace(".", "") == "")
            {
                MessageBox.Show("Valor das parcelas deve ser preenchido!");
                mtbValorParcelas.Focus();
                return;
            }
            try
            {
                valorParcelas = Convert.ToDouble(mtbValorParcelas.Text);
            }
            catch
            {
                MessageBox.Show("Opss... O valor das parcelas deve ser preenchido!");
                mtbValorParcelas.Focus();
                return;
            }

            quantidadeParcelas = Convert.ToInt32(nudQuantidadeParcelas.Value);
            if (quantidadeParcelas == 0)
            {
                MessageBox.Show("Deve conter pelo 1 parcela");
                nudQuantidadeParcelas.Focus();
                return;
            }

            valorTotalFinanciamento = valorParcelas * quantidadeParcelas;
            diferencaFinanciamento = valorTotalFinanciamento - valorCarro;

            MostrarInformacoes();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            Algoritimo();
        }

        private void nudQuantidadeParcelas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnConferir.PerformClick();
            }
        }
    }
}
