namespace Exercicios
{
    partial class Exercicio03
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radDivisao = new System.Windows.Forms.RadioButton();
            this.radMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radSubtracao = new System.Windows.Forms.RadioButton();
            this.radSoma = new System.Windows.Forms.RadioButton();
            this.txtApresentar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInfor = new System.Windows.Forms.Label();
            this.lblNumero01 = new System.Windows.Forms.Label();
            this.lblNumero02 = new System.Windows.Forms.Label();
            this.txtNumero01 = new System.Windows.Forms.TextBox();
            this.txtNumero02 = new System.Windows.Forms.TextBox();
            this.lblApresentar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radDivisao);
            this.panel1.Controls.Add(this.radMultiplicacao);
            this.panel1.Controls.Add(this.radSoma);
            this.panel1.Controls.Add(this.radSubtracao);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 130);
            this.panel1.TabIndex = 3;
            // 
            // radDivisao
            // 
            this.radDivisao.AutoSize = true;
            this.radDivisao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDivisao.Location = new System.Drawing.Point(8, 103);
            this.radDivisao.Name = "radDivisao";
            this.radDivisao.Size = new System.Drawing.Size(80, 26);
            this.radDivisao.TabIndex = 6;
            this.radDivisao.TabStop = true;
            this.radDivisao.Text = "Dividir";
            this.radDivisao.UseVisualStyleBackColor = true;
            // 
            // radMultiplicacao
            // 
            this.radMultiplicacao.AutoSize = true;
            this.radMultiplicacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiplicacao.Location = new System.Drawing.Point(8, 71);
            this.radMultiplicacao.Name = "radMultiplicacao";
            this.radMultiplicacao.Size = new System.Drawing.Size(111, 26);
            this.radMultiplicacao.TabIndex = 5;
            this.radMultiplicacao.TabStop = true;
            this.radMultiplicacao.Text = "Multiplicar";
            this.radMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radSubtracao
            // 
            this.radSubtracao.AutoSize = true;
            this.radSubtracao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSubtracao.Location = new System.Drawing.Point(8, 39);
            this.radSubtracao.Name = "radSubtracao";
            this.radSubtracao.Size = new System.Drawing.Size(93, 26);
            this.radSubtracao.TabIndex = 4;
            this.radSubtracao.TabStop = true;
            this.radSubtracao.Text = "Subtrair";
            this.radSubtracao.UseVisualStyleBackColor = true;
            // 
            // radSoma
            // 
            this.radSoma.AutoSize = true;
            this.radSoma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSoma.Location = new System.Drawing.Point(8, 7);
            this.radSoma.Name = "radSoma";
            this.radSoma.Size = new System.Drawing.Size(84, 26);
            this.radSoma.TabIndex = 3;
            this.radSoma.TabStop = true;
            this.radSoma.Text = "Somar";
            this.radSoma.UseVisualStyleBackColor = true;
            // 
            // txtApresentar
            // 
            this.txtApresentar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApresentar.Location = new System.Drawing.Point(154, 245);
            this.txtApresentar.Multiline = true;
            this.txtApresentar.Name = "txtApresentar";
            this.txtApresentar.ReadOnly = true;
            this.txtApresentar.Size = new System.Drawing.Size(226, 95);
            this.txtApresentar.TabIndex = 2;
            this.txtApresentar.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(380, 40);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Contas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfor
            // 
            this.lblInfor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor.Location = new System.Drawing.Point(12, 53);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(380, 57);
            this.lblInfor.TabIndex = 4;
            this.lblInfor.Text = "Informe dois número, após isso selecione a opção matemática desejada, lembrando q" +
    "ue a conta sempre será feita do número 1 pelo número 2.";
            // 
            // lblNumero01
            // 
            this.lblNumero01.AutoSize = true;
            this.lblNumero01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero01.Location = new System.Drawing.Point(12, 136);
            this.lblNumero01.Name = "lblNumero01";
            this.lblNumero01.Size = new System.Drawing.Size(93, 22);
            this.lblNumero01.TabIndex = 5;
            this.lblNumero01.Text = "Numero 1";
            // 
            // lblNumero02
            // 
            this.lblNumero02.AutoSize = true;
            this.lblNumero02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero02.Location = new System.Drawing.Point(150, 136);
            this.lblNumero02.Name = "lblNumero02";
            this.lblNumero02.Size = new System.Drawing.Size(93, 22);
            this.lblNumero02.TabIndex = 6;
            this.lblNumero02.Text = "Numero 2";
            // 
            // txtNumero01
            // 
            this.txtNumero01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero01.Location = new System.Drawing.Point(25, 161);
            this.txtNumero01.Name = "txtNumero01";
            this.txtNumero01.Size = new System.Drawing.Size(100, 29);
            this.txtNumero01.TabIndex = 1;
            // 
            // txtNumero02
            // 
            this.txtNumero02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero02.Location = new System.Drawing.Point(164, 161);
            this.txtNumero02.Name = "txtNumero02";
            this.txtNumero02.Size = new System.Drawing.Size(100, 29);
            this.txtNumero02.TabIndex = 2;
            this.txtNumero02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero02_KeyDown);
            // 
            // lblApresentar
            // 
            this.lblApresentar.AutoSize = true;
            this.lblApresentar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentar.Location = new System.Drawing.Point(150, 215);
            this.lblApresentar.Name = "lblApresentar";
            this.lblApresentar.Size = new System.Drawing.Size(96, 22);
            this.lblApresentar.TabIndex = 9;
            this.lblApresentar.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(290, 346);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 34);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 391);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblApresentar);
            this.Controls.Add(this.txtNumero02);
            this.Controls.Add(this.txtNumero01);
            this.Controls.Add(this.lblNumero02);
            this.Controls.Add(this.lblNumero01);
            this.Controls.Add(this.lblInfor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtApresentar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 03";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radDivisao;
        private System.Windows.Forms.RadioButton radMultiplicacao;
        private System.Windows.Forms.RadioButton radSubtracao;
        private System.Windows.Forms.RadioButton radSoma;
        private System.Windows.Forms.TextBox txtApresentar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.Label lblNumero01;
        private System.Windows.Forms.Label lblNumero02;
        private System.Windows.Forms.TextBox txtNumero01;
        private System.Windows.Forms.TextBox txtNumero02;
        private System.Windows.Forms.Label lblApresentar;
        private System.Windows.Forms.Button btnCalcular;
    }
}