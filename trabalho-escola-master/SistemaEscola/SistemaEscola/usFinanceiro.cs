using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class usFinanceiro : UserControl
    {
        public usFinanceiro()
        {
            InitializeComponent();

        }

        private void cb_Maior_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Maior.Checked)
            {
                int  maiorFuncionario = 0, maiorProfessor = 0, maiorAluno = 0, maiorAlimento = 0, maiorEquipamento = 0, maiorProduto = 0;
                string nomeAluno = "", nomeFuncionario = "", nomeProfessor = "", nomeAlimento = "", nomeEquipamento = "", nomeProduto = "";
                for (int i = 0; i < Program.funcionarios.Count; i++)
                {
                    ListaFuncionario funcionario = Program.funcionarios[i];

                    if (funcionario.Nome.Length > maiorFuncionario)
                    {
                        maiorFuncionario = funcionario.Nome.Length;
                        nomeFuncionario = funcionario.Nome;
                    }
                }

                for (int i = 0; i < Program.professores.Count; i++)
                {
                    ListaProfessor professor = Program.professores[i];
                    if (professor.Nome.Length > maiorProfessor)
                    {
                        maiorProfessor = professor.Nome.Length;
                        nomeProfessor = professor.Nome;
                    }
                }
                for (int i = 0; i < Program.alunos.Count; i++)
                {
                    ListaAluno aluno = Program.alunos[i];
                    if (aluno.Nome.Length > maiorAluno)
                    {
                        maiorAluno = aluno.Nome.Length;
                        nomeAluno = aluno.Nome;
                    }
                }
                for (int i = 0; i < Program.alimentos.Count; i++)
                {
                    ListaAlimento alimento = Program.alimentos[i];
                    if (alimento.Nome.Length > maiorAlimento)
                    {
                        maiorAlimento = alimento.Nome.Length;
                        nomeAlimento = alimento.Nome;
                    }
                }
                for (int i = 0; i < Program.equipamentos.Count; i++)
                {
                    ListaEquipamento equipamento = Program.equipamentos[i];
                    if (equipamento.Nome.Length > maiorEquipamento)
                    {
                        maiorEquipamento = equipamento.Nome.Length;
                        nomeEquipamento = equipamento.Nome;
                    }
                }
                for (int i = 0; i < Program.produtos.Count; i++)
                {
                    ListaProduto produto = Program.produtos[i];
                    if (produto.Nome.Length > maiorEquipamento)
                    {
                        maiorProduto = produto.Nome.Length;
                        nomeProduto = produto.Nome;
                    }
                }
                this.chart_Financeiro.Series[0].Points.AddXY("Maior Nome Funcionario: " + nomeFuncionario, maiorFuncionario);
                this.chart_Financeiro.Series[0].Points.AddXY("Maior Nome Professor: " + nomeProfessor, maiorProfessor);
                this.chart_Financeiro.Series[0].Points.AddXY("Maior Nome Aluno: " + nomeAluno, maiorAluno);
                this.chart_Financeiro.Series[0].Points.AddXY("Maior Nome Alimento: " + nomeAlimento, maiorAlimento);
                this.chart_Financeiro.Series[0].Points.AddXY("Maior Nome Equipamento: " + nomeEquipamento, maiorEquipamento);
                this.chart_Financeiro.Series[0].Points.AddXY("Maior Nome produto: " + nomeProduto, maiorProduto);
            }
            else
            {
                chart_Financeiro.Series[0].Points.Clear();
            }
         
        }

        private void btn_Atualizar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Limpar.PerformClick();
            }
        }

        private void cb_Menor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Menor.Checked)
            {
                int menorFuncionario = int.MaxValue, menorProfessor = int.MaxValue, menorAluno = int.MaxValue, menorAlimento = int.MaxValue, menorEquipamento = int.MaxValue, menorProduto = int.MaxValue;
                string nomeAluno = "", nomeFuncionario = "", nomeProfessor = "", nomeAlimento = "", nomeEquipamento = "", nomeProduto = "";
                for (int i = 0; i < Program.funcionarios.Count; i++)
                {
                    ListaFuncionario funcionario = Program.funcionarios[i];

                    if (funcionario.Nome.Length < menorFuncionario)
                    {
                        menorFuncionario = funcionario.Nome.Length;
                        nomeFuncionario = funcionario.Nome;
                    }
                }

                for (int i = 0; i < Program.professores.Count; i++)
                {
                    ListaProfessor professor = Program.professores[i];
                    if (professor.Nome.Length < menorProfessor)
                    {
                        menorProfessor = professor.Nome.Length;
                        nomeProfessor = professor.Nome;
                    }
                }
                for (int i = 0; i < Program.alunos.Count; i++)
                {
                    ListaAluno aluno = Program.alunos[i];
                    if (aluno.Nome.Length < menorAluno)
                    {
                        menorAluno = aluno.Nome.Length;
                        nomeAluno = aluno.Nome;
                    }
                }
                for (int i = 0; i < Program.alimentos.Count; i++)
                {
                    ListaAlimento alimento = Program.alimentos[i];
                    if (alimento.Nome.Length < menorAlimento)
                    {
                        menorAlimento = alimento.Nome.Length;
                        nomeAlimento = alimento.Nome;
                    }
                }
                for (int i = 0; i < Program.equipamentos.Count; i++)
                {
                    ListaEquipamento equipamento = Program.equipamentos[i];
                    if (equipamento.Nome.Length < menorEquipamento)
                    {
                        menorEquipamento = equipamento.Nome.Length;
                        nomeEquipamento = equipamento.Nome;
                    }
                }
                for (int i = 0; i < Program.produtos.Count; i++)
                {
                    ListaProduto produto = Program.produtos[i];
                    if (produto.Nome.Length < menorProduto)
                    {
                        menorProduto = produto.Nome.Length;
                        nomeProduto = produto.Nome;
                    }
                }
                this.chart_Financeiro.Series[1].Points.AddXY("Menor Nome Funcionario: " + nomeFuncionario, menorFuncionario);
                this.chart_Financeiro.Series[1].Points.AddXY("Menor Nome Professor: " + nomeProfessor, menorProfessor);
                this.chart_Financeiro.Series[1].Points.AddXY("Menor Nome Aluno: " + nomeAluno, menorAluno);
                this.chart_Financeiro.Series[1].Points.AddXY("Menor Nome Alimento: " + nomeAlimento, menorAlimento);
                this.chart_Financeiro.Series[1].Points.AddXY("Menor Nome Equipamento: " + nomeEquipamento, menorEquipamento);
                this.chart_Financeiro.Series[1].Points.AddXY("Menor Nome produto: " + nomeProduto, menorProduto);

            }
            else
            {
                chart_Financeiro.Series[1].Points.Clear();
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            chart_Financeiro.Series[0].Points.Clear();
            chart_Financeiro.Series[1].Points.Clear();
            chart_Financeiro.Series[2].Points.Clear();
            
            cb_Maior.Checked = false;
            cb_Media.Checked = false;
            cb_Menor.Checked = false;
            cb_3D.Checked = false;
        }

        private void cb_3D_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_3D.Checked)
            {
                chart_Financeiro.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chart_Financeiro.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        private void cb_Media_CheckedChanged(object sender, EventArgs e)
        {          
            if (cb_Media.Checked)
            {
                int quantidadeNome = 0;
                for (int i = 0; i < Program.produtos.Count; i++)
                {
                    ListaProfessor professor = Program.professores[i];
                    ListaFuncionario funcionario = Program.funcionarios[i];
                    ListaAluno aluno = Program.alunos[i];
                    ListaAlimento alimento = Program.alimentos[i];
                    ListaEquipamento equipamento = Program.equipamentos[i];
                    ListaProduto produto = Program.produtos[i];

                    quantidadeNome = professor.Nome.Length + funcionario.Nome.Length + aluno.Nome.Length + alimento.Nome.Length + equipamento.Nome.Length + produto.Nome.Length;
                    
                }

                double mediaNome = quantidadeNome / 6;
                double mediaCadastros = (Program.produtos.Count + Program.alimentos.Count + Program.equipamentos.Count + Program.alunos.Count + Program.professores.Count + Program.funcionarios.Count)/6;
  
                this.chart_Financeiro.Series[2].Points.AddXY("Media Cadastros: ", mediaCadastros);
                this.chart_Financeiro.Series[2].Points.AddXY("Media Nomes: ", mediaNome);

            }
            else
            {
                chart_Financeiro.Series[2].Points.Clear();
            }
        }



    }
}
