namespace Exercicio01
{
    partial class ListaAlunos
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbColunaMedia = new System.Windows.Forms.RadioButton();
            this.rbColunaNome = new System.Windows.Forms.RadioButton();
            this.rbColunaMatricula = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOrdenarDESC = new System.Windows.Forms.RadioButton();
            this.rbOrdenarASC = new System.Windows.Forms.RadioButton();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(33, 78);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(463, 26);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(825, 125);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 45);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(963, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escola do Francisco";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(825, 193);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 45);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(825, 261);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(150, 45);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(825, 329);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(150, 45);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.Location = new System.Drawing.Point(825, 397);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(150, 45);
            this.btnInformacoes.TabIndex = 7;
            this.btnInformacoes.Text = "Informações";
            this.btnInformacoes.UseVisualStyleBackColor = true;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumMatricula,
            this.ColumnNome,
            this.ColumnNota_1,
            this.ColumnNota_2,
            this.ColumnNota3,
            this.ColumnMedia});
            this.dgvAlunos.Location = new System.Drawing.Point(16, 123);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(803, 338);
            this.dgvAlunos.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbColunaMedia);
            this.groupBox1.Controls.Add(this.rbColunaNome);
            this.groupBox1.Controls.Add(this.rbColunaMatricula);
            this.groupBox1.Location = new System.Drawing.Point(518, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coluna";
            // 
            // rbColunaMedia
            // 
            this.rbColunaMedia.AutoSize = true;
            this.rbColunaMedia.Location = new System.Drawing.Point(172, 22);
            this.rbColunaMedia.Name = "rbColunaMedia";
            this.rbColunaMedia.Size = new System.Drawing.Size(70, 22);
            this.rbColunaMedia.TabIndex = 11;
            this.rbColunaMedia.TabStop = true;
            this.rbColunaMedia.Text = "Média";
            this.rbColunaMedia.UseVisualStyleBackColor = true;
            this.rbColunaMedia.CheckedChanged += new System.EventHandler(this.rbColunaMedia_CheckedChanged);
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
            // rbColunaMatricula
            // 
            this.rbColunaMatricula.AutoSize = true;
            this.rbColunaMatricula.Location = new System.Drawing.Point(80, 22);
            this.rbColunaMatricula.Name = "rbColunaMatricula";
            this.rbColunaMatricula.Size = new System.Drawing.Size(88, 22);
            this.rbColunaMatricula.TabIndex = 1;
            this.rbColunaMatricula.TabStop = true;
            this.rbColunaMatricula.Text = "Matrícula";
            this.rbColunaMatricula.UseVisualStyleBackColor = true;
            this.rbColunaMatricula.CheckedChanged += new System.EventHandler(this.rbColunaMatricula_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOrdenarDESC);
            this.groupBox2.Controls.Add(this.rbOrdenarASC);
            this.groupBox2.Location = new System.Drawing.Point(770, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar";
            // 
            // rbOrdenarDESC
            // 
            this.rbOrdenarDESC.AutoSize = true;
            this.rbOrdenarDESC.Location = new System.Drawing.Point(109, 22);
            this.rbOrdenarDESC.Name = "rbOrdenarDESC";
            this.rbOrdenarDESC.Size = new System.Drawing.Size(72, 22);
            this.rbOrdenarDESC.TabIndex = 13;
            this.rbOrdenarDESC.TabStop = true;
            this.rbOrdenarDESC.Text = "DESC";
            this.rbOrdenarDESC.UseVisualStyleBackColor = true;
            this.rbOrdenarDESC.CheckedChanged += new System.EventHandler(this.rbOrdenarDESC_CheckedChanged);
            // 
            // rbOrdenarASC
            // 
            this.rbOrdenarASC.AutoSize = true;
            this.rbOrdenarASC.Checked = true;
            this.rbOrdenarASC.Location = new System.Drawing.Point(28, 22);
            this.rbOrdenarASC.Name = "rbOrdenarASC";
            this.rbOrdenarASC.Size = new System.Drawing.Size(60, 22);
            this.rbOrdenarASC.TabIndex = 12;
            this.rbOrdenarASC.TabStop = true;
            this.rbOrdenarASC.Text = "ASC";
            this.rbOrdenarASC.UseVisualStyleBackColor = true;
            this.rbOrdenarASC.CheckedChanged += new System.EventHandler(this.rbOrdenarASC_CheckedChanged);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumMatricula
            // 
            this.ColumMatricula.HeaderText = "Matrícula";
            this.ColumMatricula.Name = "ColumMatricula";
            this.ColumMatricula.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnNota_1
            // 
            this.ColumnNota_1.HeaderText = "Nota 1";
            this.ColumnNota_1.Name = "ColumnNota_1";
            this.ColumnNota_1.ReadOnly = true;
            // 
            // ColumnNota_2
            // 
            this.ColumnNota_2.HeaderText = "Nota 2";
            this.ColumnNota_2.Name = "ColumnNota_2";
            this.ColumnNota_2.ReadOnly = true;
            // 
            // ColumnNota3
            // 
            this.ColumnNota3.HeaderText = "Nota 3";
            this.ColumnNota3.Name = "ColumnNota3";
            this.ColumnNota3.ReadOnly = true;
            // 
            // ColumnMedia
            // 
            this.ColumnMedia.HeaderText = "Média";
            this.ColumnMedia.Name = "ColumnMedia";
            this.ColumnMedia.ReadOnly = true;
            // 
            // ListaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnInformacoes);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Alunos";
            this.Activated += new System.EventHandler(this.ListaAlunos_Activated);
            this.Load += new System.EventHandler(this.ListaAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbColunaMedia;
        private System.Windows.Forms.RadioButton rbColunaNome;
        private System.Windows.Forms.RadioButton rbColunaMatricula;
        private System.Windows.Forms.RadioButton rbOrdenarDESC;
        private System.Windows.Forms.RadioButton rbOrdenarASC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedia;
    }
}

