﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuGuardaRoupa
{
    public partial class CadastroPeca : Form
    {
        private Peca peca;
        private int posicao = -1;

        public CadastroPeca()
        {
            InitializeComponent();
            for (int i = 8; i <= 60; i++)
            {
                cbTamanho.Items.Add(i);
            }
        }

        public CadastroPeca(Peca peca, int posicao)
        {
            InitializeComponent();
            for (int i = 8; i <= 60; i++)
            {
                cbTamanho.Items.Add(i);
            }

            this.posicao = posicao;

            txtNome.Text = peca.Nome;
            txtValor.Text = Convert.ToString(peca.Valor);
            cbCor.SelectedItem = peca.Cor;
            cbMarca.SelectedItem = peca.Marca;
            //cbTamanho.SelectedItem = peca.Tamanho;
            cbTamanho.Text = peca.Tamanho;
            cbTecido.SelectedItem = peca.Tecido;
            cbTipo.SelectedItem = peca.Tipo;
            dtpDataDaCompra.Value = peca.DataCompra;
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter no mínimo 4 caracteres!");
                txtNome.Focus();
                return;
            }

            if (cbTipo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o Tipo da peça!");
                cbTipo.DroppedDown = true;
                return;
            }

            if (cbTamanho.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o Tamanho da peça!");
                cbTamanho.DroppedDown = true;
                return;
            }
            
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Valor deve ser preenchido");
                txtValor.Focus();
                return;
            }
            try
            {
                double valor = Convert.ToDouble(txtValor.Text);
            }
            catch
            {
                MessageBox.Show("Valor deve conter somente números reais!");
                txtValor.Focus();
                return;
            }

            if (cbMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a Marca!");
                cbMarca.DroppedDown = true;
                return;
            }

            if (cbCor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a Cor!");
                cbCor.DroppedDown = true;
                return;
            }

            if (cbTecido.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o Tecido!");
                cbTecido.DroppedDown = true;
                return;
            }

            if (dtpDataDaCompra.Value >= DateTime.Now)
            {
                MessageBox.Show("Data da compra deve ser hoje ou uma data anterior");
                dtpDataDaCompra.Focus();
                return;
            }

            Peca peca = new Peca()
            {                
                Nome = txtNome.Text,
                Cor = cbCor.SelectedItem.ToString(),
                Marca = cbMarca.SelectedItem.ToString(),
                Tamanho = cbTamanho.SelectedItem.ToString(),
                Tipo = cbTipo.SelectedItem.ToString(),
                Valor = Convert.ToDouble(txtValor.Text),
                Tecido = cbTecido.SelectedItem.ToString(),
                DataCompra = dtpDataDaCompra.Value,
                Ativo = rbAtivo.Checked
            };

            if (posicao >= 0)
            {
                Program.pecas[posicao] = peca;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            else
            {
                Program.pecas.Add(peca);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }            
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtValor.Text = "";
            cbCor.SelectedIndex = -1;
            cbTecido.SelectedIndex = -1;
            cbTamanho.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            dtpDataDaCompra.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
