namespace Exercicios
{
    partial class Exercicio05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNomeCarro = new System.Windows.Forms.Label();
            this.mtbValorCarro = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCarro = new System.Windows.Forms.TextBox();
            this.lblValorCarro = new System.Windows.Forms.Label();
            this.lblValorParcelas = new System.Windows.Forms.Label();
            this.mtbValorParcelas = new System.Windows.Forms.MaskedTextBox();
            this.nudQuantidadeParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidadeParcelas = new System.Windows.Forms.Label();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.txtInformacoes = new System.Windows.Forms.TextBox();
            this.btnConferir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(699, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carro";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(13, 50);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(552, 23);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Informe os dados pedidos a baixo, para no final saber algumas informações.";
            // 
            // lblNomeCarro
            // 
            this.lblNomeCarro.AutoSize = true;
            this.lblNomeCarro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCarro.Location = new System.Drawing.Point(12, 93);
            this.lblNomeCarro.Name = "lblNomeCarro";
            this.lblNomeCarro.Size = new System.Drawing.Size(136, 22);
            this.lblNomeCarro.TabIndex = 2;
            this.lblNomeCarro.Text = "Nome do carro";
            // 
            // mtbValorCarro
            // 
            this.mtbValorCarro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValorCarro.Location = new System.Drawing.Point(29, 180);
            this.mtbValorCarro.Mask = "9999990,99";
            this.mtbValorCarro.Name = "mtbValorCarro";
            this.mtbValorCarro.Size = new System.Drawing.Size(100, 29);
            this.mtbValorCarro.TabIndex = 2;
            // 
            // txtNomeCarro
            // 
            this.txtNomeCarro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCarro.Location = new System.Drawing.Point(29, 118);
            this.txtNomeCarro.Name = "txtNomeCarro";
            this.txtNomeCarro.Size = new System.Drawing.Size(209, 29);
            this.txtNomeCarro.TabIndex = 1;
            // 
            // lblValorCarro
            // 
            this.lblValorCarro.AutoSize = true;
            this.lblValorCarro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCarro.Location = new System.Drawing.Point(12, 155);
            this.lblValorCarro.Name = "lblValorCarro";
            this.lblValorCarro.Size = new System.Drawing.Size(128, 22);
            this.lblValorCarro.TabIndex = 5;
            this.lblValorCarro.Text = "Valor do carro";
            // 
            // lblValorParcelas
            // 
            this.lblValorParcelas.AutoSize = true;
            this.lblValorParcelas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelas.Location = new System.Drawing.Point(12, 217);
            this.lblValorParcelas.Name = "lblValorParcelas";
            this.lblValorParcelas.Size = new System.Drawing.Size(166, 22);
            this.lblValorParcelas.TabIndex = 6;
            this.lblValorParcelas.Text = "Valor das parcelas";
            // 
            // mtbValorParcelas
            // 
            this.mtbValorParcelas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValorParcelas.Location = new System.Drawing.Point(29, 242);
            this.mtbValorParcelas.Mask = "9999990,99";
            this.mtbValorParcelas.Name = "mtbValorParcelas";
            this.mtbValorParcelas.Size = new System.Drawing.Size(100, 29);
            this.mtbValorParcelas.TabIndex = 3;
            // 
            // nudQuantidadeParcelas
            // 
            this.nudQuantidadeParcelas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidadeParcelas.Location = new System.Drawing.Point(29, 304);
            this.nudQuantidadeParcelas.Name = "nudQuantidadeParcelas";
            this.nudQuantidadeParcelas.Size = new System.Drawing.Size(120, 29);
            this.nudQuantidadeParcelas.TabIndex = 4;
            this.nudQuantidadeParcelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudQuantidadeParcelas_KeyDown);
            // 
            // lblQuantidadeParcelas
            // 
            this.lblQuantidadeParcelas.AutoSize = true;
            this.lblQuantidadeParcelas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeParcelas.Location = new System.Drawing.Point(12, 279);
            this.lblQuantidadeParcelas.Name = "lblQuantidadeParcelas";
            this.lblQuantidadeParcelas.Size = new System.Drawing.Size(211, 22);
            this.lblQuantidadeParcelas.TabIndex = 9;
            this.lblQuantidadeParcelas.Text = "Quantidade de parcelas";
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(294, 93);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(117, 22);
            this.lblInformacao.TabIndex = 10;
            this.lblInformacao.Text = "Informações";
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacoes.Location = new System.Drawing.Point(311, 118);
            this.txtInformacoes.Multiline = true;
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.ReadOnly = true;
            this.txtInformacoes.Size = new System.Drawing.Size(385, 219);
            this.txtInformacoes.TabIndex = 11;
            this.txtInformacoes.TabStop = false;
            // 
            // btnConferir
            // 
            this.btnConferir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferir.Location = new System.Drawing.Point(16, 355);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(152, 44);
            this.btnConferir.TabIndex = 5;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 416);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.txtInformacoes);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.lblQuantidadeParcelas);
            this.Controls.Add(this.nudQuantidadeParcelas);
            this.Controls.Add(this.mtbValorParcelas);
            this.Controls.Add(this.lblValorParcelas);
            this.Controls.Add(this.lblValorCarro);
            this.Controls.Add(this.txtNomeCarro);
            this.Controls.Add(this.mtbValorCarro);
            this.Controls.Add(this.lblNomeCarro);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 05";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNomeCarro;
        private System.Windows.Forms.MaskedTextBox mtbValorCarro;
        private System.Windows.Forms.TextBox txtNomeCarro;
        private System.Windows.Forms.Label lblValorCarro;
        private System.Windows.Forms.Label lblValorParcelas;
        private System.Windows.Forms.MaskedTextBox mtbValorParcelas;
        private System.Windows.Forms.NumericUpDown nudQuantidadeParcelas;
        private System.Windows.Forms.Label lblQuantidadeParcelas;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.TextBox txtInformacoes;
        private System.Windows.Forms.Button btnConferir;
    }
}