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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        public void Algoritimo()
        {
            int anoAtual = DateTime.Now.Year;

            int anoInserido = Convert.ToInt32(mtbDataNascimento.Text);

            int idade = anoAtual - anoInserido;

            txtIdade.Text = String.Format("{0}", idade);
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            Algoritimo();
        }

        private void mtbDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnConferir.PerformClick();
            }
        }
    }
}
