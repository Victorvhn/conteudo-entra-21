using Exercicio01.Model;
using Exercicio01.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class ListaAlunos : Form
    {
        public ListaAlunos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAluno cadastrarAluno = new CadastrarAluno();
            cadastrarAluno.ShowDialog();
        }
        
        private void AtualizarLista()
        {
            string coluna = "nome";
            if (rbColunaMatricula.Checked)
            {
                coluna = "codigo_matricula";
            }
            if (rbColunaMedia.Checked)
            {
                coluna = "(nota_1 + nota_2 + nota_3) / 3";
            }

            string tipoOrdenacao = "ASC";
            if (rbOrdenarDESC.Checked)
            {
                tipoOrdenacao = "DESC";
            }

            dgvAlunos.Rows.Clear();
            List<Aluno> alunos = new AlunoRepository().ObterAlunos(txtPesquisa.Text, coluna, tipoOrdenacao);
            foreach (Aluno aluno in alunos)
            {
                dgvAlunos.Rows.Add(new object[]
                    {
                        aluno.Id,
                        aluno.CodigoMatricula,
                        aluno.Nome,
                        aluno.Nota_1,
                        aluno.Nota_2,
                        aluno.Nota_3,
                        aluno.Media
                    });
            }
        }

        private void ListaAlunos_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void ListaAlunos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbColunaNome_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbColunaMatricula_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbColunaMedia_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbOrdenarASC_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbOrdenarDESC_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            AtualizarLista();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha para apagar");
                return;
            }

            int linhaSelecionada = dgvAlunos.CurrentRow.Index;
            int codigo = Convert.ToInt32(dgvAlunos.Rows[linhaSelecionada].Cells[0].Value);
            string nome = dgvAlunos.Rows[linhaSelecionada].Cells[2].Value.ToString();

            DialogResult result = MessageBox.Show("Deseja realmente apagar o registro " + nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool apagado = new AlunoRepository().Apagar(codigo);
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Registro não apagado");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvAlunos.CurrentRow.Index;
            int codigo = Convert.ToInt32(dgvAlunos.Rows[linhaSelecionada].Cells[0].Value.ToString());
            new CadastrarAluno(codigo).ShowDialog();
        }
    }
}
