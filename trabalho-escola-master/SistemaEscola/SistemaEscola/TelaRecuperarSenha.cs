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
    public partial class TelaRecuperarSenha : Form
    {
        GmailEmailService gmail = new GmailEmailService();

        public TelaRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Program.usuarios.Count(); i++)
            {
                ListaUsuarios emailUsuarios = Program.usuarios[i];
                try
                {
                    if (txt_Email.Text == emailUsuarios.Email)
                    {
                        EmailMessage msg = new EmailMessage();
                        msg.Body = "Suas informações conforme solicitado <br/><br/>" + "Nome:" + emailUsuarios.Nome + "<br/>" + "Login:" + emailUsuarios.Login + "<br/>" + "Senha:" + emailUsuarios.Senha;
                        msg.IsHtml = true;
                        msg.Subject = "Recuperação de senha";
                        msg.ToEmail = txt_Email.Text;
                        gmail.SendEmailMessage(msg);
                        MessageBox.Show("E-mail foi enviado com suas informações");
                    }
   
                    if (string.IsNullOrEmpty(txt_Email.Text))
                    {
                        MessageBox.Show("Preencha o E-Mail corretamente!");
                        txt_Email.Focus();
                        return;
                    }
                }


                catch (Exception)
                {
                    MessageBox.Show("Preencha corretamente!");
                    return;
                }

            }
        }

        private void btn_Enviar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Enviar.PerformClick();
            }
        }

        private void txt_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Enviar.PerformClick();
            }
        }


    }
}


