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
    public partial class ListaCarro : Form
    {
        string nomeAntigo = String.Empty;
        List<Carro> carros = new List<Carro>();

        public ListaCarro()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbcCarro.SelectedIndex = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtMarca.Text = "";
            txtValor.Text = "";
            txtAno.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Carro carro = new Carro()
                {
                    Nome = txtNome.Text,
                    Marca = txtMarca.Text,
                    AnoFabricacao = Convert.ToInt16(txtAno.Text),
                    Valor = Convert.ToDecimal(txtValor.Text)
                };
                if (nomeAntigo == "")
                {
                    carros.Add(carro);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarCarroATabela(carro);
                }
                else
                {
                    /*for (int i = 0; i < carros.Count(); i++)
                    {
                        Carro carroAux = carros[i];
                        if (carroAux.Nome == nomeAntigo)
                        {
                            carros[i] = carro;
                        }
                    }*/
                    int linha = carros.FindIndex(x => x.Nome == nomeAntigo);
                    carros[linha] = carro;
                    EditarCarroNaTabela(carro, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }
                LimparCampos();
                tbcCarro.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarCarroNaTabela(Carro carro, int linha)
        {
            dgvListaCarros.Rows[linha].Cells[0].Value = carro.Nome;
            dgvListaCarros.Rows[linha].Cells[1].Value = carro.Marca;
            dgvListaCarros.Rows[linha].Cells[2].Value = carro.AnoFabricacao;
            dgvListaCarros.Rows[linha].Cells[3].Value = carro.Valor;
        }

        private void AdicionarCarroATabela(Carro carro)
        {
            dgvListaCarros.Rows.Add(new Object[]
                {
                    carro.Nome, carro.Marca, carro.AnoFabricacao, carro.Valor
                });
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvListaCarros.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre um carro");
                tbcCarro.SelectedIndex = 1;
                return;
            }

            if (dgvListaCarros.SelectedRows == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dgvListaCarros.CurrentRow.Index;
            /*string nome = dgvListaCarros.Rows[linhaSelecionada].Cells[0].Value.ToString();
            for (int i = 0; i < carros.Count(); i++)
            {
                Carro carro = carros[i];
                if (carro.Nome == nome)
                {
                    carros.RemoveAt(i);
                }
            }
            carros.Remove(carros.Find(x => x.Nome == nome));*/
            dgvListaCarros.Rows.RemoveAt(linhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaCarros.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre um carro");
                tbcCarro.SelectedIndex = 1;
                return;
            }

            if (dgvListaCarros.SelectedRows == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dgvListaCarros.CurrentRow.Index;
            string nome = dgvListaCarros.Rows[linhaSelecionada].Cells[0].Value.ToString();
            foreach (Carro carro in carros)
            {
                if (carro.Nome == nome)
                {
                    txtNome.Text = carro.Nome;
                    txtMarca.Text = carro.Marca;
                    txtAno.Text = carro.AnoFabricacao.ToString();
                    txtValor.Text = carro.Valor.ToString();
                    nomeAntigo = carro.Nome;
                    tbcCarro.SelectedIndex = 1;
                    break;
                }
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMarca.Focus();
            }
        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAno.Focus();
            }
        }

        private void txtAno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor.Focus();
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }
    }
}