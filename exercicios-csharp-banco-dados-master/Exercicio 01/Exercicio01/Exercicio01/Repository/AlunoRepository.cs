using Exercicio01.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Repository
{
    class AlunoRepository
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104958\Documents\Exercicios.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;

        public AlunoRepository()
        {
            connection = new SqlConnection(connectionString);
        }

        public int Inserir(Aluno aluno)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO alunos(nome, codigo_matricula, nota_1, nota_2, nota_3, frequencia)
            OUTPUT INSERTED.ID
            VALUES(@NOME, @CODIGO_MATRICULA, @NOTA_1, @NOTA_2, @NOTA_3, @FREQUENCIA)";

            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota_1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota_2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota_3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.QuantidadeFaltas);

            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }

        public bool Editar(Aluno aluno)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE alunos SET
nome = @NOME,
codigo_matricula = @MATRICULA,
nota_1 = @NOTA_1,
nota_2 = @NOTA_2,
nota_3 = @NOTA_3,
frequencia = @FREQUENCIA
WHERE id = @CODIGO";

            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota_1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota_2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota_3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.QuantidadeFaltas);
            command.Parameters.AddWithValue("@CODIGO", aluno.Id);
            int quantidadeAlterada = command.ExecuteNonQuery();
            connection.Close();
            return quantidadeAlterada == 1;
        }

        public List<Aluno> ObterAlunos(
            string textPesquisa = "%%",
            string colunaOrdenacao = "nome",
            string tipoOrdenacao = "ASC"
            )
        {
            textPesquisa = "%" + textPesquisa + "%";
            List<Aluno> alunos = new List<Aluno>();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT
            id, codigo_matricula, nome, nota_1, nota_2, nota_3, round(((nota_1 + nota_2 + nota_3) / 3),2)
            FROM alunos
            WHERE
            nome LIKE @PESQUISA OR codigo_matricula LIKE @PESQUISA OR ((nota_1 + nota_2 + nota_3) / 3) LIKE @PESQUISA
            ORDER BY " + colunaOrdenacao + " " + tipoOrdenacao;

            command.Parameters.AddWithValue("@PESQUISA", textPesquisa);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(command.ExecuteReader());
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[i][0]);
                aluno.CodigoMatricula = tabelaEmMemoria.Rows[i][1].ToString();
                aluno.Nome = tabelaEmMemoria.Rows[i][2].ToString();
                aluno.Nota_1 = Convert.ToDouble(tabelaEmMemoria.Rows[i][3]);
                aluno.Nota_2 = Convert.ToDouble(tabelaEmMemoria.Rows[i][4]);
                aluno.Nota_3 = Convert.ToDouble(tabelaEmMemoria.Rows[i][5]);
                aluno.Media = Convert.ToDouble(tabelaEmMemoria.Rows[i][6]);
                alunos.Add(aluno);
            }
            connection.Close();
            return alunos;
        }

        public bool Apagar(int codigo)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM alunos WHERE id = @CODIGO";

            command.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = command.ExecuteNonQuery();
            connection.Close();
            return quantidade == 1;
        }

        public Aluno ObterPeloCodigo(int codigo)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT
id, nome, codigo_matricula, nota_1, nota_2, nota_3, ((nota_1 + nota_2 + nota_3) /3),frequencia
FROM alunos
WHERE id = @CODIGO";
            command.Parameters.AddWithValue("@CODIGO", codigo);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(command.ExecuteReader());
            if (tabelaEmMemoria.Rows.Count == 0)
            {
                return null;
            }

            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[0][0].ToString());
            aluno.Nome = tabelaEmMemoria.Rows[0][1].ToString();
            aluno.CodigoMatricula = tabelaEmMemoria.Rows[0][2].ToString();
            aluno.Nota_1 = Convert.ToDouble(tabelaEmMemoria.Rows[0][3].ToString());
            aluno.Nota_2 = Convert.ToDouble(tabelaEmMemoria.Rows[0][4].ToString());
            aluno.Nota_3 = Convert.ToDouble(tabelaEmMemoria.Rows[0][5].ToString());
            aluno.Media = Convert.ToDouble(tabelaEmMemoria.Rows[0][6].ToString());
            aluno.QuantidadeFaltas = Convert.ToByte(tabelaEmMemoria.Rows[0][7].ToString());           
            connection.Close();
            return aluno;
        }
    }
}
