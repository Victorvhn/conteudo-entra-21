using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDados01
{
    public partial class formCores : Form
    {
        private string caminhoConexao = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104958\Documents\ExemploBancoDados01.mdf;Integrated Security=True;Connect Timeout=30"; // VARIAVEL USADA NO SQLCONNECTION, BOTAO DIREITO BANCO DE DADOS, CONNECTION STRING copia e cola

        public formCores()
        {
            InitializeComponent();
            AtualizarRichTextBox();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCor();
            AtualizarRichTextBox();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarRichTextBox();
        }

        private void txtCor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarCor();
                AtualizarRichTextBox();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarCor();
            AtualizarRichTextBox();
        }

        private void cbCorApagar_DropDown(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();

            SqlCommand command = new SqlCommand("SELECT nome FROM cores ORDER BY nome", conexao);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            cbCorApagar.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbCorApagar.Items.Add(table.Rows[i][0].ToString());
            }

            conexao.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            EditarCor();
            AtualizarRichTextBox();
        }


        private void CadastrarCor()
        {
            SqlConnection sqlConnection = new SqlConnection(caminhoConexao); // USADO PARA FAZER CONEXAO C# E BANCO DE DADOS
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "INSERT INTO cores VALUES (@NOME)";

            string corDigitada = txtCor.Text;
            command.Parameters.AddWithValue("@NOME", corDigitada);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            txtCor.Text = "";
        }

        private void AtualizarRichTextBox()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = caminhoConexao;
            conexao.Open();
            SqlCommand comando = new SqlCommand("SELECT nome FROM cores;");
            comando.Connection = conexao;

            // CRIA EM MEMÓRIA UMA TABLEA
            DataTable dataTable = new DataTable();
            // EXECUTA O COMANDO E RETORNA UM SQLDataReader
            // Load - DEFINE PARA A TABELA EM MEMÓRIA AS COLUNAS E REGISTROS(RETORNANDOS DO SELECT) PARA PODER TRABALHAR COM ELAS DEPOIS
            dataTable.Load(comando.ExecuteReader());

            StringBuilder sb = new StringBuilder();
            // PERCORRE OS REGISTROS DA TABELA EM MEMÓRIA
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // OBTÉM O CONTEÚDO DE UMA LINHA.
                // DA PRIMEIRA COLUNA DO SQL
                string cor = dataTable.Rows[i][0].ToString();
                sb.AppendLine(cor);
            }
            richTextBox1.Clear();
            richTextBox1.AppendText(sb.ToString());
            conexao.Close();
        }

        private void ApagarCor()
        {
            SqlConnection connection = new SqlConnection(caminhoConexao);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM cores WHERE nome = @NOMEDACOR";
            string corParaApagar = cbCorApagar.SelectedItem.ToString();
            command.Parameters.AddWithValue("@NOMEDACOR", corParaApagar);
            command.ExecuteNonQuery();
            cbCorApagar.SelectedIndex = -1;
            connection.Close();
            txtNovoNome.Text = "";
        }

        private void EditarCor()
        {
            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE cores SET nome = @NOVONOME WHERE nome = @ANTIGONOME";

            string novoNome = txtNovoNome.Text;
            string antigoNome = cbCorApagar.SelectedItem.ToString();

            comando.Parameters.AddWithValue("@NOVONOME", novoNome);
            comando.Parameters.AddWithValue("@ANTIGONOME", antigoNome);
            comando.ExecuteNonQuery();

            cbCorApagar.SelectedIndex = -1;
            txtNovoNome.Clear();

            conexao.Close();
        }

        private void cbCorApagar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCorApagar.SelectedIndex != -1)
            {
                txtNovoNome.Text = cbCorApagar.SelectedItem.ToString();
            }
        }

       /* private void AtivarEditarApagar()
        {
            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();

            SqlCommand comando = new SqlCommand();

            conexao.Close();
        }*/

    }
}
