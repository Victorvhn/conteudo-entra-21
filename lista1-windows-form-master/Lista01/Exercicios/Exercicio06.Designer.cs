namespace Exercicios
{
    partial class Exercicio06
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
            this.lblNota01 = new System.Windows.Forms.Label();
            this.lblNota02 = new System.Windows.Forms.Label();
            this.lblNota03 = new System.Windows.Forms.Label();
            this.lblNota04 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mtbNota01 = new System.Windows.Forms.MaskedTextBox();
            this.mtbNota03 = new System.Windows.Forms.MaskedTextBox();
            this.mtbNota02 = new System.Windows.Forms.MaskedTextBox();
            this.mtbNota04 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcular Média";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNota01
            // 
            this.lblNota01.AutoSize = true;
            this.lblNota01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota01.Location = new System.Drawing.Point(12, 49);
            this.lblNota01.Name = "lblNota01";
            this.lblNota01.Size = new System.Drawing.Size(65, 22);
            this.lblNota01.TabIndex = 1;
            this.lblNota01.Text = "Nota 1";
            // 
            // lblNota02
            // 
            this.lblNota02.AutoSize = true;
            this.lblNota02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota02.Location = new System.Drawing.Point(12, 116);
            this.lblNota02.Name = "lblNota02";
            this.lblNota02.Size = new System.Drawing.Size(65, 22);
            this.lblNota02.TabIndex = 2;
            this.lblNota02.Text = "Nota 2";
            // 
            // lblNota03
            // 
            this.lblNota03.AutoSize = true;
            this.lblNota03.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota03.Location = new System.Drawing.Point(134, 49);
            this.lblNota03.Name = "lblNota03";
            this.lblNota03.Size = new System.Drawing.Size(65, 22);
            this.lblNota03.TabIndex = 3;
            this.lblNota03.Text = "Nota 3";
            // 
            // lblNota04
            // 
            this.lblNota04.AutoSize = true;
            this.lblNota04.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota04.Location = new System.Drawing.Point(134, 116);
            this.lblNota04.Name = "lblNota04";
            this.lblNota04.Size = new System.Drawing.Size(65, 22);
            this.lblNota04.TabIndex = 4;
            this.lblNota04.Text = "Nota 4";
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(67, 215);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(100, 29);
            this.txtMedia.TabIndex = 5;
            this.txtMedia.TabStop = false;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(86, 190);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(61, 22);
            this.lblMedia.TabIndex = 10;
            this.lblMedia.Text = "Média";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(107, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 31);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mtbNota01
            // 
            this.mtbNota01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNota01.Location = new System.Drawing.Point(26, 75);
            this.mtbNota01.Mask = "90,99";
            this.mtbNota01.Name = "mtbNota01";
            this.mtbNota01.Size = new System.Drawing.Size(60, 29);
            this.mtbNota01.TabIndex = 1;
            this.mtbNota01.Tag = "";
            // 
            // mtbNota03
            // 
            this.mtbNota03.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNota03.Location = new System.Drawing.Point(149, 75);
            this.mtbNota03.Mask = "90,99";
            this.mtbNota03.Name = "mtbNota03";
            this.mtbNota03.Size = new System.Drawing.Size(60, 29);
            this.mtbNota03.TabIndex = 3;
            this.mtbNota03.Tag = "";
            // 
            // mtbNota02
            // 
            this.mtbNota02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNota02.Location = new System.Drawing.Point(26, 141);
            this.mtbNota02.Mask = "90,99";
            this.mtbNota02.Name = "mtbNota02";
            this.mtbNota02.Size = new System.Drawing.Size(60, 29);
            this.mtbNota02.TabIndex = 2;
            this.mtbNota02.Tag = "";
            // 
            // mtbNota04
            // 
            this.mtbNota04.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNota04.Location = new System.Drawing.Point(149, 141);
            this.mtbNota04.Mask = "90,99";
            this.mtbNota04.Name = "mtbNota04";
            this.mtbNota04.Size = new System.Drawing.Size(60, 29);
            this.mtbNota04.TabIndex = 4;
            this.mtbNota04.Tag = "";
            this.mtbNota04.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbNota04_KeyDown);
            // 
            // Exercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 301);
            this.Controls.Add(this.mtbNota04);
            this.Controls.Add(this.mtbNota02);
            this.Controls.Add(this.mtbNota03);
            this.Controls.Add(this.mtbNota01);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblNota04);
            this.Controls.Add(this.lblNota03);
            this.Controls.Add(this.lblNota02);
            this.Controls.Add(this.lblNota01);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNota01;
        private System.Windows.Forms.Label lblNota02;
        private System.Windows.Forms.Label lblNota03;
        private System.Windows.Forms.Label lblNota04;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mtbNota01;
        private System.Windows.Forms.MaskedTextBox mtbNota03;
        private System.Windows.Forms.MaskedTextBox mtbNota02;
        private System.Windows.Forms.MaskedTextBox mtbNota04;
    }
}