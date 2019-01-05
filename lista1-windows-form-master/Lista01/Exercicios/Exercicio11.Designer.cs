namespace Exercicios
{
    partial class Exercicio11
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
            this.lblAno = new System.Windows.Forms.Label();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.lblResutlado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.btnConferir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(459, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tempo Vivo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(306, 95);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(44, 22);
            this.lblAno.TabIndex = 1;
            this.lblAno.Text = "Ano";
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.Location = new System.Drawing.Point(12, 44);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(459, 39);
            this.lblInformacoes.TabIndex = 2;
            this.lblInformacoes.Text = "Informe os dados pedidos a baixo para saber algumas informações.";
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAno.Location = new System.Drawing.Point(320, 120);
            this.nudAno.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(120, 29);
            this.nudAno.TabIndex = 3;
            this.nudAno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudAno_KeyDown);
            // 
            // lblResutlado
            // 
            this.lblResutlado.AutoSize = true;
            this.lblResutlado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResutlado.Location = new System.Drawing.Point(12, 163);
            this.lblResutlado.Name = "lblResutlado";
            this.lblResutlado.Size = new System.Drawing.Size(117, 22);
            this.lblResutlado.TabIndex = 4;
            this.lblResutlado.Text = "Informações";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(26, 188);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(309, 203);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TabStop = false;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(12, 95);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(38, 22);
            this.lblDia.TabIndex = 6;
            this.lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(156, 95);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(46, 22);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mês";
            // 
            // nudDia
            // 
            this.nudDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDia.Location = new System.Drawing.Point(26, 120);
            this.nudDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(120, 29);
            this.nudDia.TabIndex = 1;
            // 
            // nudMes
            // 
            this.nudMes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMes.Location = new System.Drawing.Point(170, 120);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(120, 29);
            this.nudMes.TabIndex = 2;
            // 
            // btnConferir
            // 
            this.btnConferir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferir.Location = new System.Drawing.Point(350, 342);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(120, 38);
            this.btnConferir.TabIndex = 4;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // Exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 409);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudDia);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResutlado);
            this.Controls.Add(this.nudAno);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 11";
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Label lblResutlado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.Button btnConferir;
    }
}