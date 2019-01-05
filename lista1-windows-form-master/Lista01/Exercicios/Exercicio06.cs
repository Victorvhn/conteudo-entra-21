using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        double nota01 = 0;
        double nota02 = 0;
        double nota03 = 0;
        double nota04 = 0;

        public void Algoritimo()
        {
            // valida nota 1
            try
            {
                nota01 = Convert.ToDouble(mtbNota01.Text);
                if (mtbNota01.Text.Replace(".", "") == "")
                {
                    MessageBox.Show("Deve conter alguma nota em \"Nota 1\"");
                    mtbNota01.Focus();
                    return;
                }
                if (nota01 > 1000)
                {
                    MessageBox.Show("A \"Nota 1\" deve ser menor que 10");
                    mtbNota01.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Deve conter alguma nota em \"Nota 1\"");
                mtbNota01.Focus();
                return;
            }

            // valida nota 2
            try
            {
                nota02 = Convert.ToDouble(mtbNota02.Text);
                if (mtbNota02.Text.Replace(".", "") == "")
                {
                    MessageBox.Show("Deve conter alguma nota em \"Nota 2\"");
                    mtbNota02.Focus();
                    return;
                }
                if (nota02 > 1000)
                {
                    MessageBox.Show("A \"Nota 2\" deve ser menor que 10");
                    mtbNota02.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Deve conter alguma nota em \"Nota 2\"");
                mtbNota02.Focus();
                return;
            }

            // valida nota 3
            try
            {
                nota03 = Convert.ToDouble(mtbNota03.Text);
                if (mtbNota03.Text.Replace(".", "") == "")
                {
                    MessageBox.Show("Deve conter alguma nota em \"Nota 3\"");
                    mtbNota03.Focus();
                    return;
                }
                if (nota03 > 1000)
                {
                    MessageBox.Show("A \"Nota 3\" deve ser menor que 10");
                    mtbNota03.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Deve conter alguma nota em \"Nota 3\"");
                mtbNota03.Focus();
                return;
            }

            // valida nota 4
            try
            {
                nota04 = Convert.ToDouble(mtbNota04.Text);
                if (mtbNota04.Text.Replace(".", "") == "")
                {
                    MessageBox.Show("Deve conter alguma nota em \"Nota 4\"");
                    mtbNota04.Focus();
                    return;
                }
                if (nota04 > 1000)
                {
                    MessageBox.Show("A \"Nota 4\" deve ser menor que 10");
                    mtbNota04.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Deve conter alguma nota em \"Nota 4\"");
                mtbNota04.Focus();
                return;
            }

            double media = (nota01 + nota02 + nota03 + nota04) / 400;
            string textoMedia = String.Format("{0:n}", media);

            txtMedia.Text = textoMedia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Algoritimo();
        }

        private void mtbNota04_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Algoritimo();
                btnCalcular.PerformClick();
            }
        }
    }
}
