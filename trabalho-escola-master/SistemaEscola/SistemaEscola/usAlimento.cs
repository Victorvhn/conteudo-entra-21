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
    public partial class usAlimento : UserControl
    {
        public usAlimento()
        {
            InitializeComponent();
            AtualizarListaAlimentos();
        }
        private int posicao = -1;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeAlimento.Text.Length < 4)
                {
                    MessageBox.Show("Nome do Alimento deve conter no mínimo 3 caracteres.");
                    tabControlAlimentos.SelectTab("tpAlimento");
                    txtNomeAlimento.Focus();
                    return;
                }

                if (cbGrupoAlimentar.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione um grupo alimentar.");
                    tabControlAlimentos.SelectTab("tpAlimento");
                    cbGrupoAlimentar.DroppedDown = true;
                    return;
                }

                if (!Tools.ValidarCNPJ(mtbCnpj.Text))
                {
                    MessageBox.Show("CNPJ inválido.");
                    tabControlAlimentos.SelectTab("tpAlimento");
                    mtbCnpj.Focus();
                    return;
                }

                if (txtCodigoFornecedor.Text.Length < 4)
                {
                    MessageBox.Show("Informe o código do fornecedor");
                    tabControlAlimentos.SelectTab("tpAlimento");
                    txtCodigoFornecedor.Focus();
                    return;
                }

                if (dtpDataDeFabricacao.Value > DateTime.Now) // TODO: Falta Colocar idade minima
                {
                    MessageBox.Show("Data de Fabricação deve ser hoje ou uma data anterior.");
                    tabControlAlimentos.SelectTab("tpAlimento");
                    dtpDataDeFabricacao.Focus();
                    return;
                }

              

                if (nudNumeroCasa.Value <= 0)
                {
                    MessageBox.Show("Informe um número do Endereço válido.");
                    tabControlAlimentos.SelectTab("tpEndereco");
                    nudNumeroCasa.Focus();
                    return;
                }

                ListaAlimento alimentos = new ListaAlimento()
                {
                    Nome = txtNomeAlimento.Text,
                    FornecedorNumeroLoja = Convert.ToInt32(nudNumeroCasa.Value),
                    FornecedorCnpj = mtbCnpj.Text,
                    FornecedorCep = mtbCep.Text,
                    Quantidade = Convert.ToInt32(nudQuantidade.Value),
                    GrupoAlimentar = cbGrupoAlimentar.Text,
                    ValorUnitario = Convert.ToDouble(txtValorUnitario.Text),
                    DataFabricacao = dtpDataDeFabricacao.Value,
                    Calorias = Convert.ToInt32(txtQuantidadeCalorias.Text),
                    FornecedorCodigo = txtCodigoFornecedor.Text

                    
                };

                int linhaposicao = dgvAlimento.CurrentRow.Index;

                if (linhaposicao == -1)
                {
                    Program.alimentos.Add(alimentos);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    Program.alimentos[linhaposicao] = alimentos;
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                LimparCamposAlimento();
                AtualizarListaAlimentos();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro!.");
                return;
            }

        }

        public void AtualizarListaAlimentos()
        {
            dgvAlimento.Rows.Clear();
            string busca = txtBuscarAlimento.Text.ToLower();
            for (int i = 0; i < Program.alimentos.Count; i++)
            {
                ListaAlimento alimento = Program.alimentos[i];
                if ((alimento.Nome.ToLower().Contains(busca)) || (alimento.FornecedorCep.Contains(busca)))
                {
                    dgvAlimento.Rows.Add(new object[]{alimento.Nome, alimento.DataFabricacao,alimento.Quantidade,alimento.CodigoBarra, alimento.FornecedorCep});
                }
            }
        }

        public void LimparCamposAlimento()
        {
            txtNomeFornecedor.Text = "";
            txtNomeAlimento.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtBuscarAlimento.Text = "";
            txtCodigoBarras.Text = "";
            txtCodigoFornecedor.Text = "";            
            txtNomeFornecedor.Text = "";
            txtQuantidadeCalorias.Text = "";
            txtUf.Text = "";
            txtValorUnitario.Text = "";
            mtbCep.Text = "";
            nudNumeroCasa.Value = 0;
            nudQuantidade.Value = 0;


        }

        public void InserirInformacoesDoAlimentoNoCadastro()
        {
            ListaAlimento alimento = Program.alimentos.Find(x =>
               x.Nome == Convert.ToString(this.dgvAlimento.CurrentRow.Cells["ColumnNome"].Value));

            this.txtNomeAlimento.Text = alimento.Nome;
            this.cbGrupoAlimentar.Text = alimento.GrupoAlimentar;
            this.mtbCep.Text = alimento.FornecedorCep;
            this.mtbCnpj.Text = alimento.FornecedorCnpj;
            this.txtCodigoBarras.Text = Convert.ToString(alimento.CodigoBarra);
            this.nudNumeroCasa.Value = alimento.FornecedorNumeroLoja; 
            this.txtNomeFornecedor.Text = alimento.FornecedorNome; 
            this.txtValorUnitario.Text = Convert.ToString(alimento.ValorUnitario);
            this.nudQuantidade.Value = alimento.Quantidade;
            this.txtQuantidadeCalorias.Text = Convert.ToString(alimento.Calorias);
            this.txtCodigoFornecedor.Text = alimento.FornecedorCodigo;
            this.nudNumeroCasa.Value = alimento.FornecedorNumeroLoja;
            
            CEP buscarcep = new CEP(mtbCep.Text);
            this.txtBairro.Text = buscarcep.bairro;
            this.txtCidade.Text = buscarcep.localidade;
            this.txtLogradouro.Text = buscarcep.logradouro;
            this.txtUf.Text = buscarcep.uf;
        }

        private void mtbCep_Leave(object sender, EventArgs e)
        {
            CEP buscarcep = new CEP(mtbCep.Text);
            this.txtBairro.Text = buscarcep.bairro;
            this.txtCidade.Text = buscarcep.localidade;
            this.txtLogradouro.Text = buscarcep.logradouro;
            this.txtUf.Text = buscarcep.uf;
        }

        private void dgvAlimento_DoubleClick(object sender, EventArgs e)
        {
            InserirInformacoesDoAlimentoNoCadastro();
            mtbCep.Focus();
        }

        private void mtbCep_TextChanged(object sender, EventArgs e)
        {
            if (((MaskedTextBox)sender).Text.Length == 9)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarListaAlimentos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvAlimento.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvAlimento.CurrentRow.Index;

            ListaAlimento alimento = Program.alimentos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + alimento.Nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.alimentos.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com sucesso!");
                AtualizarListaAlimentos();
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
            LimparCamposAlimento();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlimento.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum Alimento selecionada!");
                return;
            }

            posicao = dgvAlimento.CurrentRow.Index;
            ListaAluno listaAlunos = Program.alunos[posicao];
            InserirInformacoesDoAlimentoNoCadastro();
        }

        private void txtBuscarAlimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaAlimentos();
            }
        }
    }
}
