using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploSerializacao
{
    public partial class ListaPersonagem : Form
    {
        public int posicao = -1;

        public static string NOME_ARQUIVO = "Personagens.bin";

        public ListaPersonagem()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem();
            try
            {
                personagem.SetNome(txtNome.Text);
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            personagem.SetCla(cbCla.SelectedItem.ToString());
            /*try
            {
                personagem.SetCla(cbCla.SelectedItem.ToString());
                cbCla.DroppedDown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }*/

            try
            {
                personagem.SetNivelChakra(Convert.ToInt32(txtNivelChakra.Text));
                txtNivelChakra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

            PersonagemRepository tudo = new PersonagemRepository();
            if (posicao == -1)
            {
                tudo.AdicionarPersonagem(personagem);
                MessageBox.Show("Personagem cadastrado com sucesso");
            }
            else
            {
                tudo.EditarPersonagem(personagem, posicao);
                MessageBox.Show("Personagem alterado com sucesso");
            }
            LimparCampos();
            AtualizarListaPersonagens();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNivelChakra.Text = "";
            cbCla.SelectedIndex = -1;
        }

        private void ListaPersonagem_Activated(object sender, EventArgs e)
        {
            AtualizarListaPersonagens();
        }

        private void AtualizarListaPersonagens()
        {
            PersonagemRepository tudo = new PersonagemRepository();
            dataGridView1.Rows.Clear();

            /* for (int i = 0; i < tudo.ObterPersonagem().Count(); i++)
             {
                 Personagem personagem = tudo.ObterPersonagem()[i];
             }*/

            foreach (Personagem personagem in tudo.ObterPersonagem())
            {
                dataGridView1.Rows.Add(new Object[]
                {
                    personagem.GetNome(),
                    personagem.GetCla(),
                    personagem.GetNivelChakra()
                });
            }
        }

        private void ListaPersonagem_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.E || e.KeyCode == Keys.L))
            {
                ApagarPersonagem();
            }
            else if (e.KeyCode == Keys.F2)
            {
                EditarPersonagem();
            }
        }

        private void EditarPersonagem()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha22222.");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            PersonagemRepository repositorio = new PersonagemRepository();

            int quantidade = 0;
            foreach (Personagem personagem in repositorio.ObterPersonagem())
            {
                if (personagem.GetNome() == nome)
                {
                    txtNome.Text = personagem.GetNome();
                    txtNivelChakra.Text = personagem.GetNivelChakra().ToString();
                    cbCla.SelectedItem = personagem.GetCla();
                    posicao = quantidade;
                    return;
                }
                quantidade++;
            }
        }

        private void ApagarPersonagem()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo neste grid");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            PersonagemRepository repositorio = new PersonagemRepository();
            repositorio.ApagarPersonagem(nome);
            MessageBox.Show(nome + " apagado com sucesso.");
            LimparCampos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            EditarPersonagem();
        }
    }
}
