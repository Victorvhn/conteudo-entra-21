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
    public partial class Exercicio08 : Form
    {
        public Exercicio08()
        {
            InitializeComponent();
        }
        double contaLuz = 0;
        double contaAgua = 0;
        double contaNET = 0;
        double contaOI = 0;
        double contaVivo = 0;
        double contaIPTU = 0;
        double contaIPVA = 0;
        double contaSeguroCarro = 0;

        public void Algoritino()
        {
            // validação conta luz
            try
            {
                contaLuz = Convert.ToDouble(mtbContaLuz.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta de luz");
                mtbContaLuz.Focus();
                return;
            }

            // validação conta agua
            try
            {
                contaAgua = Convert.ToDouble(mtbContaAgua.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta de água");
                mtbContaAgua.Focus();
                return;
            }

            // validação conta net
            try
            {
                contaNET = Convert.ToDouble(mtbContaNet.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta da net");
                mtbContaNet.Focus();
                return;
            }

            // validação da oi

            try
            {
                contaOI = Convert.ToDouble(mtbContaOi.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta da oi");
                mtbContaOi.Focus();
                return;
            }

            // validação da vivo
            try
            {
                contaVivo = Convert.ToDouble(mtbContaVivo.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta da vivo");
                mtbContaVivo.Focus();
                return;
            }

            // validação do iptu
            try
            {
                contaIPTU = Convert.ToDouble(mtbContaIPTU.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta do IPTU");
                mtbContaIPTU.Focus();
                return;
            }

            // validação do ipva
            try
            {
                contaIPVA = Convert.ToDouble(mtbIPVA.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta do IPVA");
                mtbIPVA.Focus();
                return;
            }

            //validação do seguro do carro
            try
            {
                contaSeguroCarro = Convert.ToDouble(mtbSeguroCarro.Text);
            }
            catch
            {
                MessageBox.Show("Deve conter algum valor na conta do seguro do carro");
                mtbSeguroCarro.Focus();
                return;
            }

            double totalContasTelefonicas = contaOI + contaVivo + contaNET;
            double totalContasImpostos = contaIPTU + contaIPVA;
            double totalContasRestantes = contaLuz + contaAgua + contaSeguroCarro;

            double totalContas = totalContasImpostos + totalContasRestantes + totalContasTelefonicas;

            string informacoes = String.Format(
                "Valor das contas de Telefone: {0:n}\r\n" +
                "Valor dos impostos: {1:n}\r\n" +
                "Valor do restante das contas: {2:n}\r\n\r\n" +
                "Valor Total de todas as contas: {3:n}",
                totalContasTelefonicas, totalContasImpostos, totalContasRestantes, totalContas);

            txtInformacoes.Text = informacoes;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Algoritino();
        }

        private void mtbContaOi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritino();
                btnGerar.PerformClick();
            }
        }
    }
}
