using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Time time = new Time(
                txtNome.Text, txtPais.Text, txtSerie.Text)
                {
                    Faturamento = Convert.ToDecimal(txtFaturamento.Text)
                };
        }

        private void btnSalvarRapido_Click(object sender, EventArgs e)
        {
            Time time = new Time(txtNomeCadastroRapido.Text, txtPaisCadastroRapido.Text);
        }
    }
}
