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
    public partial class Exemplo01 : Form
    {
        List<Int32> numeros = new List<Int32>();

        public Exemplo01()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                numeros.Add(numero);
                cbSelecioneParaEditar.Items.Add(numero);
                txtNumero.Text = "";
                MessageBox.Show(String.Format("Número {0} cadastrado com sucesso!", numero));
                txtNumero.Focus();
            }
            catch
            {
                MessageBox.Show("Favor insira um número válido.");
                txtNumero.Focus();
                return;
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            rtbNumero.Clear();
            for (int i = 0; i < numeros.Count; i++)
            {
                rtbNumero.AppendText(numeros[i] + "\n");
            }
        }

        private void txtPosicaoApagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show("Você realmente deseja apagar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    int posicao = Convert.ToInt32(txtPosicaoApagar.Text);
                    numeros.RemoveAt(posicao);
                    btnProcessar.PerformClick();
                    AtualizarComboBoxParaEditar();
                    txtPosicaoApagar.Text = "";
                    MessageBox.Show("Registro apagado com sucesso!");
                    txtNumero.Focus();
                }
                else
                {
                    MessageBox.Show("TAIX SALVO NEGO");
                }
            }
        }

        private void txtValorParaApagar_Leave(object sender, EventArgs e)
        {
            if (txtValorParaApagar.Text != "")
            {
                int valor = Convert.ToInt32(txtValorParaApagar.Text);
                while (numeros.Contains(valor))
                {
                    numeros.Remove(valor);
                }
                txtValorParaApagar.Text = "";
                AtualizarComboBoxParaEditar();
                MessageBox.Show(valor + " apagado com sucesso");
                btnProcessar.PerformClick();
            }
        }

        private void AtualizarComboBoxParaEditar()
        {
            cbSelecioneParaEditar.Items.Clear();
            for (int i = 0; i < numeros.Count; i++)
            {
                cbSelecioneParaEditar.Items.Add(numeros[i]);
            }
        }

        private void cbSelecioneParaEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelecioneParaEditar.SelectedIndex > -1)
            {
                txtNumeroEditar.Enabled = true;
                txtNumeroEditar.Focus();
            }
        }

        private void txtNumeroEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int posicao = cbSelecioneParaEditar.SelectedIndex;
                int valorNovo = Convert.ToInt32(txtNumeroEditar.Text);

                numeros[posicao] = valorNovo;

                txtNumeroEditar.Text = "";
                txtNumeroEditar.Enabled = false;
                cbSelecioneParaEditar.SelectedIndex = -1;
                btnProcessar.PerformClick();
                AtualizarComboBoxParaEditar();
            }
        }
    }
}
