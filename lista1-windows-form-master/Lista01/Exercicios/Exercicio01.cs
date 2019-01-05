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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }
        int numero = 0;

        int antecessor = 0;
        int sucessor = 0;
        string resultado = "";

        private void Conta()
        {
            numero = Convert.ToInt32(nudNumero.Value);

            antecessor = numero - 1;
            sucessor = numero + 1;
            resultado = String.Format(
                "Antecessor: {0}\r\n" +
                "Número: {1}\r\n" +
                "Sucessor: {2}\r\n",
                antecessor, numero, sucessor);
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            Conta();
            txtResultado.Text = resultado;
        }

        private void nudNumero_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Conta();
                btnConferir.PerformClick();
            }

        }
    }
}
