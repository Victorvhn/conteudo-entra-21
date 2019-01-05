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
    public partial class CadastroCriadorConteudo : Form
    {
        private int codigoRegistro = -1;
        public int posicao = -1;
        private Youtuber youtuber;

        public CadastroCriadorConteudo()
        {
            InitializeComponent();
            /*AdicionarLabelObrigatoria(lbNome)
                .AdicionarLabelObrigatoria(lbSobrenome);*/
            if (codigoRegistro == -1)
            {
                lblcodigo.Visible = false;
                lbllblCodigo.Visible = false;
            }
        }

        public CadastroCriadorConteudo(int codigoRegistro)
        {
            InitializeComponent();
            this.codigoRegistro = codigoRegistro;
            YoutuberRepository repositorio = new YoutuberRepository();

            int quantidade = 0;
            for (int i = 0; i < repositorio.ObterYoutuber().Count(); i++)
            {
                Youtuber youtuber = repositorio.ObterYoutuber()[i];
                if (youtuber.GetCodigo() == codigoRegistro)
                {
                    lblcodigo.Text = youtuber.GetCodigo().ToString();
                    txtNome.Text = youtuber.GetNome();
                    txtSobrenome.Text = youtuber.GetSobrenome();
                    txtApelido.Text = youtuber.GetApelido();
                    chkStreamer.Checked = youtuber.GetStreamer();
                    cbNacionalidade.Text = youtuber.GetNacionalidade();
                    txtRenda.Text = youtuber.GetRenda().ToString();
                    chkAnuncio.Checked = youtuber.GetTemAnuncios();
                    chkPatrocinio.Checked = youtuber.GetTemPatrocinador();
                    txtNomeCanal.Text = youtuber.GetNomeCanal();
                    cbCategoria.Text = youtuber.GetCategoria();
                    txtLinkCanal.Text = youtuber.GetLinkCanal();
                    cbPlataforma.Text = youtuber.GetPlataforma();
                    nudQuantidadeVideos.Value = youtuber.GetQuantidadeVideos();
                    txtQuantidadeVisualizacoes.Text = youtuber.GetQuantidadeVisualizacoes().ToString();
                    txtQuantidadeInscritos.Text = youtuber.GetQuantidadeInscritos().ToString();
                    nudQuantidadeStrikes.Value = youtuber.GetQuantidadeStrikes();
                    txtQuantidadeLikes.Text = youtuber.GetQuantidadeLikes().ToString();
                    txtDescricao.Text = youtuber.GetDescricao();
                    return;
                }
                quantidade++;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarYoutube();
        }

        private void SalvarYoutube()
        {
            youtuber = new Youtuber();

            try
            {
                youtuber.SetNome(txtNome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNome.Focus();
                return;
            }

            try
            {
                youtuber.SetSobrenome(txtSobrenome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSobrenome.Focus();
                return;
            }

            try
            {
                youtuber.SetApelido(txtApelido.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtApelido.Focus();
                return;
            }

            if (cbNacionalidade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma nacionalidade.");
                cbNacionalidade.DroppedDown = true;
                return;
            }
            try
            {
                youtuber.SetNacionalidade(cbNacionalidade.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cbNacionalidade.DroppedDown = true;
                return;
            }

            try
            {
                youtuber.SetRenda(Convert.ToDouble(txtRenda.Text));
            }
            catch
            {
                MessageBox.Show("Preencha a renda com valores corretos.");
                txtRenda.Focus();
                return;
            }

            try
            {
                youtuber.SetNomeCanal(txtNomeCanal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNomeCanal.Focus();
                return;
            }

            if (cbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma categoria.");
                cbCategoria.DroppedDown = true;
                return;
            }
            try
            {
                youtuber.SetCategoria(cbCategoria.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cbCategoria.DroppedDown = true;
                return;
            }

            try
            {
                youtuber.SetLinkCanal(txtLinkCanal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtLinkCanal.Focus();
                return;
            }

            if (cbPlataforma.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma plataforma.");
                cbPlataforma.DroppedDown = true;
                return;
            }
            try
            {
                youtuber.SetPlataforma(cbPlataforma.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cbPlataforma.DroppedDown = true;
                return;
            }

            try
            {
                youtuber.SetQuantidadeVideos(Convert.ToInt32(nudQuantidadeVideos.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nudQuantidadeVideos.Focus();
                return;
            }

            try
            {
                youtuber.SetQuantidadeVisualizacoes(Convert.ToInt64(txtQuantidadeVisualizacoes.Text.Replace(".", "").Replace(",", "")));
            }
            catch
            {
                MessageBox.Show("Preencha a quantidade de visualizações com as informações corretar.");
                txtQuantidadeVisualizacoes.Focus();
                return;
            }

            try
            {
                youtuber.SetQuantidadeInscritos(Convert.ToInt64(txtQuantidadeInscritos.Text.Replace(".", "").Replace(",", "")));
            }
            catch
            {
                MessageBox.Show("Preencha a quantidade de inscritos com as informações corretar.");
                txtQuantidadeInscritos.Focus();
                return;
            }

            try
            {
                youtuber.SetQuantidadeStrikes(Convert.ToInt32(nudQuantidadeStrikes.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nudQuantidadeStrikes.Focus();
                return;
            }

            try
            {
                youtuber.SetQuantidadeLikes(Convert.ToInt64(txtQuantidadeLikes.Text.Replace(".", "").Replace(",", "")));
            }
            catch
            {
                MessageBox.Show("Preencha a quantidade de likes com as informações corretar.");
                txtQuantidadeLikes.Focus();
                return;
            }

            youtuber.SetTemAnuncios(chkAnuncio.Checked);

            try
            {
                youtuber.SetDescricao(txtDescricao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtDescricao.Focus();
                return;
            }

            if (chkPatrocinio.Checked)
            {
                youtuber.SetTemPatrocinador(true);
            }
            else
            {
                youtuber.SetTemPatrocinador(false);
            }

            if (chkStreamer.Checked)
            {
                youtuber.SetStreamer(true);
            }
            else
            {
                youtuber.SetStreamer(false);
            }

            YoutuberRepository tudo = new YoutuberRepository();
            if (codigoRegistro == -1)
            {
                tudo.AdicionarYoutuber(youtuber);
                MessageBox.Show("Youtuber cadastrado com sucesso");
            }
            else
            {
                youtuber.SetCodigo(codigoRegistro);
                tudo.EditarYoutuber(youtuber, codigoRegistro);
                MessageBox.Show("Youtuber alterado com sucesso");
                Dispose();
            }
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtApelido.Text = "";
            txtNome.Text = "";
            txtNomeCanal.Text = "";
            txtQuantidadeInscritos.Text = "";
            txtQuantidadeVisualizacoes.Text = "";
            txtQuantidadeLikes.Text = "";
            nudQuantidadeVideos.Value = 0;
            cbCategoria.SelectedIndex = -1;
            chkAnuncio.Checked = false;
            txtDescricao.Text = "";
            txtRenda.Text = "";
            cbNacionalidade.SelectedIndex = -1;
            chkPatrocinio.Checked = false;
            nudQuantidadeStrikes.Value = 0;
            cbPlataforma.SelectedIndex = -1;
            chkStreamer.Checked = false;
            txtLinkCanal.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar o registro?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSobrenome.Focus();
            }
        }

        private void txtSobrenome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApelido.Focus();
            }
        }

        private void txtApelido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbNacionalidade.DroppedDown = true;
            }
        }

        private void txtRenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNomeCanal.Focus();
            }
        }

        private void txtNomeCanal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCategoria.DroppedDown = true;
            }
        }

        private void txtLinkCanal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbPlataforma.DroppedDown = true;
            }
        }

        private void nudQuantidadeVideos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidadeVisualizacoes.Focus();           
            }
        }

        private void txtQuantidadeVisualizacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidadeInscritos.Focus();
            }
        }

        private void txtQuantidadeInscritos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudQuantidadeStrikes.Focus();
            }
        }

        private void nudQuantidadeStrikes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidadeLikes.Focus();
            }
        }

        private void txtQuantidadeLikes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }

        /*private CadastroCriadorConteudo AdicionarLabelObrigatoria(Label label)
        {
            Label labelObrigatoria = new Label();
            labelObrigatoria.ForeColor = Color.Red;
            labelObrigatoria.Text = "*";
            labelObrigatoria.Location = new Point(label.Location.X + label.Size.Width + 1, label.Location.Y);
            labelObrigatoria.Size = new Size(10, 10);
            groupBox1.Controls.Add(labelObrigatoria);
            return this;
        }*/
    }
}
