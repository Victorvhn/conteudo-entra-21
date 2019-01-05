using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class TelaPrincipal : Form
    {
        usProfessor usProfessor = new usProfessor();        

        public TelaPrincipal()
        {
            InitializeComponent();

            usProfessor usProfessor = new usProfessor();
            TabPage tabPageProfessor = new TabPage("Professores");
            tabPageProfessor.Controls.Add(usProfessor);
            tabPrincipal.TabPages.Add(tabPageProfessor);

            usAluno usAluno = new usAluno();
            TabPage tabPageAluno = new TabPage("Alunos");
            tabPageAluno.Controls.Add(usAluno);
            tabPrincipal.TabPages.Add(tabPageAluno);

            usFuncionario usFuncionario = new usFuncionario();
            TabPage tabPageFuncionaro = new TabPage("Funcionários");
            tabPageFuncionaro.Controls.Add(usFuncionario);
            tabPrincipal.TabPages.Add(tabPageFuncionaro);

            usEquipamento usEquipamento = new usEquipamento();
            TabPage tabPageEquipamento = new TabPage("Equipamentos");
            tabPageEquipamento.Controls.Add(usEquipamento);
            tabPrincipal.TabPages.Add(tabPageEquipamento);

            usMaterial usMaterial = new usMaterial();
            TabPage tabPageMaterial = new TabPage("Materiais");
            tabPageMaterial.Controls.Add(usMaterial);
            tabPrincipal.TabPages.Add(tabPageMaterial);

            usProduto usProduto = new usProduto();
            TabPage tabPageProduto = new TabPage("Produtos");
            tabPageProduto.Controls.Add(usProduto);
            tabPrincipal.TabPages.Add(tabPageProduto);

            usAlimento usAlimento = new usAlimento();
            TabPage tabPageAlimento = new TabPage("Alimentos");
            tabPageAlimento.Controls.Add(usAlimento);
            tabPrincipal.TabPages.Add(tabPageAlimento);

            usFinanceiro usFinanceiro = new usFinanceiro();
            TabPage tabPageFinanceiro = new TabPage("Financeiro");
            tabPageFinanceiro.Controls.Add(usFinanceiro);
            tabPrincipal.TabPages.Add(tabPageFinanceiro);
        }

        private void tabPrincipal_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                lblTitulo.Text = "Bem-Vindo, Usuário.";
                lblInformacoes.Text = "Por favor, seleciona uma opção.";
            }
            else if (e.TabPageIndex == 1)
            {
                lblTitulo.Text = "Menu dos Professores";
                lblInformacoes.Text = "Neste menu voce tem acesso a todos os dados de todos os professores que exercem atividades na escola.";
            }
            else if (e.TabPageIndex == 2)
            {
                lblTitulo.Text = "Menu dos Alunos";
                lblInformacoes.Text = "Neste menu você tem acesso a todos os dados de todos os alunos matriculados na escola.";
            }
            else if (e.TabPageIndex == 3)
            {
                lblTitulo.Text = "Menu dos Funcionários";
                lblInformacoes.Text = "Neste menu você tem acesso a todos os dados de todos os funcionario da escola.";
            }
            else if (e.TabPageIndex == 4)
            {
                lblTitulo.Text = "Menu de Equipamentos";
                lblInformacoes.Text = "Neste menu você tem o controle do estoque de equipamentos, como: Projetores, computadores e quadros digitais.";
            }
            else if (e.TabPageIndex == 5)
            {
                lblTitulo.Text = "Menu de Materiais";
                lblInformacoes.Text = "Neste menu você tem acesso as informações de quantos livros didáticos estão em estoque.";
            }
            else if (e.TabPageIndex == 6)
            {
                lblTitulo.Text = "Menu de Produtos";
                lblInformacoes.Text = "Neste menu você tem o controle do estoque de produtos.";
            }
            else if (e.TabPageIndex == 7)
            {
                lblTitulo.Text = "Menu de Alimentos";
                lblInformacoes.Text = "Neste menu você controla a quantidade de comida em estoque e o que está faltando.";
            }

            else if (e.TabPageIndex == 8)
            {
                lblTitulo.Text = "Menu Financeiro";
                lblInformacoes.Text = "Adiministre toda a parte financeira da escola, adicione saldos de entradas e saídas, para ter total controle.";
            }
        }
    }
}

