namespace ExemploBancoDados02
{
    partial class ListaHerois
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContaBancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.gbColuna = new System.Windows.Forms.GroupBox();
            this.rbColunaContaBancaria = new System.Windows.Forms.RadioButton();
            this.rbColunaRaca = new System.Windows.Forms.RadioButton();
            this.rbColunaNome = new System.Windows.Forms.RadioButton();
            this.gbOrdem = new System.Windows.Forms.GroupBox();
            this.rbOrdemDesc = new System.Windows.Forms.RadioButton();
            this.rbOrdemAsc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbColuna.SuspendLayout();
            this.gbOrdem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnRaca,
            this.ColumnContaBancaria});
            this.dgvLista.Location = new System.Drawing.Point(13, 72);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(741, 376);
            this.dgvLista.TabIndex = 1;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.FillWeight = 10.30928F;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            this.ColumnRaca.Width = 175;
            // 
            // ColumnContaBancaria
            // 
            this.ColumnContaBancaria.HeaderText = "Conta Bancária";
            this.ColumnContaBancaria.Name = "ColumnContaBancaria";
            this.ColumnContaBancaria.ReadOnly = true;
            this.ColumnContaBancaria.Width = 200;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(762, 127);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(106, 40);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(762, 68);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 40);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(762, 9);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 40);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(762, 186);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 40);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Location = new System.Drawing.Point(762, 245);
            this.btnEstatisticas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(106, 40);
            this.btnEstatisticas.TabIndex = 6;
            this.btnEstatisticas.Text = "Estatísticas";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(16, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(317, 26);
            this.txtPesquisa.TabIndex = 7;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // gbColuna
            // 
            this.gbColuna.Controls.Add(this.rbColunaContaBancaria);
            this.gbColuna.Controls.Add(this.rbColunaRaca);
            this.gbColuna.Controls.Add(this.rbColunaNome);
            this.gbColuna.Location = new System.Drawing.Point(339, 12);
            this.gbColuna.Name = "gbColuna";
            this.gbColuna.Size = new System.Drawing.Size(211, 53);
            this.gbColuna.TabIndex = 8;
            this.gbColuna.TabStop = false;
            this.gbColuna.Text = "Coluna";
            // 
            // rbColunaContaBancaria
            // 
            this.rbColunaContaBancaria.AutoSize = true;
            this.rbColunaContaBancaria.Location = new System.Drawing.Point(149, 22);
            this.rbColunaContaBancaria.Name = "rbColunaContaBancaria";
            this.rbColunaContaBancaria.Size = new System.Drawing.Size(49, 22);
            this.rbColunaContaBancaria.TabIndex = 2;
            this.rbColunaContaBancaria.Text = "CB";
            this.rbColunaContaBancaria.UseVisualStyleBackColor = true;
            this.rbColunaContaBancaria.CheckedChanged += new System.EventHandler(this.rbColunaContaBancaria_CheckedChanged);
            // 
            // rbColunaRaca
            // 
            this.rbColunaRaca.AutoSize = true;
            this.rbColunaRaca.Location = new System.Drawing.Point(80, 22);
            this.rbColunaRaca.Name = "rbColunaRaca";
            this.rbColunaRaca.Size = new System.Drawing.Size(63, 22);
            this.rbColunaRaca.TabIndex = 1;
            this.rbColunaRaca.Text = "Raça";
            this.rbColunaRaca.UseVisualStyleBackColor = true;
            this.rbColunaRaca.CheckedChanged += new System.EventHandler(this.rbColunaRaca_CheckedChanged);
            // 
            // rbColunaNome
            // 
            this.rbColunaNome.AutoSize = true;
            this.rbColunaNome.Checked = true;
            this.rbColunaNome.Location = new System.Drawing.Point(6, 22);
            this.rbColunaNome.Name = "rbColunaNome";
            this.rbColunaNome.Size = new System.Drawing.Size(68, 22);
            this.rbColunaNome.TabIndex = 0;
            this.rbColunaNome.TabStop = true;
            this.rbColunaNome.Text = "Nome";
            this.rbColunaNome.UseVisualStyleBackColor = true;
            this.rbColunaNome.CheckedChanged += new System.EventHandler(this.rbColunaNome_CheckedChanged);
            // 
            // gbOrdem
            // 
            this.gbOrdem.Controls.Add(this.rbOrdemDesc);
            this.gbOrdem.Controls.Add(this.rbOrdemAsc);
            this.gbOrdem.Location = new System.Drawing.Point(556, 12);
            this.gbOrdem.Name = "gbOrdem";
            this.gbOrdem.Size = new System.Drawing.Size(169, 53);
            this.gbOrdem.TabIndex = 9;
            this.gbOrdem.TabStop = false;
            this.gbOrdem.Text = "Ordenar";
            // 
            // rbOrdemDesc
            // 
            this.rbOrdemDesc.AutoSize = true;
            this.rbOrdemDesc.Location = new System.Drawing.Point(80, 22);
            this.rbOrdemDesc.Name = "rbOrdemDesc";
            this.rbOrdemDesc.Size = new System.Drawing.Size(72, 22);
            this.rbOrdemDesc.TabIndex = 1;
            this.rbOrdemDesc.Text = "DESC";
            this.rbOrdemDesc.UseVisualStyleBackColor = true;
            this.rbOrdemDesc.CheckedChanged += new System.EventHandler(this.rbOrdemDesc_CheckedChanged);
            // 
            // rbOrdemAsc
            // 
            this.rbOrdemAsc.AutoSize = true;
            this.rbOrdemAsc.Checked = true;
            this.rbOrdemAsc.Location = new System.Drawing.Point(6, 22);
            this.rbOrdemAsc.Name = "rbOrdemAsc";
            this.rbOrdemAsc.Size = new System.Drawing.Size(60, 22);
            this.rbOrdemAsc.TabIndex = 0;
            this.rbOrdemAsc.TabStop = true;
            this.rbOrdemAsc.Text = "ASC";
            this.rbOrdemAsc.UseVisualStyleBackColor = true;
            this.rbOrdemAsc.CheckedChanged += new System.EventHandler(this.rbOrdemAsc_CheckedChanged);
            // 
            // ListaHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 466);
            this.Controls.Add(this.gbOrdem);
            this.Controls.Add(this.gbColuna);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnEstatisticas);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaHerois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Heróis";
            this.Activated += new System.EventHandler(this.ListaHerois_Activated);
            this.Load += new System.EventHandler(this.ListaHerois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbColuna.ResumeLayout(false);
            this.gbColuna.PerformLayout();
            this.gbOrdem.ResumeLayout(false);
            this.gbOrdem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEstatisticas;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox gbColuna;
        private System.Windows.Forms.RadioButton rbColunaContaBancaria;
        private System.Windows.Forms.RadioButton rbColunaRaca;
        private System.Windows.Forms.RadioButton rbColunaNome;
        private System.Windows.Forms.GroupBox gbOrdem;
        private System.Windows.Forms.RadioButton rbOrdemDesc;
        private System.Windows.Forms.RadioButton rbOrdemAsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContaBancaria;
        private System.Windows.Forms.Button btnAtualizar;
    }
}