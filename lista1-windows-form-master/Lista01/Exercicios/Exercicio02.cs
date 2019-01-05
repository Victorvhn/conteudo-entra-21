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

        string resultado = "";

        public void Algoritimo()
        {
            int quantidadeLitros = Convert.ToInt32(nudQuantidadeLitros.Value);
            int quantidadeAnos = Convert.ToInt32(nudQuantidadeAnos.Value);

            double quantidadePagoLitro = 0;


            if (mtbValorLitro.Text == ".")
            {
                MessageBox.Show("Valor deve ser preenchido!");
                mtbValorLitro.Focus();
                return;
            }
            try
            {
                quantidadePagoLitro = Convert.ToDouble(mtbValorLitro.Text);
            }
            catch
            {

                MessageBox.Show("Parece que você esqueceu de colocar o valor pago por litro.");
                mtbValorLitro.Focus();
                return;
            }

            double quantidadeLitrosConsumidos = quantidadeLitros * (quantidadeAnos * 365);
            double valorTotalPago = quantidadeLitrosConsumidos * quantidadePagoLitro;

            resultado = String.Format(
                "Quantidade de Litros consumidos: {0} L\r\n" +
                "Valor Total Pago: R$ {1:n}",
                quantidadeLitrosConsumidos, valorTotalPago);
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {

            Algoritimo();
            txtResultado.Text = resultado;
        }

        private void mtbValorLitro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnConferir.PerformClick();
            }
        }

    }
}
