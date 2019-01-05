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
    public partial class TelaSugestaoBug : Form
    {
        public TelaSugestaoBug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GmailEmailService gmail = new GmailEmailService();

            try
            {

                if (Tools.ValidarEmail(txt_Email.Text))
                {
                    EmailMessage msg = new EmailMessage();
                    msg.Body = txt_Menssagem.Text + "<br/><br/>" + txt_Email.Text;
                    msg.IsHtml = true;
                    msg.Subject = cb_Assunto.SelectedItem.ToString();
                    msg.ToEmail = "trabalhosistemaescolar@gmail.com";
                    gmail.SendEmailMessage(msg);

                    if (cb_Assunto.SelectedItem.ToString() == "Sugestão")
                    {
                        MessageBox.Show("Obrigado pela sugestão.");
                    }
                    else if (cb_Assunto.SelectedItem.ToString() == "Reclamação")
                    {
                        MessageBox.Show("Obrigado por nos contatar.");
                    }
                    else if (cb_Assunto.SelectedItem.ToString() == "Suporte")
                    {
                        MessageBox.Show("Obrigdao por nos contatar, entraremos em contato o mais breve possivel.");
                    }
                    else if (cb_Assunto.SelectedItem.ToString() == "Bug")
                    {
                        MessageBox.Show("Obrigado por informar um Bug, entraremos em contato o mais breve possivel");
                    }
                }

                else if (string.IsNullOrEmpty(txt_Email.Text))
                {
                    MessageBox.Show("Preencha o E-Mail.");
                    txt_Email.Focus();
                    return;
                }

                else
                {
                    MessageBox.Show("E-Mail inválido");
                    txt_Email.Focus();
                    return;
                }

                if (cb_Assunto.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione um asunto.");
                    cb_Assunto.DroppedDown = true;
                    return;
                }
                LimparCampos();
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha corretamente!");
                return;
            }
         
        }

        public void LimparCampos()
        {
            txt_Email.Text = "";
            txt_Menssagem.Text = "";
            cb_Assunto.SelectedIndex = 0;
        }
    }
}
