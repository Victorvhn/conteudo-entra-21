namespace Exercicios
{
    partial class Exercicio09
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.lblNumero01 = new System.Windows.Forms.Label();
            this.nudNumero01 = new System.Windows.Forms.NumericUpDown();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNumero02 = new System.Windows.Forms.Label();
            this.nudNumero02 = new System.Windows.Forms.NumericUpDown();
            this.btnResultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero02)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Troca de Números";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.Location = new System.Drawing.Point(12, 57);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(231, 47);
            this.lblInformacoes.TabIndex = 1;
            this.lblInformacoes.Text = "Informe dois números para serem trocados de lugar.";
            // 
            // lblNumero01
            // 
            this.lblNumero01.AutoSize = true;
            this.lblNumero01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero01.Location = new System.Drawing.Point(11, 104);
            this.lblNumero01.Name = "lblNumero01";
            this.lblNumero01.Size = new System.Drawing.Size(93, 22);
            this.lblNumero01.TabIndex = 2;
            this.lblNumero01.Text = "Número 1";
            // 
            // nudNumero01
            // 
            this.nudNumero01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero01.Location = new System.Drawing.Point(26, 129);
            this.nudNumero01.Name = "nudNumero01";
            this.nudNumero01.Size = new System.Drawing.Size(78, 29);
            this.nudNumero01.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(26, 195);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(204, 74);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(76, 170);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 22);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // lblNumero02
            // 
            this.lblNumero02.AutoSize = true;
            this.lblNumero02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero02.Location = new System.Drawing.Point(137, 104);
            this.lblNumero02.Name = "lblNumero02";
            this.lblNumero02.Size = new System.Drawing.Size(93, 22);
            this.lblNumero02.TabIndex = 6;
            this.lblNumero02.Text = "Número 2";
            // 
            // nudNumero02
            // 
            this.nudNumero02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero02.Location = new System.Drawing.Point(152, 129);
            this.nudNumero02.Name = "nudNumero02";
            this.nudNumero02.Size = new System.Drawing.Size(78, 29);
            this.nudNumero02.TabIndex = 2;
            this.nudNumero02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudNumero02_KeyDown);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(141, 284);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(99, 35);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "Trocar";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Exercicio09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 331);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.nudNumero02);
            this.Controls.Add(this.lblNumero02);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.nudNumero01);
            this.Controls.Add(this.lblNumero01);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 09";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.Label lblNumero01;
        private System.Windows.Forms.NumericUpDown nudNumero01;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNumero02;
        private System.Windows.Forms.NumericUpDown nudNumero02;
        private System.Windows.Forms.Button btnResultado;
    }
}