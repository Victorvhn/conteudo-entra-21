using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class MenuPaciente : Form
    {
        public MenuPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarPaciente cadastrarPaciente = new CadastrarPaciente();
            cadastrarPaciente.Show();
        }
    }
}
