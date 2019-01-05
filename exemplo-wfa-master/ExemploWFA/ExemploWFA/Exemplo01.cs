using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
            MessageBox.Show("A soma é: " + (2 + 2));
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = txtNome.Text;
            string sobrenomeDoUsuario = txtSobrenome.Text;
            MessageBox.Show(nomeDoUsuario + " " + sobrenomeDoUsuario);
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;

            try
            {
                nota1 = Convert.ToDouble(txtNota01.Text);

            }
            catch
            {
                MessageBox.Show("Nota 1 deve conter somente números reais");
                txtNota01.Focus();
                return;
            }

            try
            {
                nota2 = Convert.ToDouble(txtNota02.Text);                
            }
            catch
            {
                MessageBox.Show("Nota 2 deve conter somente números reais");
                txtNota02.Focus();
                return;
            }

            try
            {
                nota3 = Convert.ToDouble(txtNota03.Text);
            }
            catch
            {
                MessageBox.Show("Nota 3 deve conter somente números reais");
                txtNota03.Focus();
                return;
            }

            try
            {
                nota4 = Convert.ToDouble(txtNota04.Text);
            }
            catch
            {
                MessageBox.Show("Nota 4 deve conter somente números reais");
                txtNota04.Focus();
                return;
            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            string textao = String.Format(
                "Nota 1: {0:n}\r\nNota 2: {1:n}\r\nNota 3: {2:n} \r\nNota 4: {3:n} \r\n\r\nMédia: {4:n}",
                nota1,nota2,nota3,nota4,media
                );
            /*
            string textao = String.Format(
                @"Nota 1: {0:n}
Nota 2: {1:n}
Nota 3: {2:n}
Nota 4: {3:n}

Média: {4:n}",
                nota1,nota2,nota3,nota4,media
                );
            */
            txtResultado.Text = textao;
            // MessageBox.Show(String.Format("A média é: {0:n}", media));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
                if (idade < 0)
                {
                    MessageBox.Show("Idade não pode ser menor que 0");
                    txtIdade.Focus();
                    return;
                }

                if (idade > 150)
                {
                    MessageBox.Show("Idade não pode ser maior que 150");
                    txtIdade.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Idade deve conter somente números inteiros");
                txtIdade.Focus();
            }
        }
    }
}
