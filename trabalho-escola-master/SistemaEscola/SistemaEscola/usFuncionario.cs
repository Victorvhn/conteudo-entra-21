using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: Editar nao funciona
namespace SistemaEscola
{
    public partial class usFuncionario : UserControl
    {
        public usFuncionario()
        {
            InitializeComponent();
            AtualizarListaFuncionario();
        }

        private int posicao = -1;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome do Funcionario deve conter no mínimo 4 caracteres. Digite o nome completo.");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                txtNome.Focus();
                return;
            }

            if (cbSexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o sexo do Funcionario.");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                cbSexo.DroppedDown = true;
                return;
            }

            if (cbNacionalidade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a nacionalidade do Funcionario.");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                cbNacionalidade.DroppedDown = true;
                return;
            }

            if (!Tools.validarCPF(mtbCpf.Text))
            {
                MessageBox.Show("CPF inválido.");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                mtbCpf.Focus();
                return;
            }

            if (txtRg.Text.Length < 6)
            {
                MessageBox.Show("Informe um RG válido.");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                txtRg.Focus();
                return;
            }

            if (dtpDataNascimento.Value > DateTime.Now) // TODO: Falta Colocar idade minima
            {
                MessageBox.Show("Data de nascimento deve ser hoje ou uma data anterior.");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                dtpDataNascimento.Focus();
                return;
            }

            if (cbTurno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um turno.");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                cbTurno.DroppedDown = true;
                return;
            }

            if (cbCargo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma especialidade");
                tabControlFuncionarios.SelectTab("tpFuncionario");
                cbCargo.DroppedDown = true;
                return;
            }

            if (txtAgencia.Text.Length < 2)
            {
                MessageBox.Show("Infome um número de agencia válido");
                tabControlFuncionarios.SelectTab("tpFuncionario");
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
                tabControlFuncionarios.SelectTab("tpFuncionario");
                txtAgencia.Focus();
                return;
            }

            if (txtConta.Text.Length < 5)
            {
                MessageBox.Show("Infome um número de conta válido");
                tabControlFuncionarios.SelectTab("tpFuncionario");
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
                tabControlFuncionarios.SelectTab("tpFuncionario");
                txtConta.Focus();
                return;
            }

            if (!Tools.ValidaCEP(mtbCep.Text))
            {
                MessageBox.Show("CEP inválido.");
                tabControlFuncionarios.SelectTab("tpEndereco");
                mtbCep.Focus();
                return;
            }

            if (nudNumeroCasa.Value == 0)
            {
                MessageBox.Show("Informe um de número da casa válido.");
                tabControlFuncionarios.SelectTab("tpEndereco");
                nudNumeroCasa.Focus();
                return;
            }

            if (!Tools.ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Informe um e-mail válido.");
                tabControlFuncionarios.SelectTab("tpEndereco");
                txtEmail.Focus();
                return;
            }
            ListaFuncionario funcionario = new ListaFuncionario()
            {
                Nome = txtNome.Text,
                Sexo = cbSexo.SelectedItem.ToString(),
                Nacionalidade = cbNacionalidade.SelectedItem.ToString(),
                CPF = mtbCpf.Text,
                RG = txtRg.Text,
                Turno = cbTurno.SelectedItem.ToString(),
                Cargo = cbCargo.SelectedItem.ToString(),
                DataNascimento = dtpDataNascimento.Value,
                AgenciaContaSalario = Convert.ToInt32(txtAgencia.Text),
                ContaSalario = Convert.ToInt32(txtConta.Text),
                CEP = mtbCep.Text,
                //NumeroCasa = Convert.ToInt32(nudNumeroCasa.Value),
                Email = txtEmail.Text,
                //Complemento = txtComplemento.Text

            };

            int linhaposicao = dgvFuncionario.CurrentRow.Index;

                if (linhaposicao == -1)
                {
                    Program.funcionarios.Add(funcionario);
                    MessageBox.Show("Cadastro realizado com sucesso!"); 
                }
                else 
                {
                    Program.funcionarios[linhaposicao] = funcionario;
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }

               AtualizarListaFuncionario();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
                return;
            }
         
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum funcionário selecionada!");
                return;
            }

            posicao = dgvFuncionario.CurrentRow.Index;
            ListaFuncionario listaFuncionarios = Program.funcionarios[posicao];
            InserirInformacoesDoFuncionarioNoCadastro();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarListaFuncionario();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvFuncionario.CurrentRow.Index;

            ListaFuncionario funcionario = Program.funcionarios[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + funcionario.Nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.funcionarios.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com sucesso!");
                AtualizarListaFuncionario();
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            InserirInformacoesDoFuncionarioNoCadastro();
        }

        public void LimparCamposFuncionario()
        {
            txtNome.Text = "";
            cbSexo.SelectedIndex = -1;
            mtbCpf.Text = "";
            txtRg.Text = "";
            cbTurno.SelectedIndex = -1;
            cbNacionalidade.SelectedIndex = -1;
            dtpDataNascimento.Value = DateTime.Now;
            cbCargo.SelectedIndex = -1;
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

        public void AtualizarListaFuncionario()
        {
            dgvFuncionario.Rows.Clear();
            string busca = txtBuscarFuncionario.Text.ToLower();
            for (int i = 0; i < Program.professores.Count; i++)
            {
                ListaFuncionario funcionario = Program.funcionarios[i];
                if ((funcionario.Nome.ToLower().Contains(busca)) || (funcionario.CEP.Contains(busca)) || (funcionario.Sexo.ToLower().Contains(busca)) || (funcionario.Turno.ToLower().Contains(busca)))
                {
                    dgvFuncionario.Rows.Add(new object[]{
                        funcionario.Nome, funcionario.Sexo, funcionario.CEP, funcionario.Turno, funcionario.Cargo
                    });
                }
            }
        }

        private void txtBuscarFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaFuncionario();
            }
        }


        public void InserirInformacoesDoFuncionarioNoCadastro()
        {
            ListaFuncionario funcionario = Program.funcionarios.Find(x =>
                x.Nome == Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["ColumnNomeFuncionario"].Value));

            this.txtNome.Text = funcionario.Nome;
            this.cbSexo.Text = funcionario.Sexo;
            this.mtbCpf.Text = funcionario.CPF;
            this.cbTurno.Text = funcionario.Turno;
            this.cbNacionalidade.Text = funcionario.Nacionalidade;
            this.txtRg.Text = funcionario.RG;
            this.txtAgencia.Text = funcionario.AgenciaContaSalario.ToString();
            this.txtConta.Text = funcionario.ContaSalario.ToString();
            this.cbCargo.Text = funcionario.Cargo;
            this.mtbCep.Text = funcionario.CEP;
            this.nudNumeroCasa.Value = funcionario.NumeroCasa;
            this.txtEmail.Text = funcionario.Email;
            //this.txtComplemento.Text = funcionario.Complemento;

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
    }
}
