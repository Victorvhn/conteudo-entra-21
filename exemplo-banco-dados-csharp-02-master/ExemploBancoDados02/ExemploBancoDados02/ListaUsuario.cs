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
    public partial class ListaHerois : Form
    {
        public ListaHerois()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroHeroi cadastroHerois = new CadastroHeroi();
            cadastroHerois.ShowDialog();
        }

        private void AtualizarLista()
        {
            string coluna = "nome";
            if (rbColunaRaca.Checked)
            {
                coluna = "raca";
            }
            else if (rbColunaContaBancaria.Checked)
            {
                coluna = "conta_bancaria";
            }

            string tipoOrdenacao = "ASC";
            if (rbOrdemDesc.Checked)
            {
                tipoOrdenacao = "DESC";
            }

            dgvLista.Rows.Clear();
            List<Heroi> herois = new HeroiRepositorio().ObterTodos(txtPesquisa.Text, coluna, tipoOrdenacao); 
            foreach(Heroi heroi in herois)
            {
                dgvLista.Rows.Add(new object[]
                    {
                        heroi.Id,
                        heroi.Nome,
                        heroi.Raca,
                        heroi.ContaBancaria
                    });
            }
        }

        private void ListaHerois_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum herói selecionado!");
                return;
            }

            int linhaSelecionada = dgvLista.CurrentRow.Index;
            int codigo = Convert.ToInt32(dgvLista.Rows[linhaSelecionada].Cells[0].Value.ToString());
            string nome = dgvLista.Rows[linhaSelecionada].Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                bool apagado = new HeroiRepositorio().Apagar(codigo);
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show(nome + " não apagado.");
            }
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            EstatisticasHerois estatisticasHerois = new EstatisticasHerois();
            estatisticasHerois.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvLista.CurrentRow.Index;
            int codigo = Convert.ToInt32(dgvLista.Rows[linhaSelecionada].Cells[0].Value.ToString());
            new CadastroHeroi(codigo).ShowDialog();
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void rbColunaNome_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbColunaRaca_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbColunaContaBancaria_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbOrdemAsc_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbOrdemDesc_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void ListaHerois_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
