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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        public void Algoritimo()
        {
            int anoAtual = DateTime.Now.Year;

            int anoInserido = Convert.ToInt32(nudAno.Text);

            int AnosVividos = anoAtual - anoInserido;
            int DiasVividos = AnosVividos * 365;
            int MesesVivivos = AnosVividos * 12;
            int HorasVividas = DiasVividos * 24;
            string MinutosVividos = String.Format("{0}",HorasVividas * 60);
            string SegundosVividos = String.Format("{0}",Convert.ToInt32(MinutosVividos) * 60);

            txtResultado.Text = String.Format(
                "Anos vividos: {0}\r\n" +
                "Meses vividos: {1}\r\n" +
                "Dias vividos: {2}\r\n" +
                "Horas vividas: {3}\r\n" +
                "Minutos vividos: {4}\r\n" +
                "Segundos vividos: {5}",
                AnosVividos,MesesVivivos,DiasVividos,HorasVividas,MinutosVividos,SegundosVividos);
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            Algoritimo();
        }

        private void nudAno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnConferir.PerformClick();
            }
        }
    }
}
