namespace SistemaEscola
{
    partial class TelaAjuda
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
            this.btn_EsqueciSenha = new System.Windows.Forms.Button();
            this.btn_SugestaoBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EsqueciSenha
            // 
            this.btn_EsqueciSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EsqueciSenha.Location = new System.Drawing.Point(12, 37);
            this.btn_EsqueciSenha.Name = "btn_EsqueciSenha";
            this.btn_EsqueciSenha.Size = new System.Drawing.Size(141, 66);
            this.btn_EsqueciSenha.TabIndex = 1;
            this.btn_EsqueciSenha.Text = "Esqueci a Senha";
            this.btn_EsqueciSenha.UseVisualStyleBackColor = true;
            this.btn_EsqueciSenha.Click += new System.EventHandler(this.btn_EsqueciSenha_Click);
            // 
            // btn_SugestaoBug
            // 
            this.btn_SugestaoBug.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SugestaoBug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SugestaoBug.Location = new System.Drawing.Point(179, 37);
            this.btn_SugestaoBug.Name = "btn_SugestaoBug";
            this.btn_SugestaoBug.Size = new System.Drawing.Size(136, 66);
            this.btn_SugestaoBug.TabIndex = 2;
            this.btn_SugestaoBug.Text = "Sugestão/Bug";
            this.btn_SugestaoBug.UseVisualStyleBackColor = true;
            this.btn_SugestaoBug.Click += new System.EventHandler(this.btn_SugestaoBug_Click);
            // 
            // TelaAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 137);
            this.Controls.Add(this.btn_SugestaoBug);
            this.Controls.Add(this.btn_EsqueciSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaAjuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ajuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_EsqueciSenha;
        private System.Windows.Forms.Button btn_SugestaoBug;

    }
}