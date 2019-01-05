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
    public partial class Exemplo03 : Form
    {
        int quantidade1 = 0, quantidade2 = 0, quantidade3 = 0;
        double valor1 = 0, valor2 = 0, valor3 = 0;

        public Exemplo03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInformações();

            if (rbSomar.Checked)
            {
                Somar();
            }
            else if (rbMedia.Checked)
            {
                Media();
            }
            else if (rbMaior.Checked)
            {
                Maior();
            }
            else if (rbMenor.Checked)
            {
                Menor();
            }
            else
            {
                MessageBox.Show("Selecione uma opção");
            }
        }

        public void ArmazenarInformações()
        {
            quantidade1 = Convert.ToInt32(nudQuantidade01.Value);
            valor1 = Convert.ToDouble(mtbValor01.Text);

            quantidade2 = Convert.ToInt32(nudQuantidade02.Value);
            valor2 = Convert.ToDouble(mtbValor02.Text);

            quantidade3 = Convert.ToInt32(nudQuantidade03.Value);
            valor3 = Convert.ToDouble(mtbValor03.Text);
        }

        public void Somar()
        {
            double total = (quantidade1 * valor1) + (quantidade2 * valor2) + (quantidade3 * valor3);
            MessageBox.Show(String.Format("Soma: {0:n}",total));
        }

        public void Media()
        {
            double media = ((quantidade1 * valor1) + (quantidade2 * valor2) + (quantidade3 * valor3)) / 3;
            MessageBox.Show(String.Format("Média: {0:n}",media));
        }
       
        public void Menor()
        {
            double menorValor = int.MaxValue;

            if (menorValor > valor1)
            {
                menorValor = valor1;
            }
            if (menorValor > valor2)
            {
                menorValor = valor2;
            }
            if (menorValor > valor3)
            {
                menorValor = valor3;
            }
            MessageBox.Show(String.Format("Menor valor é: {0:n}", menorValor));
        }  
        
        public void Maior()
        {
            double maiorValor = int.MinValue;

            if (maiorValor < valor1)
            {
                maiorValor = valor1;
            }
            if (maiorValor < valor2)
            {
                maiorValor = valor2;
            }
            if (maiorValor < valor3)
            {
                maiorValor = valor3;
            }

            MessageBox.Show("Maior valor é: " + maiorValor);
        }
    }
}
