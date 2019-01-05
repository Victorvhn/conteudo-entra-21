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
    public partial class usEquipamento : UserControl
    {
        public usEquipamento()
        {
            InitializeComponent();
            AtualizarListaEquipamentos();
        }

        int posicaoEquipamento = -1;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtNome.Text.Length < 4)
                {
                    MessageBox.Show("Nome do equipamento deve conter no mínimo 4 caracteres.");
                    txtNome.Focus();
                    return;
                }

                if (cbMarca.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione uma marca.");
                    cbMarca.DroppedDown = true;
                    return;
                }

                if (nudQuantidade.Value <= 0)
                {
                    MessageBox.Show("Quantidade deve ser maior que 0.");
                    nudQuantidade.Focus();
                    return;
                }

                if (dtpDataDeEntrada.Value > DateTime.Now)
                {
                    MessageBox.Show("Data de entrada deve ser hoje ou uma data anterior.");
                    dtpDataDeEntrada.Focus();
                    return;
                }

                if (cbSetor.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione um setor.");
                    cbSetor.DroppedDown = true;
                    return;
                }

                ListaEquipamento equipamento = new ListaEquipamento()
                {
                    Nome = txtNome.Text,
                    Marca = cbMarca.SelectedItem.ToString(),
                    Quantidade = Convert.ToInt32(nudQuantidade.Value),
                    DataEntrada = dtpDataDeEntrada.Value,
                    Setor = cbSetor.SelectedItem.ToString()
                };

                int linhaposicao = dgvEquipamento.CurrentRow.Index;

                if (linhaposicao == -1)
                {
                    Program.equipamentos.Add(equipamento);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    Program.equipamentos[linhaposicao] = equipamento;
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                LimparCamposEquipamento();
                AtualizarListaEquipamentos();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
                return;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEquipamento.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            posicaoEquipamento = dgvEquipamento.CurrentRow.Index;
            ListaEquipamento listaEquipamento = Program.equipamentos[posicaoEquipamento];
            InserirInformacoesDoEquipamentoNoCadastro();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarListaEquipamentos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvEquipamento.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvEquipamento.CurrentRow.Index;

            ListaAluno aluno = Program.alunos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + aluno.Nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.alunos.RemoveAt(linhaSelecionada);
                AtualizarListaEquipamentos();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void dgvEquipamento_DoubleClick(object sender, EventArgs e)
        {
            InserirInformacoesDoEquipamentoNoCadastro();
        }

        private void txtBuscarEquipamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaEquipamentos();
            }
        }

        public void AtualizarListaEquipamentos()
        {
            dgvEquipamento.Rows.Clear();
            string busca = txtBuscarEquipamento.Text.ToLower();
            for (int i = 0; i < Program.equipamentos.Count; i++)
            {
                ListaEquipamento equipamento = Program.equipamentos[i];
                if ((equipamento.Nome.ToLower().Contains(busca)) || (equipamento.Marca.ToLower().Contains(busca)) || (equipamento.Setor.ToLower().Contains(busca)))
                {
                    dgvEquipamento.Rows.Add(new object[]{
                    equipamento.Nome, equipamento.Setor, equipamento.Quantidade, equipamento.DataEntrada
                });
                }
            }
        }

        private void LimparCamposEquipamento()
        {
            txtNome.Text = "";
            cbMarca.SelectedIndex = -1;
            nudQuantidade.Value = 0;
            dtpDataDeEntrada.Value = DateTime.Now;
            cbSetor.SelectedIndex = -1;
        }

        public void InserirInformacoesDoEquipamentoNoCadastro()
        {
            ListaEquipamento equipamento = Program.equipamentos.Find(x =>
                x.Nome == Convert.ToString(this.dgvEquipamento.CurrentRow.Cells["ColumnNomeEquipamento"].Value));

            this.txtNome.Text = equipamento.Nome;
            this.cbMarca.Text = equipamento.Marca;
            this.cbSetor.Text = equipamento.Setor;
            this.dtpDataDeEntrada.Value = dtpDataDeEntrada.Value;
            this.nudQuantidade.Value = equipamento.Quantidade;
        }
    }
}
