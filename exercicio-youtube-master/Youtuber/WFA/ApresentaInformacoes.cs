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
    public partial class ApresentaInformacoes : Form
    {
        private int codigoRegistro = -1;

        public ApresentaInformacoes()
        {
            InitializeComponent();
        }

        string linkCanal = "";
        public ApresentaInformacoes(int codigoRegistro)
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
                    lblCodigo.Text = youtuber.GetCodigo().ToString();
                    lblNome.Text = youtuber.GetNome();
                    lblSobrenome.Text = youtuber.GetSobrenome();
                    lblApelido.Text = youtuber.GetApelido();
                    chkStreamer.Checked = youtuber.GetStreamer();
                    lblNacionalidade.Text = youtuber.GetNacionalidade();
                    lblRenda.Text = youtuber.GetRenda().ToString();
                    chkAnuncio.Checked = youtuber.GetTemAnuncios();
                    chkPatrocinio.Checked = youtuber.GetTemPatrocinador();
                    lblNomeCanal.Text = youtuber.GetNomeCanal();
                    lblCategoria.Text = youtuber.GetCategoria();
                    lnkLinkCanal.Text = youtuber.GetLinkCanal();
                    lblPlataforma.Text = youtuber.GetPlataforma();
                    lblQuantidadeVideos.Text = youtuber.GetQuantidadeVideos().ToString();
                    lblQuantidadeVisualizacoes.Text = youtuber.GetQuantidadeVisualizacoes().ToString();
                    lblQuantidadeInscritos.Text = youtuber.GetQuantidadeInscritos().ToString();
                    lblQuantidadeStrikes.Text = youtuber.GetQuantidadeStrikes().ToString();
                    lblQuantidadeLikes.Text = youtuber.GetQuantidadeLikes().ToString();
                    lblDescricao.Text = youtuber.GetDescricao();
                    linkCanal = youtuber.GetLinkCanal();
                    lnkLinkCanal.Text = "Canal";
                    return;
                }
                quantidade++;
            }
        }

        private void lnkLinkCanal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkCanal);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
