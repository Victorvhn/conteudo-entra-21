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
    public partial class CadastrarAluno : Form
    {
        private int codigo;

        public CadastrarAluno()
        {
            InitializeComponent();
        }

        public CadastrarAluno(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Aluno aluno = new AlunoRepository().ObterPeloCodigo(codigo);
            PreecherCampos(aluno);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            // matricula
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("O código de matrícula do aluno deve ser preencido");
                txtMatricula.Focus();
                return;
            }
            if (txtMatricula.Text.Length < 3)
            {
                MessageBox.Show("O código de matrícula do aluno deve conter pelo menos 3 caracteres");
                txtMatricula.Focus();
                return;
            }
            if (txtMatricula.Text.Length > 150)
            {
                MessageBox.Show("O código de matrícula do aluno deve conter no máximo 150 caracteres");
                txtMatricula.Focus();
                return;
            }

            // nome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O nome do aluno deve ser preencido");
                txtNome.Focus();
                return;
            }
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("O nome do aluno deve conter pelo menos 3 caracteres");
                txtNome.Focus();
                return;
            }
            if (txtNome.Text.Length > 150)
            {
                MessageBox.Show("O nome do aluno deve conter no máximo 150 caracteres");
                txtNome.Focus();
                return;
            }

            // faltas
            try
            {
                Convert.ToByte(nudQuantidadeFaltas.Value);
            }
            catch
            {
                MessageBox.Show("Insira uma quantidade de faltas válidas");
                nudQuantidadeFaltas.Focus();                
            }
            if (nudQuantidadeFaltas.Value > 200)
            {
                MessageBox.Show("O ano letivo tem apenas 200 dias");
                nudQuantidadeFaltas.Focus();
                return;
            }

            // nota 1
            if (string.IsNullOrEmpty(mtbNota1.Text.Replace(",", "").Replace(" ","")))
            {
                MessageBox.Show("Nota 1 deve ser preenchida");
                mtbNota1.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota1.Text) < 0)
            {
                MessageBox.Show("Nota 1 deve ser maior que 0");
                mtbNota1.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota1.Text) > 10)
            {
                MessageBox.Show("Nota 1 deve ser menor que 10");
                mtbNota1.Focus();
                return;
            }

            // nota 2
            if (string.IsNullOrEmpty(mtbNota2.Text.Replace(",", "").Replace(" ", "")))
            {
                MessageBox.Show("Nota 2 deve ser preenchida");
                mtbNota2.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota2.Text) < 0)
            {
                MessageBox.Show("Nota 2 deve ser maior que 0");
                mtbNota2.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota2.Text) > 10)
            {
                MessageBox.Show("Nota 2 deve ser menor que 10");
                mtbNota2.Focus();
                return;
            }

            // nota 3
            if (string.IsNullOrEmpty(mtbNota3.Text.Replace(",", "").Replace(" ", "")))
            {
                MessageBox.Show("Nota 3 deve ser preenchida");
                mtbNota3.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota3.Text) < 0)
            {
                MessageBox.Show("Nota 3 deve ser maior que 0");
                mtbNota3.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota3.Text) > 10)
            {
                MessageBox.Show("Nota 3 deve ser menor que 10");
                mtbNota3.Focus();
                return;
            }            

            aluno.CodigoMatricula = txtMatricula.Text;
            aluno.Nome = txtNome.Text;
            aluno.Nota_1 = Convert.ToDouble(mtbNota1.Text);
            aluno.Nota_2 = Convert.ToDouble(mtbNota2.Text);
            aluno.Nota_3 = Convert.ToDouble(mtbNota3.Text);
            aluno.QuantidadeFaltas = Convert.ToByte(nudQuantidadeFaltas.Value);
            aluno.Media = Convert.ToDouble(lblMedia.Text);
            aluno.Frequencia = Convert.ToDouble(lblFrequencia.Text.Replace("%",""));

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                int id = new AlunoRepository().Inserir(aluno);
                txtCodigo.Text = id.ToString();
                MessageBox.Show("Aluno cadastrado com sucesso");
            }
            else
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                aluno.Id = id;
                bool editou = new AlunoRepository().Editar(aluno);
                if (editou)
                {
                    MessageBox.Show("Aluno editado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível editar o aluno");
                }
            }
        }

        private void CalcularMedia()
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;

            if (string.IsNullOrEmpty(mtbNota1.Text.Replace(",", "").Replace(" ", "")))
            {
                nota1 = 0;
            }
            else
            {
                nota1 = Convert.ToDouble(mtbNota1.Text);
            }

            if (string.IsNullOrEmpty(mtbNota2.Text.Replace(",", "").Replace(" ", "")))
            {
                nota2 = 0;
            }
            else
            {
                nota2 = Convert.ToDouble(mtbNota2.Text);
            }

            if (string.IsNullOrEmpty(mtbNota3.Text.Replace(",", "").Replace(" ", "")))
            {
                nota3 = 0;
            }
            else
            {
                nota3 = Convert.ToDouble(mtbNota3.Text);
            }

            double media = (nota1 + nota2 + nota3) / 3;
            lblMedia.Text = String.Format("{0:n}", media);
        }

        private void CalcularSituacao()
        {
            double media = Convert.ToDouble(lblMedia.Text);
            double frequencia = Convert.ToDouble(lblFrequencia.Text.Replace("%",""));

            if (frequencia >= 65)
            {
                if (media < 5)
                {
                    lblSituacao.Text = "Reprovado";
                }
                if ((media >= 5) && (media < 7))
                {
                    lblSituacao.Text = "Recuperação";
                }
                if (media >= 7)
                {
                    lblSituacao.Text = "Aprovado";
                }
            }
            if (frequencia < 65)
            {
                lblSituacao.Text = "Reprovado por frequência";
            }
        }

        private void mtbNota1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbNota1.Text.Replace(",", "").Replace(" ", "")))
            {
                MessageBox.Show("Nota 1 deve ser preenchida");
                mtbNota1.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota1.Text) > 10)
            {
                MessageBox.Show("Nota 1 deve ser menor que 10");
                mtbNota1.Focus();
                mtbNota1.SelectionStart = 0;
                mtbNota1.SelectionLength = mtbNota1.Text.Length;
                return;
            }
            CalcularMedia();
            CalcularSituacao();
        }

        private void mtbNota2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbNota2.Text.Replace(",", "").Replace(" ", "")))
            {
                MessageBox.Show("Nota 2 deve ser preenchida");
                mtbNota2.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota2.Text) > 10)
            {
                MessageBox.Show("Nota 2 deve ser menor que 10");
                mtbNota2.Focus();
                mtbNota2.SelectionStart = 0;
                mtbNota2.SelectionLength = mtbNota2.Text.Length;
                return;
            }
            CalcularMedia();
            CalcularSituacao();
        }

        private void mtbNota3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbNota3.Text.Replace(",", "").Replace(" ", "")))
            {
                MessageBox.Show("Nota 3 deve ser preenchida");
                mtbNota3.Focus();
                return;
            }
            if (Convert.ToDouble(mtbNota3.Text) > 10)
            {
                MessageBox.Show("Nota 3 deve ser menor que 10");
                mtbNota3.Focus();
                mtbNota3.SelectionStart = 0;
                mtbNota3.SelectionLength = mtbNota3.Text.Length;
                return;
            }
            CalcularMedia();
            CalcularSituacao();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    Aluno aluno = new AlunoRepository().ObterPeloCodigo(id);
                    if (aluno != null)
                    {
                        PreecherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado");
                        txtCodigo.Focus();
                        txtCodigo.SelectionStart = 0;
                        txtCodigo.SelectionLength = txtCodigo.Text.Length;
                    }
                }
                catch
                {
                    MessageBox.Show("Digite um código válido");
                    txtCodigo.Focus();
                    txtCodigo.SelectionStart = 0;
                    txtCodigo.SelectionLength = txtCodigo.Text.Length;
                }
            }
        }

        private void PreecherCampos(Aluno aluno)
        {
            txtCodigo.Text = aluno.Id.ToString();
            txtNome.Text = aluno.Nome;
            txtMatricula.Text = aluno.CodigoMatricula;
            if (aluno.Nota_1 < 10)
            {
                mtbNota1.Text = "0" + aluno.Nota_1.ToString();
            }
            else
            {
                mtbNota1.Text = aluno.Nota_1.ToString() + "00";
            }

            if (aluno.Nota_2 < 10)
            {
                mtbNota2.Text = "0" + aluno.Nota_2.ToString();
            }
            else
            {
                mtbNota2.Text = aluno.Nota_2.ToString() + "00";
            }

            if (aluno.Nota_3 < 10)
            {
                mtbNota3.Text = "0" + aluno.Nota_3.ToString();
            }
            else
            {
                mtbNota3.Text = aluno.Nota_3.ToString() + "00";
            }

            lblMedia.Text = String.Format("{0:n}",aluno.Media.ToString());
            nudQuantidadeFaltas.Text = aluno.QuantidadeFaltas.ToString();
            lblFrequencia.Text = String.Format("{0:n}%",aluno.Frequencia);
        }

        private void mtbNota1_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtbNota1.SelectionStart == 0 && e.KeyCode != Keys.NumPad1)
            {
                e.SuppressKeyPress = true;
                string textoSemMaskara = mtbNota1.Text.Replace(" ", "").Replace(",", "");
                if (textoSemMaskara.Length != 0)
                {
                    mtbNota1.Text = "0" + textoSemMaskara.Substring(0, textoSemMaskara.Length);
                }
                else
                {
                    mtbNota1.Text = "0";
                }
            }
        }

        private void mtbNota2_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtbNota2.SelectionStart == 0 && e.KeyCode != Keys.NumPad1)
            {
                e.SuppressKeyPress = true;
                string textoSemMaskara = mtbNota2.Text.Replace(" ", "").Replace(",", "");
                if (textoSemMaskara.Length != 0)
                {
                    mtbNota2.Text = "0" + textoSemMaskara.Substring(0, textoSemMaskara.Length);
                }
                else
                {
                    mtbNota2.Text = "0";
                }
            }
        }

        private void mtbNota3_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtbNota3.SelectionStart == 0 && e.KeyCode != Keys.NumPad1)
            {
                e.SuppressKeyPress = true;
                string textoSemMaskara = mtbNota3.Text.Replace(" ", "").Replace(",", "");
                if (textoSemMaskara.Length != 0)
                {
                    mtbNota3.Text = "0" + textoSemMaskara.Substring(0, textoSemMaskara.Length);
                }
                else
                {
                    mtbNota3.Text = "0";
                }
            }
        }

        private void nudQuantidadeFaltas_Leave(object sender, EventArgs e)
        {
            byte faltas = Convert.ToByte(nudQuantidadeFaltas.Value);
            double percentualDeFaltas = ((((faltas * 100) / 200) - 100.00) * -1);
            lblFrequencia.Text = String.Format("{0:n}%", percentualDeFaltas);
        }
    }
}
