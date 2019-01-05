namespace Exercicios
{
    partial class Exercicio04
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTabuada = new System.Windows.Forms.Label();
            this.txtTabuada = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tabuada";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(34, 97);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(77, 22);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número";
            // 
            // lblTabuada
            // 
            this.lblTabuada.AutoSize = true;
            this.lblTabuada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabuada.Location = new System.Drawing.Point(34, 168);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(82, 22);
            this.lblTabuada.TabIndex = 2;
            this.lblTabuada.Text = "Tabuada";
            // 
            // txtTabuada
            // 
            this.txtTabuada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabuada.Location = new System.Drawing.Point(48, 193);
            this.txtTabuada.Multiline = true;
            this.txtTabuada.Name = "txtTabuada";
            this.txtTabuada.ReadOnly = true;
            this.txtTabuada.Size = new System.Drawing.Size(309, 250);
            this.txtTabuada.TabIndex = 2;
            this.txtTabuada.TabStop = false;
            // 
            // nudNumero
            // 
            this.nudNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero.Location = new System.Drawing.Point(48, 122);
            this.nudNumero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(120, 29);
            this.nudNumero.TabIndex = 1;
            this.nudNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudNumero_KeyDown);
            // 
            // lblInformacao
            // 
            this.lblInformacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(20, 49);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(370, 48);
            this.lblInformacao.TabIndex = 5;
            this.lblInformacao.Text = "   Digite algum número de sua escolha para saber a tabuada dele do 0 ao 10.";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(226, 449);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 37);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 499);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.txtTabuada);
            this.Controls.Add(this.lblTabuada);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Exercicio04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 04";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTabuada;
        private System.Windows.Forms.TextBox txtTabuada;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Button btnCalcular;
    }
}