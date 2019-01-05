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
            this.nudNumero01 = new System.Windows.Forms.NumericUpDown();
            this.nudNumero02 = new System.Windows.Forms.NumericUpDown();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumero01 = new System.Windows.Forms.Label();
            this.lblNumero02 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero02)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudNumero01
            // 
            this.nudNumero01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero01.Location = new System.Drawing.Point(36, 77);
            this.nudNumero01.Name = "nudNumero01";
            this.nudNumero01.Size = new System.Drawing.Size(120, 29);
            this.nudNumero01.TabIndex = 1;
            // 
            // nudNumero02
            // 
            this.nudNumero02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero02.Location = new System.Drawing.Point(36, 142);
            this.nudNumero02.Name = "nudNumero02";
            this.nudNumero02.Size = new System.Drawing.Size(120, 29);
            this.nudNumero02.TabIndex = 2;
            this.nudNumero02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudNumero02_KeyDown);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txtResultados);
            this.gbResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(196, 52);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(200, 222);
            this.gbResultado.TabIndex = 2;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultados";
            // 
            // txtResultados
            // 
            this.txtResultados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultados.Location = new System.Drawing.Point(6, 28);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(188, 188);
            this.txtResultados.TabIndex = 0;
            this.txtResultados.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(384, 40);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Informações Matemáticas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumero01
            // 
            this.lblNumero01.AutoSize = true;
            this.lblNumero01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero01.Location = new System.Drawing.Point(21, 52);
            this.lblNumero01.Name = "lblNumero01";
            this.lblNumero01.Size = new System.Drawing.Size(104, 22);
            this.lblNumero01.TabIndex = 4;
            this.lblNumero01.Text = "Número 01";
            // 
            // lblNumero02
            // 
            this.lblNumero02.AutoSize = true;
            this.lblNumero02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero02.Location = new System.Drawing.Point(21, 117);
            this.lblNumero02.Name = "lblNumero02";
            this.lblNumero02.Size = new System.Drawing.Size(104, 22);
            this.lblNumero02.TabIndex = 5;
            this.lblNumero02.Text = "Número 02";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(36, 238);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 289);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNumero02);
            this.Controls.Add(this.lblNumero01);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.nudNumero02);
            this.Controls.Add(this.nudNumero01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 03";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero02)).EndInit();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumero01;
        private System.Windows.Forms.NumericUpDown nudNumero02;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero01;
        private System.Windows.Forms.Label lblNumero02;
        private System.Windows.Forms.Button btnCalcular;
    }
}