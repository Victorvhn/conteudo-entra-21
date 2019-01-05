namespace SistemaEscola
{
    partial class usProduto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbLivro = new System.Windows.Forms.GroupBox();
            this.dtpAnoDeLancamento = new System.Windows.Forms.DateTimePicker();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.cbCapa = new System.Windows.Forms.ComboBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.dtpDataDeEntrada = new System.Windows.Forms.DateTimePicker();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBuscarProduto = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.ColumnNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Setor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data de Entrada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ano de Lançamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome Autor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Capa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Disciplina:";
            // 
            // gbLivro
            // 
            this.gbLivro.Controls.Add(this.dtpAnoDeLancamento);
            this.gbLivro.Controls.Add(this.cbDisciplina);
            this.gbLivro.Controls.Add(this.cbCapa);
            this.gbLivro.Controls.Add(this.txtNomeAutor);
            this.gbLivro.Controls.Add(this.txtNomeLivro);
            this.gbLivro.Controls.Add(this.label8);
            this.gbLivro.Controls.Add(this.label11);
            this.gbLivro.Controls.Add(this.label7);
            this.gbLivro.Controls.Add(this.label9);
            this.gbLivro.Controls.Add(this.label10);
            this.gbLivro.Enabled = false;
            this.gbLivro.Location = new System.Drawing.Point(35, 90);
            this.gbLivro.Name = "gbLivro";
            this.gbLivro.Size = new System.Drawing.Size(799, 142);
            this.gbLivro.TabIndex = 11;
            this.gbLivro.TabStop = false;
            this.gbLivro.Text = "Livro";
            // 
            // dtpAnoDeLancamento
            // 
            this.dtpAnoDeLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnoDeLancamento.Location = new System.Drawing.Point(428, 90);
            this.dtpAnoDeLancamento.Name = "dtpAnoDeLancamento";
            this.dtpAnoDeLancamento.Size = new System.Drawing.Size(200, 26);
            this.dtpAnoDeLancamento.TabIndex = 10;
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Items.AddRange(new object[] {
            "Português",
            "Matemática",
            "História",
            "Geografica",
            "Biologia",
            "Física",
            "Química",
            "Inglês",
            "Educação Artística",
            "Filosofia",
            "Sociologia"});
            this.cbDisciplina.Location = new System.Drawing.Point(96, 93);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(151, 26);
            this.cbDisciplina.TabIndex = 8;
            // 
            // cbCapa
            // 
            this.cbCapa.FormattingEnabled = true;
            this.cbCapa.Items.AddRange(new object[] {
            "Brochura",
            "Dura"});
            this.cbCapa.Location = new System.Drawing.Point(96, 61);
            this.cbCapa.Name = "cbCapa";
            this.cbCapa.Size = new System.Drawing.Size(151, 26);
            this.cbCapa.TabIndex = 7;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(428, 61);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(273, 26);
            this.txtNomeAutor.TabIndex = 9;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(96, 29);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(605, 26);
            this.txtNomeLivro.TabIndex = 6;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(92, 23);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(536, 26);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(380, 58);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 26);
            this.txtValorUnitario.TabIndex = 3;
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Items.AddRange(new object[] {
            "Biblioteca",
            "Refeitorio",
            "Secretaria",
            "Laboratorio"});
            this.cbSetor.Location = new System.Drawing.Point(92, 55);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(164, 26);
            this.cbSetor.TabIndex = 2;
            this.cbSetor.SelectedIndexChanged += new System.EventHandler(this.cbSetorProduto_SelectedIndexChanged);
            // 
            // dtpDataDeEntrada
            // 
            this.dtpDataDeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeEntrada.Location = new System.Drawing.Point(634, 58);
            this.dtpDataDeEntrada.Name = "dtpDataDeEntrada";
            this.dtpDataDeEntrada.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDeEntrada.TabIndex = 5;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(742, 23);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(92, 26);
            this.nudQuantidade.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(934, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(1096, 380);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1015, 379);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(853, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 385);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 18);
            this.label26.TabIndex = 21;
            this.label26.Text = "Buscar Produto:";
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.Location = new System.Drawing.Point(143, 382);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Size = new System.Drawing.Size(504, 26);
            this.txtBuscarProduto.TabIndex = 15;
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeProduto,
            this.ColumnQuantidade,
            this.ColumnDataEntrada,
            this.ColumnSetor});
            this.dgvProduto.Location = new System.Drawing.Point(7, 414);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(1164, 188);
            this.dgvProduto.TabIndex = 19;
            this.dgvProduto.DoubleClick += new System.EventHandler(this.dgvProduto_DoubleClick);
            // 
            // ColumnNomeProduto
            // 
            this.ColumnNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeProduto.HeaderText = "Nome";
            this.ColumnNomeProduto.Name = "ColumnNomeProduto";
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            // 
            // ColumnDataEntrada
            // 
            this.ColumnDataEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataEntrada.HeaderText = "Data Entrada";
            this.ColumnDataEntrada.Name = "ColumnDataEntrada";
            // 
            // ColumnSetor
            // 
            this.ColumnSetor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSetor.HeaderText = "Setor";
            this.ColumnSetor.Name = "ColumnSetor";
            // 
            // usProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBuscarProduto);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.dtpDataDeEntrada);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.gbLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usProduto";
            this.Size = new System.Drawing.Size(1178, 605);
            this.gbLivro.ResumeLayout(false);
            this.gbLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox gbLivro;
        public System.Windows.Forms.DateTimePicker dtpAnoDeLancamento;
        public System.Windows.Forms.ComboBox cbDisciplina;
        public System.Windows.Forms.ComboBox cbCapa;
        public System.Windows.Forms.TextBox txtNomeAutor;
        public System.Windows.Forms.TextBox txtNomeLivro;
        public System.Windows.Forms.TextBox txtNomeProduto;
        public System.Windows.Forms.TextBox txtValorUnitario;
        public System.Windows.Forms.ComboBox cbSetor;
        public System.Windows.Forms.DateTimePicker dtpDataDeEntrada;
        public System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBuscarProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSetor;
    }
}
