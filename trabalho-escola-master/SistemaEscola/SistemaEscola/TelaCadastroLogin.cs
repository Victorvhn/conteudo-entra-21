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
    public partial class TelaCadastroLogin : Form
    {
        ListaUsuarios listaUsuarios = new ListaUsuarios();
        GmailEmailService gmail = new GmailEmailService();

        public TelaCadastroLogin()
        {
            InitializeComponent();
            txt_Senha.UseSystemPasswordChar = true;
            txt_ConfirmacaoSenha.UseSystemPasswordChar = true;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Senha.Text))
                {
                    MessageBox.Show("Por Favor, digite a senha Corretamente.");
                    txt_Senha.Focus();
                    return;
                }

                if (txt_Senha.Text != txt_ConfirmacaoSenha.Text)
                {
                    MessageBox.Show("Senha de confirmação diferente.");
                    txt_ConfirmacaoSenha.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_ConfirmacaoSenha.Text))
                {
                    MessageBox.Show("Senha de confirmação vazia.");
                    txt_ConfirmacaoSenha.Focus();
                    return;
                }
                listaUsuarios.Email = txt_Senha.Text;
                
                if (Tools.ValidarEmail(txt_Email.Text))
                {
                    listaUsuarios.Email = txt_Email.Text;

                    EmailMessage msg = new EmailMessage();
                    msg.Body = "Infomações sobre a conta cadastrada no sistema escola." + "<br/><br/>" + "Usuario:" + txt_Login.Text + "<br/><br/>" + "Senha:" + txt_Senha.Text;
                    msg.IsHtml = true;
                    msg.Subject = "Cadastro Realizado";
                    msg.ToEmail = txt_Email.Text;
                    gmail.SendEmailMessage(msg);
                    MessageBox.Show("E-mail foi enviado com suas informações");
                }

                if (string.IsNullOrEmpty(txt_Email.Text))
                {
                    MessageBox.Show("Por Favor Digite o E-Mail.");
                    txt_Email.Focus();
                    return;
                }

                if (!Tools.ValidarEmail(txt_Email.Text)) 
                {
                    MessageBox.Show("E-Mail inválido.");
                    txt_Email.Focus();
                    return;    
                }
                
                Program.usuarios.Add(listaUsuarios);
                limparCampos();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                return;
                
            }
        }

        private void cb_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MostrarSenha.Checked)
            {
                txt_Senha.UseSystemPasswordChar = false;
                txt_ConfirmacaoSenha.UseSystemPasswordChar = false;    
            }
            else
            {
                txt_Senha.UseSystemPasswordChar = true;
                txt_ConfirmacaoSenha.UseSystemPasswordChar = true;
            }
            
        }

        private void txt_ConfirmacaoSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar.PerformClick();
            }
        }

        public void limparCampos()
        {
            txt_Nome.Text = "";
            txt_ConfirmacaoSenha.Text = "";
            txt_Email.Text = "";
            txt_Login.Text = "";
            txt_Senha.Text = "";
            cb_MostrarSenha.Checked = false;
            cb_Privilegio.SelectedIndex = 0;
            cb_Setor.SelectedIndex = 0;
        }
    }
}
