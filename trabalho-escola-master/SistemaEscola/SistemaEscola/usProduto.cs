using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class usProduto : UserControl
    {
        public usProduto()
        {
            InitializeComponent();
            AtualizarListaProdutos();
            gbLivro.Enabled = false;
        }
        private int posicaoProdutos = -1;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtNomeProduto.Text.Length < 4)
            {
                MessageBox.Show("Nome do Produto deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomeProduto.Focus();
                return;
            }

            if (nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Coloque uma quantidade de produtos maior que 0.");
                nudQuantidade.Focus();
                return;
            }

            if (cbSetor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o setor do produto.");
                cbSetor.DroppedDown = true;
                return;
            }

            if (txtValorUnitario.Text.Length == 0)
            {
                MessageBox.Show("Valor unitário deve ser ser preenchido");
                txtValorUnitario.Focus();
                return;
            }
            try
            {
                double valorUnitarioProduto = Convert.ToDouble(txtValorUnitario.Text);
            }
            catch
            {
                MessageBox.Show("Valor deve conter somente números reais!");
                txtValorUnitario.Focus();
                return;
            }

            if (dtpDataDeEntrada.Value > DateTime.Now)
            {
                MessageBox.Show("Data da compra deve ser hoje ou uma data anterior.");
                dtpDataDeEntrada.Focus();
                return;
            }

            if (txtNomeLivro.Text.Length < 4 && cbSetor.Text == "Biblioteca")
            {
                MessageBox.Show("Nome do livro deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomeLivro.Focus();
                return;
            }

            if (cbCapa.SelectedIndex < 0 && cbSetor.Text == "Biblioteca")
            {
                MessageBox.Show("Selecione a capa do livro.");
                cbCapa.Focus();
                return;
            }

            if (cbDisciplina.SelectedIndex < 0 && cbSetor.Text == "Biblioteca")
            {
                MessageBox.Show("Selecione a disciplina do livro.");
                cbDisciplina.DroppedDown = true;
                return;
            }

            if (txtNomeAutor.Text.Length < 5 && cbSetor.Text == "Biblioteca")
            {
                MessageBox.Show("Nome do autor do livro deve conter no mínimo 5 caracteres. Digite o nome completo.");
                txtNomeAutor.Focus();
                return;
            }

            if (dtpAnoDeLancamento.Value > DateTime.Now && cbSetor.Text == "Biblioteca")
            {
                MessageBox.Show("Data da compra deve ser hoje ou uma data anterior.");
                dtpAnoDeLancamento.Focus();
                return;
            }

            ListaProduto listaProduto = new ListaProduto()
            {
                Nome = txtNomeProduto.Text,
                Setor = cbSetor.SelectedItem.ToString(),
                Quantidade = Convert.ToInt32(nudQuantidade.Value),
                Entrada = dtpDataDeEntrada.Value,
                ValorUnitario = Convert.ToDouble(txtValorUnitario.Text),
                LivroNome = txtNomeLivro.Text,
                LivroDisciplina = cbDisciplina.SelectedItem.ToString(),
                LivroCapa = cbCapa.SelectedItem.ToString(),
                LivroNomeAutor = txtNomeAutor.Text,
                LivroAnoLancamento = dtpAnoDeLancamento.Value
            };

            if (cbSetor.SelectedItem.ToString() == "Biblioteca")
            {
                ListaProduto produtoLivro = new ListaProduto()
                {
                    
                    LivroNome = txtNomeLivro.Text,
                    LivroDisciplina = cbDisciplina.SelectedItem.ToString(),
                    LivroCapa = cbCapa.SelectedItem.ToString(),
                    LivroNomeAutor = txtNomeAutor.Text,
                    LivroAnoLancamento = dtpAnoDeLancamento.Value
                };
            }
            if (cbSetor.SelectedItem.ToString() == "Biblioteca")
            {
                ListaProduto produtoComLivro = new ListaProduto()
                {
                    Nome = txtNomeProduto.Text,
                    Setor = cbSetor.SelectedItem.ToString(),
                    Quantidade = Convert.ToInt32(nudQuantidade.Value),
                    Entrada = dtpDataDeEntrada.Value,
                    ValorUnitario = Convert.ToDouble(txtValorUnitario.Text),
                    LivroNome = txtNomeLivro.Text,
                    LivroDisciplina = cbDisciplina.SelectedItem.ToString(),
                    LivroCapa = cbCapa.SelectedItem.ToString(),
                    LivroNomeAutor = txtNomeAutor.Text,
                    LivroAnoLancamento = dtpAnoDeLancamento.Value
                };
               
            }
            else
            {
                ListaProduto produtoSemLivro = new ListaProduto()
                {
                    Nome = txtNomeProduto.Text,
                    Setor = cbSetor.SelectedItem.ToString(),
                    Quantidade = Convert.ToInt32(nudQuantidade.Value),
                    Entrada = dtpDataDeEntrada.Value,
                    ValorUnitario = Convert.ToDouble(txtValorUnitario.Text),
                };
                if (posicaoProdutos >= 0)
                {
                    Program.produtos[posicaoProdutos] = produtoSemLivro;
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                else
                {
                    Program.produtos.Add(produtoSemLivro);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
            }

            int linhaposicao = dgvProduto.CurrentRow.Index;

            if (linhaposicao == -1)
            {
                Program.produtos.Add(listaProduto);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
           
            else
            {
                Program.produtos[linhaposicao] = listaProduto;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }

            LimparCamposProdutos();
            AtualizarListaProdutos();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
                return;
            }
        }

        private void AtualizarListaProdutos()
        {
            dgvProduto.Rows.Clear();
            string busca = txtBuscarProduto.Text.ToLower();
            for (int i = 0; i < Program.produtos.Count; i++)
            {
                ListaProduto produto = Program.produtos[i];
                if ((produto.Nome.ToLower().Contains(busca))
                    || (produto.LivroNome.ToLower().Contains(busca)) || (produto.LivroNomeAutor.ToLower().Contains(busca)) || (produto.Setor.ToLower().Contains(busca)) || (produto.LivroCapa.ToLower().Contains(busca)))
                {
                    dgvProduto.Rows.Add(new object[]{
                    produto.Nome, produto.Quantidade, produto.Entrada, produto.Setor
                });
                }
            }
        }

        private void LimparCamposProdutos()
        {
            txtNomeProduto.Text = "";
            cbSetor.SelectedIndex = -1;
            nudQuantidade.Value = 0;
            dtpDataDeEntrada.Value = DateTime.Now;
            txtValorUnitario.Text = "0";
            txtNomeLivro.Text = "";
            cbDisciplina.SelectedIndex = -1;
            cbCapa.SelectedIndex = -1;
            txtNomeAutor.Text = "";
            dtpAnoDeLancamento.Value = DateTime.Now;
        }

        private void cbSetorProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string biblioteca = cbSetor.Text.ToLower();
            if (biblioteca == "biblioteca")
            {
                gbLivro.Enabled = true;
            }
            else
            {
                gbLivro.Enabled = false;
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarListaProdutos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvProduto.CurrentRow.Index;

            ListaProduto produto = Program.produtos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + produto.Nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.produtos.RemoveAt(linhaSelecionada);
                AtualizarListaProdutos();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void txtBuscarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaProdutos();
            }
        }

        public void InserirInformacoesDoProdutoNoCadastro()
        {
            ListaProduto produto = Program.produtos.Find(x =>
                x.Nome == Convert.ToString(this.dgvProduto.CurrentRow.Cells["ColumnNomeProduto"].Value));
            
                this.txtNomeProduto.Text = produto.Nome;
                this.cbSetor.Text = produto.Setor;
                this.txtValorUnitario.Text = produto.ValorUnitario.ToString();
                this.dtpDataDeEntrada.Value = Convert.ToDateTime(produto.Entrada);
                this.nudQuantidade.Value = produto.Quantidade;
                this.txtNomeLivro.Text = produto.LivroNome;
                this.txtNomeAutor.Text = produto.LivroNomeAutor;
                this.cbCapa.Text = produto.LivroCapa;
                this.cbDisciplina.Text = produto.LivroDisciplina;
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            InserirInformacoesDoProdutoNoCadastro();
            gbLivro.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            posicaoProdutos = dgvProduto.CurrentRow.Index;
            ListaProduto listaProduto = Program.produtos[posicaoProdutos];
            InserirInformacoesDoProdutoNoCadastro();
        }
    
        
    }
}
