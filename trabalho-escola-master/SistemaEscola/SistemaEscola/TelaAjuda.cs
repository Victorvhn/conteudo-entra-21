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
    public partial class TelaAjuda : Form
    {
        public TelaAjuda()
        {
            InitializeComponent();
        }

        private void btn_SugestaoBug_Click(object sender, EventArgs e)
        {
            TelaSugestaoBug emailsuporte = new TelaSugestaoBug();
            emailsuporte.ShowDialog();
        }

        private void btn_EsqueciSenha_Click(object sender, EventArgs e)
        {
            TelaRecuperarSenha emailRecuperacao = new TelaRecuperarSenha();
            emailRecuperacao.ShowDialog();
        }
    }
}
