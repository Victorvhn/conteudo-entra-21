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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btExemplo1_Click(object sender, EventArgs e)
        {
            Exemplo01 exemplo01 = new Exemplo01();
            exemplo01.Show();
        }

        private void btExemplo2_Click(object sender, EventArgs e)
        {
            Exemplo02 exemplo02 = new Exemplo02();
            exemplo02.Show();
        }

        private void btExemplo3_Click(object sender, EventArgs e)
        {
            Exemplo03 exemplo03 = new Exemplo03();
            exemplo03.Show();
        }

        private void btExemplo4_Click(object sender, EventArgs e)
        {
            Exemplo04 exemplo04 = new Exemplo04();
            exemplo04.Show();
        }

        private void btExemplo5_Click(object sender, EventArgs e)
        {
            Exemplo05 exemplo05 = new Exemplo05();
            exemplo05.Show();
        }

        private void btnExemplo06_Click(object sender, EventArgs e)
        {
            Exemplo06 exemplo06 = new Exemplo06();
            exemplo06.Show();
        }

    }
}
