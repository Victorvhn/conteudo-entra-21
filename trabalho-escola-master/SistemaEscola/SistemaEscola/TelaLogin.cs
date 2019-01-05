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
    public partial class TelaLogin : Form
    {
        ListaUsuarios usuariosSistema = new ListaUsuarios();

        bool validarErro = true;
        public TelaLogin()
        {
            InitializeComponent();
            txt_Senha.MaxLength = 12;
            txt_Senha.UseSystemPasswordChar = true;
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (txt_Login.Text == "admin" && txt_Senha.Text == "123")
            {
                this.Hide();
                var form2 = new TelaPrincipal();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                validarErro = false;
            }


            for (int i = 0; i < Program.usuarios.Count; i++)
            {
                ListaUsuarios usuarioLogin = Program.usuarios[i];
                if (txt_Login.Text == usuarioLogin.Login && txt_Senha.Text == usuarioLogin.Senha)
                {
                    this.Hide();
                    var form2 = new TelaPrincipal();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                    validarErro = false;
                }
            }

            if (validarErro == true)
            {
                lb_ErroLogin.Visible = true;
            }
            else
            {
                lb_ErroLogin.Visible = false;
            }

        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            TelaAjuda telaAjuda = new TelaAjuda();
            telaAjuda.ShowDialog();
        }

        private void txt_Senha_Leave(object sender, EventArgs e)
        {
           
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Entrar.PerformClick();
            }
        }

        private void cb_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MostrarSenha.Checked)
            {
                txt_Senha.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Senha.UseSystemPasswordChar = true;
            }
        }

        private void btn_CadastroUsuario_Click(object sender, EventArgs e)
        {
            TelaCadastroLogin telacadastro = new TelaCadastroLogin();
            telacadastro.ShowDialog();
        }
    }
}
