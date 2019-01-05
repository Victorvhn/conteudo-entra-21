namespace SistemaEscola
{
    partial class TelaSugestaoBug
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
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.txt_Menssagem = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.cb_Assunto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(124, 296);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(142, 41);
            this.btn_Enviar.TabIndex = 4;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Menssagem
            // 
            this.txt_Menssagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Menssagem.Location = new System.Drawing.Point(12, 133);
            this.txt_Menssagem.Multiline = true;
            this.txt_Menssagem.Name = "txt_Menssagem";
            this.txt_Menssagem.Size = new System.Drawing.Size(351, 143);
            this.txt_Menssagem.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(82, 48);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(223, 22);
            this.txt_Email.TabIndex = 1;
            // 
            // cb_Assunto
            // 
            this.cb_Assunto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Assunto.FormattingEnabled = true;
            this.cb_Assunto.Items.AddRange(new object[] {
            "",
            "Sugestão",
            "Reclamação",
            "Suporte",
            "Bug"});
            this.cb_Assunto.Location = new System.Drawing.Point(82, 86);
            this.cb_Assunto.Name = "cb_Assunto";
            this.cb_Assunto.Size = new System.Drawing.Size(133, 24);
            this.cb_Assunto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assunto";
            // 
            // TelaSugestaoBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Assunto);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Menssagem);
            this.Controls.Add(this.btn_Enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaSugestaoBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sugestao/Bug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.TextBox txt_Menssagem;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox cb_Assunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}