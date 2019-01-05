using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola
{
    static class Program
    {
        //public static List<UsuarioSistema> cadastroUsuarioSistemaLogin = new List<UsuarioSistema>();
        public static List<ListaProfessor> professores = new List<ListaProfessor>();
        public static List<ListaAluno> alunos = new List<ListaAluno>();
        public static List<ListaFuncionario> funcionarios = new List<ListaFuncionario>();
        public static List<ListaProduto> produtos = new List<ListaProduto>();
        public static List<ListaAlimento> alimentos = new List<ListaAlimento>();
        public static List<ListaMaterial> materiais = new List<ListaMaterial>();
        public static List<ListaEquipamento> equipamentos = new List<ListaEquipamento>();
        public static List<ListaFinanceiro> financeiros = new List<ListaFinanceiro>();
        public static List<ListaUsuarios> usuarios = new List<ListaUsuarios>();
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Popular();
            Application.Run(new TelaLogin());
        }
    }
}
