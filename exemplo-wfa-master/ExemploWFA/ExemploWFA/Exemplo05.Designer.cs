namespace ExemploWFA
{
    partial class Exemplo05
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
            this.cbVoceComprouWinRar = new System.Windows.Forms.CheckBox();
            this.cbConfirmaQueLeuTudo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVoceComprouWinRar
            // 
            this.cbVoceComprouWinRar.AutoSize = true;
            this.cbVoceComprouWinRar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVoceComprouWinRar.Location = new System.Drawing.Point(12, 44);
            this.cbVoceComprouWinRar.Name = "cbVoceComprouWinRar";
            this.cbVoceComprouWinRar.Size = new System.Drawing.Size(252, 26);
            this.cbVoceComprouWinRar.TabIndex = 0;
            this.cbVoceComprouWinRar.Text = "Voce Comprou o WinRar?";
            this.cbVoceComprouWinRar.UseVisualStyleBackColor = true;
            // 
            // cbConfirmaQueLeuTudo
            // 
            this.cbConfirmaQueLeuTudo.AutoSize = true;
            this.cbConfirmaQueLeuTudo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirmaQueLeuTudo.Location = new System.Drawing.Point(12, 12);
            this.cbConfirmaQueLeuTudo.Name = "cbConfirmaQueLeuTudo";
            this.cbConfirmaQueLeuTudo.Size = new System.Drawing.Size(226, 26);
            this.cbConfirmaQueLeuTudo.TabIndex = 1;
            this.cbConfirmaQueLeuTudo.Text = "Confirma que leu tudo?";
            this.cbConfirmaQueLeuTudo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(67, 76);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 58);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Exemplo05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 150);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbConfirmaQueLeuTudo);
            this.Controls.Add(this.cbVoceComprouWinRar);
            this.Name = "Exemplo05";
            this.Text = "Exemplo05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbVoceComprouWinRar;
        private System.Windows.Forms.CheckBox cbConfirmaQueLeuTudo;
        private System.Windows.Forms.Button btnSalvar;
    }
}