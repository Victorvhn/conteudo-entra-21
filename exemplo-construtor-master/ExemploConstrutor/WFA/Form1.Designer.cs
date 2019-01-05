namespace WFA
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtFaturamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPaisCadastroRapido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCadastroRapido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvarRapido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(64, 51);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(238, 26);
            this.txtPais.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "País";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Série";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(64, 96);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(238, 26);
            this.txtSerie.TabIndex = 5;
            // 
            // txtFaturamento
            // 
            this.txtFaturamento.Location = new System.Drawing.Point(354, 30);
            this.txtFaturamento.Name = "txtFaturamento";
            this.txtFaturamento.Size = new System.Drawing.Size(238, 26);
            this.txtFaturamento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Faturamento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(457, 123);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(135, 52);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPaisCadastroRapido
            // 
            this.txtPaisCadastroRapido.Location = new System.Drawing.Point(364, 258);
            this.txtPaisCadastroRapido.Name = "txtPaisCadastroRapido";
            this.txtPaisCadastroRapido.Size = new System.Drawing.Size(228, 26);
            this.txtPaisCadastroRapido.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "País";
            // 
            // txtNomeCadastroRapido
            // 
            this.txtNomeCadastroRapido.Location = new System.Drawing.Point(64, 258);
            this.txtNomeCadastroRapido.Name = "txtNomeCadastroRapido";
            this.txtNomeCadastroRapido.Size = new System.Drawing.Size(238, 26);
            this.txtNomeCadastroRapido.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nome";
            // 
            // btnSalvarRapido
            // 
            this.btnSalvarRapido.Location = new System.Drawing.Point(457, 290);
            this.btnSalvarRapido.Name = "btnSalvarRapido";
            this.btnSalvarRapido.Size = new System.Drawing.Size(135, 52);
            this.btnSalvarRapido.TabIndex = 13;
            this.btnSalvarRapido.Text = "Cadastro Rápido";
            this.btnSalvarRapido.UseVisualStyleBackColor = true;
            this.btnSalvarRapido.Click += new System.EventHandler(this.btnSalvarRapido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 362);
            this.Controls.Add(this.btnSalvarRapido);
            this.Controls.Add(this.txtPaisCadastroRapido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeCadastroRapido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtFaturamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtFaturamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPaisCadastroRapido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCadastroRapido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvarRapido;
    }
}

