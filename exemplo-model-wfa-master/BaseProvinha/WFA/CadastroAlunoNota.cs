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
    public partial class CadastroAlunoNota : Form
    {
        private Aluno aluno;

        public CadastroAlunoNota(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarNota();
        }

        private void CadastrarNota()
        {
            try
            {
                double nota = Convert.ToDouble(txtNota.Text);
                aluno.AdicionarNota(nota);
                this.DialogResult = DialogResult.OK;
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void txtNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNota();
            }
        }
    }
}
