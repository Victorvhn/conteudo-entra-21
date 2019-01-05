using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Fadas : Form
    {
        string nomeAntigo = String.Empty;
        List<Fada> fadas = new List<Fada>();

        public Fadas()
        {
            InitializeComponent();

            gbCadastroRapido1.Enabled = false;
            gbCadastroRapido2.Enabled = false;            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbcFada.SelectedIndex = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente cancelar o registro?", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                LimparCampos();
                nomeAntigo = "";
                tbcFada.SelectedIndex = 0;
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtFamilia.Text = "";
            cbCor.SelectedIndex = -1;
            cbCorAsa.SelectedIndex = -1;
            txtTamanhoAsa.Text = "";
            chkAsaQuebrada.Checked = false;
            chkFazBarulho.Checked = false;
            chkMulher.Checked = false;
            cbElemento.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Nome deve ser preenchido");
                    txtNome.Focus();
                    return;
                }

                if (txtNome.Text.Count() < 3)
                {
                    MessageBox.Show("Nome deve conter pelo menos 3 caracteres");
                    txtNome.Focus();
                    return;
                }

                if (txtNome.Text.Count() > 150)
                {
                    MessageBox.Show("Nome deve conter no máximo 150 caracteres");
                    txtNome.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtFamilia.Text))
                {
                    MessageBox.Show("Família deve ser preenchida");
                    txtFamilia.Focus();
                    return;
                }

                if (txtFamilia.Text.Count() < 4)
                {
                    MessageBox.Show("Família deve conter pelo menos 4 caracteres");
                    txtFamilia.Focus();
                    return;
                }

                if (txtFamilia.Text.Count() > 50)
                {
                    MessageBox.Show("Família deve conter no máximo 50 caracteres");
                    txtFamilia.Focus();
                    return;
                }

                if (cbCor.SelectedItem == null || string.IsNullOrEmpty(cbCor.SelectedItem.ToString()))
                {
                    MessageBox.Show("Selecione uma cor");
                    cbCor.DroppedDown = true;
                    return;
                }

                if (cbCorAsa.SelectedItem == null || string.IsNullOrEmpty(cbCorAsa.SelectedItem.ToString()))
                {
                    MessageBox.Show("Selecione uma cor de asa");
                    cbCorAsa.DroppedDown = true;
                    return;
                }

                if (string.IsNullOrEmpty(txtTamanhoAsa.Text.ToString()))
                {
                    MessageBox.Show("Tamanho de asa deve ser preenchido");
                    txtTamanhoAsa.Focus();
                    return;
                }

                try
                {
                    Convert.ToInt32(txtTamanhoAsa.Text);
                }
                catch
                {
                    MessageBox.Show("Insira apenas números");
                    txtTamanhoAsa.Focus();
                    return;
                }

                if (Convert.ToInt32(txtTamanhoAsa.Text) <= 0)
                {
                    MessageBox.Show("Tamanho da asa deve ser maior que 0 centímetros");
                    txtTamanhoAsa.Focus();
                    return;
                }

                if (Convert.ToInt32(txtTamanhoAsa.Text) > 15)
                {
                    MessageBox.Show("Tamanho da asa deve ser no máximo 15 centímetros");
                    txtTamanhoAsa.Focus();
                    return;
                }

                if (cbElemento.SelectedItem == null || string.IsNullOrEmpty(cbElemento.SelectedItem.ToString()))
                {
                    MessageBox.Show("Selecione um elemento");
                    cbElemento.DroppedDown = true;
                    return;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }

            try
            {
                Fada fada = new Fada(txtNome.Text, chkMulher.Checked, chkAsaQuebrada.Checked)
                {
                    Familia = txtFamilia.Text,
                    Cor = cbCor.SelectedItem.ToString(),
                    CorAsa = cbCorAsa.SelectedItem.ToString(),
                    TamanhoAsa = Convert.ToDouble(txtTamanhoAsa.Text),
                    Elemento = cbElemento.SelectedItem.ToString(),
                    FazBarulho = chkFazBarulho.Checked,
                    CodigoCadastro = 0,
                };

                if (nomeAntigo == "")
                {
                    fadas.Add(fada);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarFadaATabela(fada);
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[linha] = fada;
                    EditarFadaNaTabela(fada, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }

                LimparCampos();
                tbcFada.SelectedIndex = 0;
                lblQuantidadeFadas.Text = dgvFadas.Rows.Count.ToString();
                rbCadastroRapido1.Checked = false;
                rbCadastroRapido2.Checked = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void EditarFadaNaTabela(Fada fada, int linha)
        {
            dgvFadas.Rows[linha].Cells[0].Value = fada.CodigoCadastro;
            dgvFadas.Rows[linha].Cells[1].Value = fada.Nome;
            dgvFadas.Rows[linha].Cells[2].Value = fada.Cor;
        }

        private void AdicionarFadaATabela(Fada fada)
        {
            dgvFadas.Rows.Add(new Object[]
                {
                    fada.CodigoCadastro, fada.Nome, fada.Cor
                });
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFadas.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada");
                tbcFada.SelectedIndex = 1;
                return;
            }

            if (dgvFadas.SelectedRows == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dgvFadas.CurrentRow.Index;
            string nome = dgvFadas.Rows[linhaSelecionada].Cells[1].Value.ToString();
            nomeAntigo = dgvFadas.Rows[linhaSelecionada].Cells[1].Value.ToString();
            string codigoCadastro = dgvFadas.Rows[linhaSelecionada].Cells[0].Value.ToString();
            int codigo = Convert.ToInt32(codigoCadastro);

            if (codigo == 0)
            {
                foreach (Fada fada in fadas)
                {
                    if (fada.Nome == nome)
                    {
                        txtNome.Text = fada.Nome;
                        txtFamilia.Text = fada.Familia;
                        cbCor.Text = fada.Cor;
                        cbCorAsa.Text = fada.CorAsa;
                        txtTamanhoAsa.Text = fada.TamanhoAsa.ToString();
                        chkAsaQuebrada.Checked = fada.AsaQuebrada;
                        chkMulher.Checked = fada.Mulher;
                        chkFazBarulho.Checked = fada.FazBarulho;
                        cbElemento.Text = fada.Elemento;
                        tbcFada.SelectedIndex = 1;
                        break;
                    }
                }
            }

            if (codigo == 1)
            {
                foreach (Fada fada in fadas)
                {
                    if (fada.Nome == nome)
                    {
                        txtNomeRapido1.Text = fada.Nome;
                        txtFamiliaRapido1.Text = fada.Familia;
                        cbCorRapido1.Text = fada.Cor;
                        rbCadastroRapido1.Checked = true;
                        rbCadastroRapido2.Enabled = false;
                        tbcFada.SelectedIndex = 2;
                        break;
                    }
                }
            }

            if (codigo == 2)
            {
                foreach (Fada fada in fadas)
                {
                    if (fada.Nome == nome)
                    {
                        txtNomeRapido2.Text = fada.Nome;
                        cbCorRapido2.Text = fada.Cor;
                        chkMulherRapido2.Checked = fada.Mulher;
                        rbCadastroRapido2.Checked = true;
                        rbCadastroRapido1.Enabled = false;
                        tbcFada.SelectedIndex = 2;
                        break;
                    }
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvFadas.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada");
                tbcFada.SelectedIndex = 1;
                return;
            }

            if (dgvFadas.SelectedRows == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dgvFadas.CurrentRow.Index;
            string nome = dgvFadas.Rows[linhaSelecionada].Cells[1].Value.ToString();

            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + nome + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                dgvFadas.Rows.RemoveAt(linhaSelecionada);
                MessageBox.Show(nome + " apagado com sucesso");
            }
            else
            {
                MessageBox.Show(nome + " não apagado.");
            }
        }

        private void tbcFada_Click(object sender, EventArgs e)
        {
            if (tbcFada.SelectedIndex == 0)
            {
                this.Text = "Lista de Fadas";
                rbCadastroRapido1.Checked = false;
                rbCadastroRapido2.Checked = false;
                LimparCampos();
                LimparCamposCadastroRapido1();
                LimparCamposCadastroRapido2();
                nomeAntigo = "";
            }
            if (tbcFada.SelectedIndex == 1)
            {
                this.Text = "Cadastro/Editor de Fada";
                rbCadastroRapido1.Checked = false;
                rbCadastroRapido2.Checked = false;
                LimparCamposCadastroRapido1();
                LimparCamposCadastroRapido2();
                nomeAntigo = "";
            }
            if (tbcFada.SelectedIndex == 2)
            {
                this.Text = "Cadastro Rápido de Fada";
                rbCadastroRapido1.Checked = false;
                rbCadastroRapido2.Checked = false;
                LimparCampos();
                nomeAntigo = "";
            }
        }

        private void btnCadastroRapido_Click(object sender, EventArgs e)
        {
            tbcFada.SelectedIndex = 2;
        }

        private void rbCadastroRapido1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCadastroRapido1.Checked == true)
            {
                gbCadastroRapido1.Enabled = true;
                LimparCamposCadastroRapido2();
            }
            if (rbCadastroRapido1.Checked == false)
            {
                gbCadastroRapido1.Enabled = false;
            }
        }

        private void rbCadastroRapido2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCadastroRapido2.Checked == true)
            {
                gbCadastroRapido2.Enabled = true;
                LimparCamposCadastroRapido1();
            }
            if (rbCadastroRapido2.Checked == false)
            {
                gbCadastroRapido2.Enabled = false;
            }
        }

        private void btnSalvarCadastroRapido1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeRapido1.Text))
                {
                    MessageBox.Show("Nome deve ser preenchido");
                    txtNomeRapido1.Focus();
                    return;
                }

                if (txtNomeRapido1.Text.Count() < 3)
                {
                    MessageBox.Show("Nome deve conter pelo menos 3 caracteres");
                    txtNomeRapido1.Focus();
                    return;
                }

                if (txtNomeRapido1.Text.Count() > 150)
                {
                    MessageBox.Show("Nome deve conter no máximo 150 caracteres");
                    txtNomeRapido1.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtFamiliaRapido1.Text))
                {
                    MessageBox.Show("Família deve ser preenchida");
                    txtFamiliaRapido1.Focus();
                    return;
                }

                if (txtFamiliaRapido1.Text.Count() < 4)
                {
                    MessageBox.Show("Família deve conter pelo menos 4 caracteres");
                    txtFamiliaRapido1.Focus();
                    return;
                }

                if (txtFamiliaRapido1.Text.Count() > 50)
                {
                    MessageBox.Show("Família deve conter no máximo 50 caracteres");
                    txtFamiliaRapido1.Focus();
                    return;
                }

                if (cbCorRapido1.SelectedItem == null || string.IsNullOrEmpty(cbCorRapido1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Selecione uma cor");
                    cbCorRapido1.DroppedDown = true;
                    return;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }

            try
            {
                Fada fada = new Fada(txtNomeRapido1.Text, txtFamiliaRapido1.Text, cbCorRapido1.SelectedItem.ToString())
                    {
                        CodigoCadastro = 1
                    };
                if (nomeAntigo == "")
                {
                    fadas.Add(fada);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarFadaATabela(fada);
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[linha] = fada;
                    EditarFadaNaTabela(fada, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }
                LimparCamposCadastroRapido1();
                rbCadastroRapido1.Checked = false;
                rbCadastroRapido2.Checked = false;
                tbcFada.SelectedIndex = 0;
                lblQuantidadeFadas.Text = dgvFadas.Rows.Count.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }
        }

        private void btnSalvarCadastroRapido2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeRapido2.Text))
                {
                    MessageBox.Show("Nome deve ser preenchido");
                    txtNomeRapido2.Focus();
                    return;
                }

                if (txtNomeRapido2.Text.Count() < 3)
                {
                    MessageBox.Show("Nome deve conter pelo menos 3 caracteres");
                    txtNomeRapido2.Focus();
                    return;
                }

                if (txtNomeRapido2.Text.Count() > 150)
                {
                    MessageBox.Show("Nome deve conter no máximo 150 caracteres");
                    txtNomeRapido2.Focus();
                    return;
                }

                if (cbCorRapido2.SelectedItem == null || string.IsNullOrEmpty(cbCorRapido2.SelectedItem.ToString()))
                {
                    MessageBox.Show("Selecione uma cor");
                    cbCorRapido2.DroppedDown = true;
                    return;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

            try
            {
                Fada fada = new Fada(txtNomeRapido2.Text, cbCorRapido2.SelectedItem.ToString(), chkMulherRapido2.Checked)
                    {
                        CodigoCadastro = 2
                    };
                if (nomeAntigo == "")
                {
                    fadas.Add(fada);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarFadaATabela(fada);
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[linha] = fada;
                    EditarFadaNaTabela(fada, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }
                LimparCamposCadastroRapido2();
                rbCadastroRapido1.Checked = false;
                rbCadastroRapido2.Checked = false;
                tbcFada.SelectedIndex = 0;
                lblQuantidadeFadas.Text = dgvFadas.Rows.Count.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelarCadastroRapido1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar o registro?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                LimparCamposCadastroRapido1();
                rbCadastroRapido1.Enabled = true;
                rbCadastroRapido2.Enabled = true;
                nomeAntigo = "";
                tbcFada.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Cadastro não cancelado.");
            }
        }

        private void btnCancelarCadastroRapido2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar o registro?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                LimparCamposCadastroRapido2();
                rbCadastroRapido1.Enabled = true;
                rbCadastroRapido2.Enabled = true;
                nomeAntigo = "";
                tbcFada.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Cadastro não cancelado.");
            }
        }

        private void LimparCamposCadastroRapido1()
        {
            txtNomeRapido1.Text = "";
            txtFamiliaRapido1.Text = "";
            cbCorRapido1.SelectedIndex = -1;
        }

        private void LimparCamposCadastroRapido2()
        {
            txtNomeRapido2.Text = "";
            cbCorRapido2.SelectedIndex = -1;
            chkMulherRapido2.Checked = false;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvFadas.Rows.Clear();
                string busca = txtBuscar.Text.ToLower();
                for (int i = 0; i < fadas.Count; i++)
                {
                    Fada fada = fadas[i];
                    if ((fada.Nome.ToLower().Contains(busca)))
                    {
                        dgvFadas.Rows.Add(new object[]{
                        fada.CodigoCadastro, fada.Nome, fada.Cor
                    });
                    }
                }
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFamilia.Focus();
            }
        }

        private void txtFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCor.DroppedDown = true;
            }
        }

        private void cbCor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCorAsa.DroppedDown = true;
            }
        }

        private void cbCorAsa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTamanhoAsa.Focus();
            }
        }

        private void txtTamanhoAsa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkAsaQuebrada.Focus();
            }
        }

        private void chkMulher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkFazBarulho.Focus();
            }
        }

        private void chkAsaQuebrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkMulher.Focus();
            }
        }

        private void chkFazBarulho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbElemento.DroppedDown = true;
            }
        }

        private void cbElemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }

        private void txtNomeRapido1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFamiliaRapido1.Focus();
            }
        }

        private void txtFamiliaRapido1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCorRapido1.DroppedDown = true;
            }
        }

        private void cbCorRapido1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvarCadastroRapido1.PerformClick();
            }
        }

        private void txtNomeRapido2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCorRapido2.DroppedDown = true;
            }
        }

        private void cbCorRapido2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkMulherRapido2.Focus();
            }
        }

        private void chkMulherRapido2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvarCadastroRapido2.PerformLayout();
            }
        }
    }
}
