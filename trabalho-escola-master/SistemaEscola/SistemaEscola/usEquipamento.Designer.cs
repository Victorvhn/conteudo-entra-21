namespace SistemaEscola
{
    partial class usEquipamento
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
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataDeEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBuscarEquipamento = new System.Windows.Forms.TextBox();
            this.dgvEquipamento = new System.Windows.Forms.DataGridView();
            this.ColumnNomeEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSetorEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataEntradaEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data de Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Setor Utilizado:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(434, 60);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 26);
            this.nudQuantidade.TabIndex = 3;
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Items.AddRange(new object[] {
            "Sala de Aula",
            "Diretoria",
            "Refeitório",
            "Biblioteca",
            "Almoxerifado"});
            this.cbSetor.Location = new System.Drawing.Point(153, 97);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(154, 26);
            this.cbSetor.TabIndex = 4;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Bombastik",
            "Colorado",
            "AluminioBrilha",
            "Epsozisk",
            "Feiticeira"});
            this.cbMarca.Location = new System.Drawing.Point(153, 60);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(154, 26);
            this.cbMarca.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(481, 26);
            this.txtNome.TabIndex = 1;
            // 
            // dtpDataDeEntrada
            // 
            this.dtpDataDeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeEntrada.Location = new System.Drawing.Point(153, 134);
            this.dtpDataDeEntrada.Name = "dtpDataDeEntrada";
            this.dtpDataDeEntrada.Size = new System.Drawing.Size(154, 26);
            this.dtpDataDeEntrada.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(934, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(1096, 380);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1015, 379);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(853, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 385);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(158, 18);
            this.label26.TabIndex = 17;
            this.label26.Text = "Buscar Equipamento:";
            // 
            // txtBuscarEquipamento
            // 
            this.txtBuscarEquipamento.Location = new System.Drawing.Point(168, 382);
            this.txtBuscarEquipamento.Name = "txtBuscarEquipamento";
            this.txtBuscarEquipamento.Size = new System.Drawing.Size(504, 26);
            this.txtBuscarEquipamento.TabIndex = 6;
            this.txtBuscarEquipamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarEquipamento_KeyDown);
            // 
            // dgvEquipamento
            // 
            this.dgvEquipamento.AllowUserToAddRows = false;
            this.dgvEquipamento.AllowUserToDeleteRows = false;
            this.dgvEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeEquipamento,
            this.ColumnSetorEquipamento,
            this.ColumnQuantidadeEquipamento,
            this.ColumnDataEntradaEquipamento});
            this.dgvEquipamento.Location = new System.Drawing.Point(7, 414);
            this.dgvEquipamento.Name = "dgvEquipamento";
            this.dgvEquipamento.ReadOnly = true;
            this.dgvEquipamento.Size = new System.Drawing.Size(1164, 188);
            this.dgvEquipamento.TabIndex = 15;
            this.dgvEquipamento.DoubleClick += new System.EventHandler(this.dgvEquipamento_DoubleClick);
            // 
            // ColumnNomeEquipamento
            // 
            this.ColumnNomeEquipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeEquipamento.HeaderText = "Nome";
            this.ColumnNomeEquipamento.Name = "ColumnNomeEquipamento";
            this.ColumnNomeEquipamento.ReadOnly = true;
            // 
            // ColumnSetorEquipamento
            // 
            this.ColumnSetorEquipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSetorEquipamento.HeaderText = "Setor";
            this.ColumnSetorEquipamento.Name = "ColumnSetorEquipamento";
            this.ColumnSetorEquipamento.ReadOnly = true;
            // 
            // ColumnQuantidadeEquipamento
            // 
            this.ColumnQuantidadeEquipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnQuantidadeEquipamento.HeaderText = "Quantidade";
            this.ColumnQuantidadeEquipamento.Name = "ColumnQuantidadeEquipamento";
            this.ColumnQuantidadeEquipamento.ReadOnly = true;
            // 
            // ColumnDataEntradaEquipamento
            // 
            this.ColumnDataEntradaEquipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataEntradaEquipamento.HeaderText = "Data Entrada";
            this.ColumnDataEntradaEquipamento.Name = "ColumnDataEntradaEquipamento";
            this.ColumnDataEntradaEquipamento.ReadOnly = true;
            // 
            // usEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBuscarEquipamento);
            this.Controls.Add(this.dgvEquipamento);
            this.Controls.Add(this.dtpDataDeEntrada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usEquipamento";
            this.Size = new System.Drawing.Size(1178, 605);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpDataDeEntrada;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nudQuantidade;
        public System.Windows.Forms.ComboBox cbSetor;
        public System.Windows.Forms.ComboBox cbMarca;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBuscarEquipamento;
        private System.Windows.Forms.DataGridView dgvEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSetorEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataEntradaEquipamento;
    }
}
