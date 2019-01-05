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
    public partial class ListaAlunos : Form
    {
        public ListaAlunos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new CadastrodeAluno().ShowDialog();
        }

        private void ListaAlunos_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                dataGridView1.Rows.Add(new Object[] {
                    aluno.GetCodigo(),
                    aluno.GetNome(),
                    aluno.GetIdade(),
                    aluno.GetTurma(),
                    aluno.GetTurno()
                });
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            new CadastrodeAluno(codigo).ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
