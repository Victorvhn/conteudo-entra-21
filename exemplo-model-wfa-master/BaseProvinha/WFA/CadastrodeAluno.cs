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
    public partial class CadastrodeAluno : Form
    {
        private Aluno aluno;
        private int codigo;

        public CadastrodeAluno()
        {
            InitializeComponent();
        }

        public CadastrodeAluno(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                if (aluno.GetCodigo() == codigo)
                {
                    txtNome.Text = aluno.GetNome();
                    txtIdade.Text = aluno.GetIdade().ToString();
                    txtTurma.Text = aluno.GetTurma();
                    txtTurno.Text = aluno.GetTurno();
                    txtMatricula.Text = aluno.GetMatricula().ToString();
                    this.aluno = aluno;
                    btnAdicionar.Enabled = true;
                    btnApagar.Enabled = true;
                    btnSalvar.Enabled = true;
                    AtualizarDataGridViewDasNotas();
                    return;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarAluno();
        }

        private void SalvarAluno()
        {
            try
            {
                bool novo = aluno == null;
                if (aluno == null)
                {
                    aluno = new Aluno();
                }
                aluno.SetMatricula(Convert.ToInt32(txtMatricula.Text));
                aluno.SetNome(txtNome.Text);
                aluno.SetIdade(Convert.ToInt32(txtIdade.Text));
                aluno.SetTurno(txtTurno.Text);
                aluno.SetTurma(txtTurma.Text);

                if (novo)
                {
                    Program.alunos.Add(aluno);
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    for (int i = 0; i < Program.alunos.Count(); i++)
                    {
                        Aluno alunoAux = Program.alunos[i];
                        if (aluno.GetCodigo() == alunoAux.GetCodigo())
                        {
                            Program.alunos[i] = aluno;
                            MessageBox.Show("Cadastro alterado com sucesso");
                            return;
                        }
                    }
                }
                btnAdicionar.Enabled = true;
                btnApagar.Enabled = true;
                btnEditar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ChamarCadastroNota();
        }

        private void ChamarCadastroNota()
        {
            DialogResult dialogResult = new CadastroAlunoNota(aluno).ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AtualizarDataGridViewDasNotas();
                MessageBox.Show("Nota cadastrada com sucesso");
            }
        }

        private void AtualizarDataGridViewDasNotas()
        {
            dgvNotas.Rows.Clear();
            for (int i = 0; i < aluno.GetNotas().Count(); i++)
            {
                double nota = aluno.GetNotas()[i];
                dgvNotas.Rows.Add(new Object[] { nota });
            }
        }

        private void CadastrodeAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && aluno != null)
            {
                ChamarCadastroNota();
            }
        }

        private void txtTurma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SalvarAluno();
            }
        }

        private void txtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIdade.Focus();
            }
        }

        private void txtIdade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTurno.Focus();
            }
        }

        private void txtTurno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTurma.Focus();
            }
        }
    }
}
