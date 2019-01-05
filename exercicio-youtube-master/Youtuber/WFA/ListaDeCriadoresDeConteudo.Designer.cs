namespace WFA
{
    partial class ListaDeCriadoresDeConteudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeCriadoresDeConteudo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dgvListaYoutubers = new System.Windows.Forms.DataGridView();
            this.CodigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCriadorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCanalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeInscritoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NacionalidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaYoutubers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(79, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(408, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(512, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 50);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(618, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 50);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(724, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(100, 50);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(830, 12);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(122, 50);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dgvListaYoutubers
            // 
            this.dgvListaYoutubers.AllowUserToAddRows = false;
            this.dgvListaYoutubers.AllowUserToDeleteRows = false;
            this.dgvListaYoutubers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaYoutubers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoColumn,
            this.NomeCriadorColumn,
            this.NomeCanalColumn,
            this.QuantidadeInscritoColumn,
            this.NacionalidadeColumn});
            this.dgvListaYoutubers.Location = new System.Drawing.Point(12, 68);
            this.dgvListaYoutubers.Name = "dgvListaYoutubers";
            this.dgvListaYoutubers.ReadOnly = true;
            this.dgvListaYoutubers.Size = new System.Drawing.Size(943, 365);
            this.dgvListaYoutubers.TabIndex = 6;
            // 
            // CodigoColumn
            // 
            this.CodigoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodigoColumn.HeaderText = "Código";
            this.CodigoColumn.Name = "CodigoColumn";
            this.CodigoColumn.ReadOnly = true;
            // 
            // NomeCriadorColumn
            // 
            this.NomeCriadorColumn.HeaderText = "Nome";
            this.NomeCriadorColumn.Name = "NomeCriadorColumn";
            this.NomeCriadorColumn.ReadOnly = true;
            this.NomeCriadorColumn.Width = 180;
            // 
            // NomeCanalColumn
            // 
            this.NomeCanalColumn.HeaderText = "Nome Canal";
            this.NomeCanalColumn.Name = "NomeCanalColumn";
            this.NomeCanalColumn.ReadOnly = true;
            this.NomeCanalColumn.Width = 200;
            // 
            // QuantidadeInscritoColumn
            // 
            this.QuantidadeInscritoColumn.HeaderText = "Quantidade Inscritos";
            this.QuantidadeInscritoColumn.Name = "QuantidadeInscritoColumn";
            this.QuantidadeInscritoColumn.ReadOnly = true;
            this.QuantidadeInscritoColumn.Width = 170;
            // 
            // NacionalidadeColumn
            // 
            this.NacionalidadeColumn.HeaderText = "Nacionalidade";
            this.NacionalidadeColumn.Name = "NacionalidadeColumn";
            this.NacionalidadeColumn.ReadOnly = true;
            this.NacionalidadeColumn.Width = 200;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(902, 445);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(50, 18);
            this.lblContador.TabIndex = 7;
            this.lblContador.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contador de pessoas:";
            // 
            // ListaDeCriadoresDeConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.dgvListaYoutubers);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaDeCriadoresDeConteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criadores De Conteúdo";
            this.Activated += new System.EventHandler(this.ListaDeCriadoresDeConteudo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaYoutubers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dgvListaYoutubers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCriadorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCanalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeInscritoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NacionalidadeColumn;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label2;
    }
}