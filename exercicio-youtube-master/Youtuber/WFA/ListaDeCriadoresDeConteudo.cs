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
    public partial class ListaDeCriadoresDeConteudo : Form
    {
        public static string NOME_ARQUIVO = "Youtubers.bin";

        public ListaDeCriadoresDeConteudo()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastroCriadorConteudo cadastroCriadorConteudo = new CadastroCriadorConteudo();
            cadastroCriadorConteudo.ShowDialog();
        }

        private void ListaDeCriadoresDeConteudo_Activated(object sender, EventArgs e)
        {
            AtualizarListaYoutubers();
            ContadorLbl();
        }

        private void AtualizarListaYoutubers()
        {
            YoutuberRepository tudo = new YoutuberRepository();
            dgvListaYoutubers.Rows.Clear();

            string busca = txtBuscar.Text.ToLower();

            foreach (Youtuber youtuber in tudo.ObterYoutuber())
            {
                if ((youtuber.GetNome().ToLower().Contains(busca)) || (youtuber.GetCodigo().ToString().Contains(busca)) || (youtuber.GetNomeCanal().ToLower().Contains(busca)) || (youtuber.GetNacionalidade().ToLower().Contains(busca)))
                {

                    dgvListaYoutubers.Rows.Add(new Object[]
                {
                    youtuber.GetCodigo(),
                    youtuber.GetNome(),
                    youtuber.GetNomeCanal(),
                    youtuber.GetQuantidadeInscritos(),
                    youtuber.GetNacionalidade()
                });
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvListaYoutubers.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            string nome = dgvListaYoutubers.Rows[dgvListaYoutubers.CurrentRow.Index].Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + nome + "?", "AVISO", MessageBoxButtons.YesNo);            

            if (resultado == DialogResult.Yes)
            {
                ApagarYoutuber();             
            }
            else
            {
                MessageBox.Show(nome + " não apagado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarYoutuber();
        }

        private void EditarYoutuber()
        {
            if (dgvListaYoutubers.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            int codigoRegistro = Convert.ToInt32(dgvListaYoutubers.Rows[dgvListaYoutubers.CurrentRow.Index].Cells[0].Value.ToString());

            new CadastroCriadorConteudo(codigoRegistro).ShowDialog();
        }

        private void ApagarYoutuber()
        {
            int codigo = Convert.ToInt32(dgvListaYoutubers.Rows[dgvListaYoutubers.CurrentRow.Index].Cells[0].Value.ToString());
            string nome2 = dgvListaYoutubers.Rows[dgvListaYoutubers.CurrentRow.Index].Cells[1].Value.ToString();
            dgvListaYoutubers.Rows.RemoveAt(dgvListaYoutubers.CurrentRow.Index);
            YoutuberRepository repositorio = new YoutuberRepository();
            repositorio.ApagarYoutuber(codigo);
            MessageBox.Show(nome2 + " apagado com sucesso.");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvListaYoutubers.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            int linhaSelecionada = Convert.ToInt32(dgvListaYoutubers.Rows[dgvListaYoutubers.CurrentRow.Index].Cells[0].Value.ToString());

            new ApresentaInformacoes(linhaSelecionada).ShowDialog();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaYoutubers();
            }
        }        

        private void ContadorLbl()
        {
            lblContador.Text = dgvListaYoutubers.Rows.Count.ToString();
        }
    }
}

