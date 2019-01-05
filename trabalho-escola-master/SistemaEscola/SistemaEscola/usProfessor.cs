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
    public partial class usProfessor : UserControl
    {
        public usProfessor()
        {
            InitializeComponent();
            AtualizarListaProfessores();
        }

        private int posicao = -1;

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome do professor deve conter no mínimo 4 caracteres. Digite o nome completo.");
                tabControlProfessores.SelectTab("tpProfessor");
                txtNome.Focus();
                return;
            }

            if (cbSexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o sexo do professor.");
                tabControlProfessores.SelectTab("tpProfessor");
                cbSexo.DroppedDown = true;
                return;
            }

            if (cbNacionalidade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a nacionalidade do professor.");
                tabControlProfessores.SelectTab("tpProfessor");
                cbNacionalidade.DroppedDown = true;
                return;
            }

            if (!Tools.ValidaCEP(mtbCep.Text))
            {
                MessageBox.Show("CPF inválido.");
                tabControlProfessores.SelectTab("tpProfessor");
                mtbCpf.Focus();
                return;
            }

            if (txtRg.Text.Length < 6)
            {
                MessageBox.Show("Informe um RG válido.");
                tabControlProfessores.SelectTab("tpProfessor");
                txtRg.Focus();
                return;
            }

            if (dtpDataNascimento.Value > DateTime.Now) // TODO: Falta Colocar idade minima
            {
                MessageBox.Show("Data de nascimento deve ser hoje ou uma data anterior.");
                tabControlProfessores.SelectTab("tpProfessor");
                dtpDataNascimento.Focus();
                return;
            }

            if (cbTurno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um turno.");
                tabControlProfessores.SelectTab("tpProfessor");
                cbTurno.DroppedDown = true;
                return;
            }

            if (cbEspecialidade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma especialidade");
                tabControlProfessores.SelectTab("tpProfessor");
                cbEspecialidade.DroppedDown = true;
                return;
            }

            if (txtAgencia.Text.Length < 2)
            {
                MessageBox.Show("Infome um número de agencia válido");
                tabControlProfessores.SelectTab("tpProfessor");
                txtAgencia.Focus();
                return;
            }
            try
            {
                Convert.ToInt32(txtAgencia.Text);
            }
            catch
            {
                MessageBox.Show("Infome um número de agencia válido");
                tabControlProfessores.SelectTab("tpProfessor");
                txtAgencia.Focus();
                return;
            }

            if (txtConta.Text.Length < 5)
            {
                MessageBox.Show("Infome um número de conta válido");
                tabControlProfessores.SelectTab("tpProfessor");
                txtConta.Focus();
                return;
            }
            try
            {
                Convert.ToInt32(txtConta.Text);
            }
            catch
            {
                MessageBox.Show("Infome um número de conta válido");
                tabControlProfessores.SelectTab("tpProfessor");
                txtConta.Focus();
                return;
            }

            if (mtbCep.Text.Replace("-", "").Length != 8)
            {
                MessageBox.Show("Preencha o cep.");
                tabControlProfessores.SelectTab("tbEndereco");
                mtbCep.Focus();
                return;
            }

            if (nudNumeroCasa.Value <= 0)
            {
                MessageBox.Show("Informe um de número da casa válido.");
                tabControlProfessores.SelectTab("tbEndereco");
                nudNumeroCasa.Focus();
                return;
            }

            if (txtEmail.Text.Length < 7)
            {
                MessageBox.Show("Informe um e-mail válido.");
                tabControlProfessores.SelectTab("tbEndereco");
                txtEmail.Focus();
                return;
            }

            ListaProfessor professor = new ListaProfessor()
            {
                Nome = txtNome.Text,
                Sexo = cbSexo.SelectedItem.ToString(),
                Nacionalidade = cbNacionalidade.SelectedItem.ToString(),
                Cpf = mtbCpf.Text,
                Rg = txtRg.Text,
                Turno = cbTurno.SelectedItem.ToString(),
                Especialidade = cbEspecialidade.SelectedItem.ToString(),
                DataNascimento = dtpDataNascimento.Value,
                NumeroAgenciaContaSalario = Convert.ToInt32(txtAgencia.Text),
                NumeroContaSalario = Convert.ToInt32(txtConta.Text),
                CEP = mtbCep.Text,
                NumeroCasa = Convert.ToInt32(nudNumeroCasa.Value),
                Email = txtEmail.Text,
                Complemento = txtComplemento.Text
            };

            int linhaposicao = dgvProfessores.CurrentRow.Index;

            if (linhaposicao == -1)
            {
                Program.professores.Add(professor);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                Program.professores[linhaposicao] = professor;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }

           
            LimparCamposProfessor();
            AtualizarListaProfessores();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
                return;
            }
        }

        public void LimparCamposProfessor()
        {
            txtNome.Text = "";
            cbSexo.SelectedIndex = -1;
            mtbCpf.Text = "";
            txtRg.Text = "";
            cbTurno.SelectedIndex = -1;
            cbNacionalidade.SelectedIndex = -1;
            dtpDataNascimento.Value = DateTime.Now;
            cbEspecialidade.SelectedIndex = -1;
            txtConta.Text = "";
            txtAgencia.Text = "";
            mtbCep.Text = "";
            txtUf.Text = "";
            nudNumeroCasa.Value = 0;
            txtEmail.Text = "";
            txtLogradouro.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
        }

        public void AtualizarListaProfessores()
        {
            dgvProfessores.Rows.Clear();
            string busca = txtBuscarProfessor.Text.ToLower();
            for (int i = 0; i < Program.professores.Count; i++)
            {
                ListaProfessor professor = Program.professores[i];
                if ((professor.Nome.ToLower().Contains(busca)) || (professor.Cpf.ToLower().Contains(busca)) || (professor.Sexo.ToLower().Contains(busca)) || (professor.Turno.ToLower().Contains(busca)))
                {
                    dgvProfessores.Rows.Add(new object[]{
                        professor.Nome, professor.Sexo, professor.Cpf, professor.Turno, professor.Especialidade
                    });
                }
            }
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {            
            if (dgvProfessores.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma professor selecionada!");
                return;
            }

            posicao = dgvProfessores.CurrentRow.Index;
            ListaProfessor listaProfessor = Program.professores[posicao];
            InserirInformacoesDoProfessorNoCadastro();
        }

        public void dgvProfessores_DoubleClick(object sender, EventArgs e)
        {
            InserirInformacoesDoProfessorNoCadastro();
            mtbCep.Focus();
        }

        public void InserirInformacoesDoProfessorNoCadastro()
        {
            ListaProfessor professor = Program.professores.Find(x =>
                x.Nome == Convert.ToString(this.dgvProfessores.CurrentRow.Cells["ColumnNome"].Value));

            this.txtNome.Text = professor.Nome;
            this.cbSexo.Text = professor.Sexo;
            this.mtbCpf.Text = professor.Cpf;
            this.cbTurno.Text = professor.Turno;
            this.cbNacionalidade.Text = professor.Nacionalidade;
            this.txtRg.Text = professor.Rg;
            this.txtAgencia.Text = professor.NumeroAgenciaContaSalario.ToString();
            this.txtConta.Text = professor.NumeroContaSalario.ToString();
            this.cbEspecialidade.Text = professor.Especialidade;
            this.mtbCep.Text = professor.CEP;
            this.nudNumeroCasa.Value = professor.NumeroCasa;
            this.txtEmail.Text = professor.Email;
            this.txtComplemento.Text = professor.Complemento;
        }

        public void txtBuscarProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaProfessores();
            }
        }

        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarListaProfessores();
        }

        public void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvProfessores.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvProfessores.CurrentRow.Index;

            ListaProfessor professor = Program.professores[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + professor.Nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.professores.RemoveAt(linhaSelecionada);
                AtualizarListaProfessores();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void mtbCep_Leave(object sender, EventArgs e)
        {
            CEP buscarcep = new CEP(mtbCep.Text);
            this.txtBairro.Text = buscarcep.bairro;
            this.txtCidade.Text = buscarcep.localidade;
            this.txtLogradouro.Text = buscarcep.logradouro;
            this.txtUf.Text = buscarcep.uf;
        }

        private void mtbCep_TextChanged(object sender, EventArgs e)
        {
            if (((MaskedTextBox)sender).Text.Length == 9)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
