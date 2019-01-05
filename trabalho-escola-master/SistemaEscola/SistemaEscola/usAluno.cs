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
    public partial class usAluno : UserControl
    {
        public usAluno()
        {
            InitializeComponent();
            AtualizarListaAlunos();

        }
        private int posicao = -1;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtNomeAluno.Text.Length < 4)
                {
                    MessageBox.Show("Nome do Aluno deve conter no mínimo 4 caracteres. Digite o nome completo.");
                    tabControlAlunos.SelectTab("tpAluno");
                    txtNomeAluno.Focus();
                    return;
                }

                if (cbSexoAluno.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione o sexo do aluno.");
                    tabControlAlunos.SelectTab("tpAluno");
                    cbSexoAluno.DroppedDown = true;
                    return;
                }

                if (cbNacionalidadeAluno.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione a nacionalidade do aluno.");
                    tabControlAlunos.SelectTab("tpAluno");
                    cbNacionalidadeAluno.DroppedDown = true;
                    return;
                }

                if (!Tools.validarCPF(mtbCpfAluno.Text))
                {
                    MessageBox.Show("CPF inválido.");
                    tabControlAlunos.SelectTab("tpAluno");
                    mtbCpfAluno.Focus();
                    return;
                }

                if (txtRgAluno.Text.Length < 6)
                {
                    MessageBox.Show("Informe um RG válido.");
                    tabControlAlunos.SelectTab("tpAluno");
                    txtRgAluno.Focus();
                    return;
                }

                if (dtpDataNascimentoAluno.Value > DateTime.Now) // TODO: Falta Colocar idade minima
                {
                    MessageBox.Show("Data de nascimento deve ser hoje ou uma data anterior.");
                    tabControlAlunos.SelectTab("tpAluno");
                    dtpDataNascimentoAluno.Focus();
                    return;
                }

                if (cbTurno.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione um turno.");
                    tabControlAlunos.SelectTab("tpAluno");
                    cbTurno.DroppedDown = true;
                    return;
                }

                if (cbTurma.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione uma Turma");
                    tabControlAlunos.SelectTab("tpAluno");
                    cbTurma.DroppedDown = true;
                    return;
                }

                if (!Tools.ValidaCEP(mtbCep.Text))
                {
                    MessageBox.Show("CEP inválido.");
                    tabControlAlunos.SelectTab("tpEndereco");
                    mtbCep.Focus();
                    return;
                }

                if (nudNumeroCasa.Value <= 0)
                {
                    MessageBox.Show("Informe um de número da casa válido.");
                    tabControlAlunos.SelectTab("tpEndereco");
                    nudNumeroCasa.Focus();
                    return;
                }

                ListaAluno alunos = new ListaAluno()
                {
                    Nome = txtNomeAluno.Text,
                    Sexo = cbSexoAluno.SelectedItem.ToString(),
                    Nacionalidade = cbNacionalidadeAluno.SelectedItem.ToString(),
                    CPF = mtbCpfAluno.Text,
                    RG = txtRgAluno.Text,
                    Turno = cbTurno.SelectedItem.ToString(),
                    Turma = cbTurma.SelectedItem.ToString(),
                    Nascimento = dtpDataNascimentoAluno.Value,
                    Cep = mtbCep.Text,
                    NumeroCasa = Convert.ToInt32(nudNumeroCasa.Value),
                    Complemento = txtComplemento.Text
                };

                int linhaposicao = dgvAluno.CurrentRow.Index;

                if (linhaposicao == -1)
                {
                    Program.alunos.Add(alunos);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    Program.alunos[linhaposicao] = alunos;
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                LimparCamposAluno();
                AtualizarListaAlunos();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
                return;
            }

        }

        public void LimparCamposAluno()
        {
            txtNomeAluno.Text = "";
            cbSexoAluno.Text = "";
            mtbCpfAluno.Text = "";
            cbTurno.Text = "";
            cbNacionalidadeAluno.SelectedIndex = -1;
            txtRgAluno.Text = "";
            cbTurma.SelectedIndex = 0;
            mtbCep.Text = "";
            nudNumeroCasa.Value = 0;
            txtComplemento.Text = "";
            txtMatriculaAluno.Text = "";
            cbTurma.SelectedIndex = 0;
            cbSexoResponsavel.SelectedIndex = 0;
            txtRgResponsavel.Text = "";
            mtbCpfResponsavel.Text = "";
            txtNomeResponsavel.Text = "";
            mtbTelefone.Text = "";
            txtBairo.Text = "";
            txtCidade.Text = "";
            txtLogradouro.Text = "";
            txtUf.Text = "";
        }

        public void AtualizarListaAlunos()
        {
            dgvAluno.Rows.Clear();
            string busca = txtBuscarAluno.Text.ToLower();
            for (int i = 0; i < Program.alunos.Count; i++)
            {
                ListaAluno alunos = Program.alunos[i];
                if ((alunos.Nome.ToLower().Contains(busca)) || (alunos.Cep.ToLower().Contains(busca)) || (alunos.Sexo.ToLower().Contains(busca)) || (alunos.Turma.ToLower().Contains(busca)))
                {
                    dgvAluno.Rows.Add(new object[]{
                        alunos.Nome, alunos.Sexo, alunos.Cep, alunos.Turno, alunos.Turma
                    });
                }
            }
        }

        public void InserirInformacoesDoAlunoNoCadastro()
        {
            ListaAluno aluno = Program.alunos.Find(x =>
                x.Nome == Convert.ToString(this.dgvAluno.CurrentRow.Cells["ColumnNomeAluno"].Value));


            this.txtNomeAluno.Text = aluno.Nome;
            this.cbSexoAluno.Text = aluno.Sexo;
            this.mtbCpfAluno.Text = aluno.CPF;
            this.cbTurno.Text = aluno.Turno;
            this.cbNacionalidadeAluno.Text = aluno.Nacionalidade;
            this.txtRgAluno.Text = aluno.RG;
            this.cbTurma.Text = aluno.Turma;
            this.mtbCep.Text = aluno.Cep;
            this.nudNumeroCasa.Value = aluno.NumeroCasa;
            this.txtComplemento.Text = aluno.Complemento;
            this.txtMatriculaAluno.Text = aluno.NumeroMatricula;
            this.cbTurma.Text = aluno.Turma;
            this.cbSexoResponsavel.Text = aluno.SexoResponsavel;
            this.txtRgResponsavel.Text = aluno.RGResponsavel;
            this.mtbCpfResponsavel.Text = aluno.CPFResponsavel;
            this.txtNomeResponsavel.Text = aluno.NomeResponsavel;
            this.mtbTelefone.Text = aluno.TelefoneResponsavel;
            this.cbNacionalidadeResponsavel.Text = aluno.Nacionalidade;

            CEP buscarcep = new CEP(mtbCep.Text);
            this.txtBairo.Text = buscarcep.bairro;
            this.txtCidade.Text = buscarcep.localidade;
            this.txtLogradouro.Text = buscarcep.logradouro;
            this.txtUf.Text = buscarcep.uf;
        }

        private void mtbCep_Leave(object sender, EventArgs e)
        {
            CEP buscarcep = new CEP(mtbCep.Text);
            this.txtBairo.Text = buscarcep.bairro;
            this.txtCidade.Text = buscarcep.localidade;
            this.txtLogradouro.Text = buscarcep.logradouro;
            this.txtUf.Text = buscarcep.uf;
        }

        private void dgvAluno_DoubleClick(object sender, EventArgs e)
        {
            InserirInformacoesDoAlunoNoCadastro();
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
            AtualizarListaAlunos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvAluno.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvAluno.CurrentRow.Index;

            ListaAluno alunos = Program.alunos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + alunos.Nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.alunos.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com sucesso!");
                AtualizarListaAlunos();
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
            LimparCamposAluno();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAluno.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum aluno selecionada!");
                return;
            }

            posicao = dgvAluno.CurrentRow.Index;
            ListaAluno listaAlunos = Program.alunos[posicao];
            InserirInformacoesDoAlunoNoCadastro();
        }

        private void txtBuscarAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaAlunos();
            }
        }

    }
}
