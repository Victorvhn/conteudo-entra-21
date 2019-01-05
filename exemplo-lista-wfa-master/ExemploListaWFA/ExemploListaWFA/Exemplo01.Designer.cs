namespace ExemploListaWFA
{
    partial class Exemplo01
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.rtbNumero = new System.Windows.Forms.RichTextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosicaoApagar = new System.Windows.Forms.TextBox();
            this.txtValorParaApagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSelecioneParaEditar = new System.Windows.Forms.ComboBox();
            this.txtNumeroEditar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(77, 22);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(440, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 33);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(95, 6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(327, 29);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // rtbNumero
            // 
            this.rtbNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNumero.Location = new System.Drawing.Point(21, 47);
            this.rtbNumero.Name = "rtbNumero";
            this.rtbNumero.ReadOnly = true;
            this.rtbNumero.Size = new System.Drawing.Size(534, 173);
            this.rtbNumero.TabIndex = 3;
            this.rtbNumero.TabStop = false;
            this.rtbNumero.Text = "";
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Location = new System.Drawing.Point(440, 226);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(110, 33);
            this.btnProcessar.TabIndex = 3;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posição para apagar";
            // 
            // txtPosicaoApagar
            // 
            this.txtPosicaoApagar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicaoApagar.Location = new System.Drawing.Point(566, 34);
            this.txtPosicaoApagar.Name = "txtPosicaoApagar";
            this.txtPosicaoApagar.Size = new System.Drawing.Size(180, 29);
            this.txtPosicaoApagar.TabIndex = 5;
            this.txtPosicaoApagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosicaoApagar_KeyDown);
            // 
            // txtValorParaApagar
            // 
            this.txtValorParaApagar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParaApagar.Location = new System.Drawing.Point(566, 91);
            this.txtValorParaApagar.Name = "txtValorParaApagar";
            this.txtValorParaApagar.Size = new System.Drawing.Size(180, 29);
            this.txtValorParaApagar.TabIndex = 7;
            this.txtValorParaApagar.Leave += new System.EventHandler(this.txtValorParaApagar_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor para apagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecione para editar";
            // 
            // cbSelecioneParaEditar
            // 
            this.cbSelecioneParaEditar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecioneParaEditar.FormattingEnabled = true;
            this.cbSelecioneParaEditar.Location = new System.Drawing.Point(566, 148);
            this.cbSelecioneParaEditar.Name = "cbSelecioneParaEditar";
            this.cbSelecioneParaEditar.Size = new System.Drawing.Size(180, 30);
            this.cbSelecioneParaEditar.TabIndex = 9;
            this.cbSelecioneParaEditar.SelectedIndexChanged += new System.EventHandler(this.cbSelecioneParaEditar_SelectedIndexChanged);
            // 
            // txtNumeroEditar
            // 
            this.txtNumeroEditar.Enabled = false;
            this.txtNumeroEditar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEditar.Location = new System.Drawing.Point(565, 210);
            this.txtNumeroEditar.Name = "txtNumeroEditar";
            this.txtNumeroEditar.Size = new System.Drawing.Size(180, 29);
            this.txtNumeroEditar.TabIndex = 10;
            this.txtNumeroEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroEditar_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Número";
            // 
            // Exemplo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroEditar);
            this.Controls.Add(this.cbSelecioneParaEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorParaApagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosicaoApagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.rtbNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exemplo01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RichTextBox rtbNumero;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosicaoApagar;
        private System.Windows.Forms.TextBox txtValorParaApagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSelecioneParaEditar;
        private System.Windows.Forms.TextBox txtNumeroEditar;
        private System.Windows.Forms.Label label4;
    }
}