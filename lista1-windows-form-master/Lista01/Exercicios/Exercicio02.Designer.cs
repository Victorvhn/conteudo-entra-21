namespace Exercicios
{
    partial class Exercicio02
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
            this.lblAgua = new System.Windows.Forms.Label();
            this.nudQuantidadeLitros = new System.Windows.Forms.NumericUpDown();
            this.nudQuantidadeAnos = new System.Windows.Forms.NumericUpDown();
            this.mtbValorLitro = new System.Windows.Forms.MaskedTextBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLitros = new System.Windows.Forms.Label();
            this.lblQuantidadeDeAnos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConferir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeLitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeAnos)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgua
            // 
            this.lblAgua.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgua.Location = new System.Drawing.Point(12, 9);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(582, 42);
            this.lblAgua.TabIndex = 0;
            this.lblAgua.Text = "Água";
            this.lblAgua.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudQuantidadeLitros
            // 
            this.nudQuantidadeLitros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidadeLitros.Location = new System.Drawing.Point(25, 76);
            this.nudQuantidadeLitros.Name = "nudQuantidadeLitros";
            this.nudQuantidadeLitros.Size = new System.Drawing.Size(120, 29);
            this.nudQuantidadeLitros.TabIndex = 1;
            // 
            // nudQuantidadeAnos
            // 
            this.nudQuantidadeAnos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidadeAnos.Location = new System.Drawing.Point(25, 134);
            this.nudQuantidadeAnos.Name = "nudQuantidadeAnos";
            this.nudQuantidadeAnos.Size = new System.Drawing.Size(120, 29);
            this.nudQuantidadeAnos.TabIndex = 2;
            // 
            // mtbValorLitro
            // 
            this.mtbValorLitro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValorLitro.Location = new System.Drawing.Point(25, 192);
            this.mtbValorLitro.Mask = "009,00";
            this.mtbValorLitro.Name = "mtbValorLitro";
            this.mtbValorLitro.Size = new System.Drawing.Size(100, 29);
            this.mtbValorLitro.TabIndex = 3;
            this.mtbValorLitro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbValorLitro_KeyDown);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txtResultado);
            this.gbResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(249, 76);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(345, 145);
            this.gbResultado.TabIndex = 4;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 28);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(333, 111);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TabStop = false;
            // 
            // lblQuantidadeLitros
            // 
            this.lblQuantidadeLitros.AutoSize = true;
            this.lblQuantidadeLitros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLitros.Location = new System.Drawing.Point(12, 51);
            this.lblQuantidadeLitros.Name = "lblQuantidadeLitros";
            this.lblQuantidadeLitros.Size = new System.Drawing.Size(184, 22);
            this.lblQuantidadeLitros.TabIndex = 5;
            this.lblQuantidadeLitros.Text = "Quantidade de litros ";
            // 
            // lblQuantidadeDeAnos
            // 
            this.lblQuantidadeDeAnos.AutoSize = true;
            this.lblQuantidadeDeAnos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDeAnos.Location = new System.Drawing.Point(12, 109);
            this.lblQuantidadeDeAnos.Name = "lblQuantidadeDeAnos";
            this.lblQuantidadeDeAnos.Size = new System.Drawing.Size(180, 22);
            this.lblQuantidadeDeAnos.TabIndex = 6;
            this.lblQuantidadeDeAnos.Text = "Quantidade de anos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor por litro";
            // 
            // btnConferir
            // 
            this.btnConferir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferir.Location = new System.Drawing.Point(463, 235);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(125, 37);
            this.btnConferir.TabIndex = 4;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 284);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuantidadeDeAnos);
            this.Controls.Add(this.lblQuantidadeLitros);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.mtbValorLitro);
            this.Controls.Add(this.nudQuantidadeAnos);
            this.Controls.Add(this.nudQuantidadeLitros);
            this.Controls.Add(this.lblAgua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio 02";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeLitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeAnos)).EndInit();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.NumericUpDown nudQuantidadeLitros;
        private System.Windows.Forms.NumericUpDown nudQuantidadeAnos;
        private System.Windows.Forms.MaskedTextBox mtbValorLitro;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblQuantidadeLitros;
        private System.Windows.Forms.Label lblQuantidadeDeAnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConferir;
    }
}