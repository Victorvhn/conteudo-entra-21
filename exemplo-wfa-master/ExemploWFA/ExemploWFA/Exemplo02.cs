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
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            int quantidadeDeHoras = Convert.ToInt32(txtQuantidadeDeHoras.Text);
            double valorHoras = Convert.ToDouble(txtValorHora.Text);
            double salario = quantidadeDeHoras * valorHoras;

            string unidadeFederativa = cbUnidadeFederativa.SelectedItem.ToString();
            string cidade = txtCidade.Text.Trim();
            string bairro = txtBairro.Text.Trim();
            string logradouro = txtLogradouro.Text.Trim();
            string complemento = txtComplemento.Text.Trim();
            string numero = txtNumero.Text.Trim();
            bool Feminino = rbFeminino.Checked;
            string dataNascimento = dtpDataDeNascimento.Text;

            if (salario < 1000)
            {
                MessageBox.Show("Professor de LOL");
            }
            else if (salario < 10000)
            {
                MessageBox.Show("Professor de Fortnite");
            }
            else if (salario < 100000)
            {
                MessageBox.Show("Professor de Dota 2");
            }
            else if (salario < 500000)
            {
                MessageBox.Show("Professor Junior de Tibia");
            }
            else
            {
                MessageBox.Show("Mestre Pleno de Tibia");
            }

        }
    }
}
