using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploListaWFA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnExemplo01_Click(object sender, EventArgs e)
        {
            Exemplo01 exemeplo01 = new Exemplo01();
            exemeplo01.Show();
        }
    }
}
