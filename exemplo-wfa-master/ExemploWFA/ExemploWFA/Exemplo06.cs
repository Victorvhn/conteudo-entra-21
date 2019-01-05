using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Exemplo06 : Form
    {
        public Exemplo06()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Preto")
            {
                panel1.BackColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Azul")
            {
                panel1.BackColor = Color.Blue;
            }
            else if (comboBox1.SelectedItem.ToString() == "Cinza")
            {
                panel1.BackColor = Color.DarkGray;
            }
            else
            {
                panel1.BackColor = Color.Gray;
            }
        }
    }
}
