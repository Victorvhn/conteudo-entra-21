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
    public partial class Exercicio07 : Form
    {
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            string arvore = String.Format(
                @"
           *
          ***
         *****
        *******
       *********
      ***********");

            txtArvore.Text = arvore;
        }

    }
}
