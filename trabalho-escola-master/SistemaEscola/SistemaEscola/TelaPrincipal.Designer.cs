namespace SistemaEscola
{
    partial class TelaPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tpInicio = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tpInicio);
            this.tabPrincipal.Location = new System.Drawing.Point(13, 95);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1192, 640);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPrincipal_Selected);
            // 
            // tpInicio
            // 
            this.tpInicio.Location = new System.Drawing.Point(4, 27);
            this.tpInicio.Name = "tpInicio";
            this.tpInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tpInicio.Size = new System.Drawing.Size(1184, 609);
            this.tpInicio.TabIndex = 0;
            this.tpInicio.Text = "Início";
            this.tpInicio.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bem-Vindo, Usuário.";
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.Location = new System.Drawing.Point(30, 38);
            this.lblInformacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(281, 22);
            this.lblInformacoes.TabIndex = 2;
            this.lblInformacoes.Text = "Por favor, seleciona uma opção.";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 751);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabPrincipal);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escolar - Tela Principal";
            this.tabPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.TabPage tpInicio;
    }
}

