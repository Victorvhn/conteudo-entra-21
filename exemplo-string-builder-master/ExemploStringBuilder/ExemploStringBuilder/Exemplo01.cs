using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploStringBuilder
{
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i).Append(" / 2 = ").AppendLine(Convert.ToString(i / 2.0));
                //texto += i + " / " + 2 + " = " + i / 2.0 + "\r\n";
            }
            //txtResultado.Text = texto;
            txtResultado.Text = sb.ToString();
        }
    }
}
