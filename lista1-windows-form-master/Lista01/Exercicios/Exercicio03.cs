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
        string resultado = "";

        public void Algoritimo()
        {
            double numero01 = Convert.ToDouble(nudNumero01.Value);
            double numero02 = Convert.ToDouble(nudNumero02.Value);

            double soma = numero01 + numero02;
            double subtracao = numero01 - numero02;
            double multiplicacao = numero01 * numero02;
            double divisao = (numero01 / numero02);
            double somaProdutos = soma + subtracao + multiplicacao + divisao;

            resultado = String.Format(
                "Soma: {0}\r\n" +
                "Subtração: {1}\r\n" +
                "Multiplicação: {2}\r\n" +
                "Divisão: {3:n}\r\n" +
                "Produto dos valores: {4}",
                soma, subtracao, multiplicacao, divisao, somaProdutos);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Algoritimo();
            txtResultados.Text = resultado;
        }

        private void nudNumero02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnCalcular.PerformClick();
            }
        }
    }
}
