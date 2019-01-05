using ExemploBancoDados02.Modelo;
using ExemploBancoDados02.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDados02
{
    public partial class CadastroHeroi : Form
    {
        private int codigo;

        public CadastroHeroi()
        {
            InitializeComponent();
        }

        public CadastroHeroi(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(codigo);
            PreencherCampos(heroi);
        }

        private void PreencherCampos(Heroi heroi)
        {
            txtNome.Text = heroi.Nome;
            txtNomePessoa.Text = heroi.NomePessoa;
            txtCodigo.Text = heroi.Id.ToString();
            txtContaBancaria.Text = heroi.ContaBancaria.ToString();
            nudQuantidadeFilmes.Value = Convert.ToByte(heroi.QuantidadeFilmes);
            chkMulher.Checked = heroi.Sexo == 'm';
            cbRaca.SelectedItem = heroi.Raca;
            rtbDescricao.Text = heroi.Descricao;

            if (heroi.Escuridao)
            {
                rbSim.Checked = true;
            }
            else
            {
                rbNao.Checked = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();
            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = txtNomePessoa.Text;
            heroi.ContaBancaria = Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento = dtpDataNascimento.Value;
            heroi.Escuridao = rbSim.Checked;
            heroi.QuantidadeFilmes = Convert.ToByte(nudQuantidadeFilmes.Value);
            heroi.Raca = cbRaca.SelectedItem.ToString();
            heroi.Sexo = chkMulher.Checked ? 'M' : 'H';
            heroi.Descricao = rtbDescricao.Text;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                int id = new HeroiRepositorio().Inserir(heroi);
                txtCodigo.Text = id.ToString();
                MessageBox.Show("Registro cadastrado com sucesso.");
            }
            else
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                heroi.Id = id;
                bool alterou = new HeroiRepositorio().Alterar(heroi);
                if (alterou)
                {
                    MessageBox.Show("Registro alterado com sucesso");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar");
                }
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            rbSim.Checked = false;
            rbNao.Checked = false;
            txtNomePessoa.Text = "";
            cbRaca.SelectedIndex = -1;
            chkMulher.Checked = false;
            nudQuantidadeFilmes.Value = 0;
            txtContaBancaria.Text = "";
            dtpDataNascimento.Value = DateTime.Now;
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbSim.Focus();
            }
        }

        private void rbSim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNomePessoa.Focus();
            }
        }

        private void rbNao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNomePessoa.Focus();
            }
        }

        private void cbRaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkMulher.Focus();
            }
        }

        private void chkMulher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudQuantidadeFilmes.Focus();
            }
        }

        private void nudQuantidadeFilmes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContaBancaria.Focus();
            }
        }

        private void txtContaBancaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDataNascimento.Focus();
            }
        }

        private void dtpDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbDescricao.Focus();
            }
        }

        private void rtbDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(id);
                    if (heroi != null)
                    {
                        PreencherCampos(heroi);
                    }
                    else
                    {
                        MessageBox.Show("Registro não existente");
                        txtCodigo.Focus();
                        txtCodigo.SelectionStart = 0;// SELECIONA O TEXTO -----------------------------------------------
                        txtCodigo.SelectionLength = txtCodigo.Text.Length;
                    }
                }
                catch (NotFiniteNumberException ex)
                {
                    MessageBox.Show("Digite um código válido");
                    txtCodigo.Focus();
                }
            }
        }

    }
}
