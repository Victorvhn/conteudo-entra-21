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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }
        int numero1 = 0;
        int numero2 = 0;

        public void Algoritimo()
        {
            numero1 = Convert.ToInt32(nudNumero01.Value);
            numero2 = Convert.ToInt32(nudNumero02.Value);

            numero1 = numero1 + numero2;
            numero2 = numero1 - numero2;
            numero1 = numero1 - numero2;

            string texto = String.Format(
                "Numero 1 = {0}\r\n" +
                "Numero 2 = {1}\r\n",
                numero1, numero2);

            txtResultado.Text = texto;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Algoritimo();
        }

        private void nudNumero02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnResultado.PerformClick();
            }
        }
    }
}
