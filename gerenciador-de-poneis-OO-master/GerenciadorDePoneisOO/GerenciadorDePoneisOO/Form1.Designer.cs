namespace GerenciadorDePoneisOO
{
    partial class CadastroPoneis
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
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.tbNivelFofura = new System.Windows.Forms.TrackBar();
            this.lblNivelFofura = new System.Windows.Forms.Label();
            this.lblCorCrista = new System.Windows.Forms.Label();
            this.cbCorCrista = new System.Windows.Forms.ComboBox();
            this.rbVivo = new System.Windows.Forms.RadioButton();
            this.rbMorto = new System.Windows.Forms.RadioButton();
            this.cbDancarino = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLocalidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPoneis = new System.Windows.Forms.DataGridView();
            this.ColumnApelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbNivelFofura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoneis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(77, 55);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(75, 22);
            this.lblApelido.TabIndex = 0;
            this.lblApelido.Text = "Apelido";
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.Location = new System.Drawing.Point(158, 52);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(293, 29);
            this.txtApelido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(98, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raça";
            // 
            // cbRaca
            // 
            this.cbRaca.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Fofo nível Estagiário",
            "Fofo nível Master",
            "Fofo nível Senior",
            "Fofo nível Pleno"});
            this.cbRaca.Location = new System.Drawing.Point(158, 86);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(293, 30);
            this.cbRaca.TabIndex = 3;
            // 
            // tbNivelFofura
            // 
            this.tbNivelFofura.AutoSize = false;
            this.tbNivelFofura.Location = new System.Drawing.Point(158, 124);
            this.tbNivelFofura.Maximum = 100;
            this.tbNivelFofura.Minimum = 25;
            this.tbNivelFofura.Name = "tbNivelFofura";
            this.tbNivelFofura.Size = new System.Drawing.Size(293, 22);
            this.tbNivelFofura.TabIndex = 4;
            this.tbNivelFofura.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbNivelFofura.Value = 25;
            // 
            // lblNivelFofura
            // 
            this.lblNivelFofura.AutoSize = true;
            this.lblNivelFofura.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblNivelFofura.Location = new System.Drawing.Point(12, 124);
            this.lblNivelFofura.Name = "lblNivelFofura";
            this.lblNivelFofura.Size = new System.Drawing.Size(139, 22);
            this.lblNivelFofura.TabIndex = 5;
            this.lblNivelFofura.Text = "Nível da Fofura";
            // 
            // lblCorCrista
            // 
            this.lblCorCrista.AutoSize = true;
            this.lblCorCrista.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblCorCrista.Location = new System.Drawing.Point(57, 151);
            this.lblCorCrista.Name = "lblCorCrista";
            this.lblCorCrista.Size = new System.Drawing.Size(95, 22);
            this.lblCorCrista.TabIndex = 6;
            this.lblCorCrista.Text = "Cor Crista";
            // 
            // cbCorCrista
            // 
            this.cbCorCrista.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorCrista.FormattingEnabled = true;
            this.cbCorCrista.Items.AddRange(new object[] {
            "Rosê",
            "Pink",
            "Fushia",
            "Magenta"});
            this.cbCorCrista.Location = new System.Drawing.Point(158, 148);
            this.cbCorCrista.Name = "cbCorCrista";
            this.cbCorCrista.Size = new System.Drawing.Size(293, 30);
            this.cbCorCrista.TabIndex = 7;
            // 
            // rbVivo
            // 
            this.rbVivo.AutoSize = true;
            this.rbVivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVivo.Location = new System.Drawing.Point(158, 184);
            this.rbVivo.Name = "rbVivo";
            this.rbVivo.Size = new System.Drawing.Size(65, 26);
            this.rbVivo.TabIndex = 8;
            this.rbVivo.TabStop = true;
            this.rbVivo.Text = "Vivo";
            this.rbVivo.UseVisualStyleBackColor = true;
            // 
            // rbMorto
            // 
            this.rbMorto.AutoSize = true;
            this.rbMorto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMorto.Location = new System.Drawing.Point(158, 216);
            this.rbMorto.Name = "rbMorto";
            this.rbMorto.Size = new System.Drawing.Size(76, 26);
            this.rbMorto.TabIndex = 9;
            this.rbMorto.TabStop = true;
            this.rbMorto.Text = "Morto";
            this.rbMorto.UseVisualStyleBackColor = true;
            // 
            // cbDancarino
            // 
            this.cbDancarino.AutoSize = true;
            this.cbDancarino.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDancarino.Location = new System.Drawing.Point(258, 201);
            this.cbDancarino.Name = "cbDancarino";
            this.cbDancarino.Size = new System.Drawing.Size(104, 26);
            this.cbDancarino.TabIndex = 10;
            this.cbDancarino.Text = "Dançario";
            this.cbDancarino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Localidade";
            // 
            // cbLocalidade
            // 
            this.cbLocalidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalidade.FormattingEnabled = true;
            this.cbLocalidade.Items.AddRange(new object[] {
            "Poneisladia",
            "PoneiCity",
            "MetroPonei",
            "NovaPonei"});
            this.cbLocalidade.Location = new System.Drawing.Point(158, 244);
            this.cbLocalidade.Name = "cbLocalidade";
            this.cbLocalidade.Size = new System.Drawing.Size(293, 30);
            this.cbLocalidade.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(158, 286);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(293, 157);
            this.rtbDescricao.TabIndex = 14;
            this.rtbDescricao.Text = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(319, 449);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 35);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(787, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cadastrar Ponei";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPoneis
            // 
            this.dgvPoneis.AllowUserToAddRows = false;
            this.dgvPoneis.AllowUserToDeleteRows = false;
            this.dgvPoneis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoneis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnApelido,
            this.ColumnRaca});
            this.dgvPoneis.Location = new System.Drawing.Point(464, 86);
            this.dgvPoneis.Name = "dgvPoneis";
            this.dgvPoneis.ReadOnly = true;
            this.dgvPoneis.Size = new System.Drawing.Size(344, 357);
            this.dgvPoneis.TabIndex = 17;
            // 
            // ColumnApelido
            // 
            this.ColumnApelido.HeaderText = "Apelido";
            this.ColumnApelido.Name = "ColumnApelido";
            this.ColumnApelido.ReadOnly = true;
            this.ColumnApelido.Width = 150;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            this.ColumnRaca.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "PONEIS CADASTRADOS";
            // 
            // CadastroPoneis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPoneis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLocalidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDancarino);
            this.Controls.Add(this.rbMorto);
            this.Controls.Add(this.rbVivo);
            this.Controls.Add(this.cbCorCrista);
            this.Controls.Add(this.lblCorCrista);
            this.Controls.Add(this.lblNivelFofura);
            this.Controls.Add(this.tbNivelFofura);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblApelido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroPoneis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Poneis";
            ((System.ComponentModel.ISupportInitialize)(this.tbNivelFofura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoneis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.TrackBar tbNivelFofura;
        private System.Windows.Forms.Label lblNivelFofura;
        private System.Windows.Forms.Label lblCorCrista;
        private System.Windows.Forms.ComboBox cbCorCrista;
        private System.Windows.Forms.RadioButton rbVivo;
        private System.Windows.Forms.RadioButton rbMorto;
        private System.Windows.Forms.CheckBox cbDancarino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLocalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPoneis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.Label label5;
    }
}

