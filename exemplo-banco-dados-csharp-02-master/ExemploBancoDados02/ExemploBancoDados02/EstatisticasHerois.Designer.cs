﻿namespace ExemploBancoDados02
{
    partial class EstatisticasHerois
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
            this.lblTotalContasBancarias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total das Contas Bancárias:";
            // 
            // lblTotalContasBancarias
            // 
            this.lblTotalContasBancarias.AutoSize = true;
            this.lblTotalContasBancarias.Location = new System.Drawing.Point(224, 9);
            this.lblTotalContasBancarias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalContasBancarias.Name = "lblTotalContasBancarias";
            this.lblTotalContasBancarias.Size = new System.Drawing.Size(17, 18);
            this.lblTotalContasBancarias.TabIndex = 1;
            this.lblTotalContasBancarias.Text = "0";
            // 
            // EstatisticasHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.lblTotalContasBancarias);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EstatisticasHerois";
            this.Text = "Estatisticas Herois";
            this.Load += new System.EventHandler(this.EstatisticasHerois_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalContasBancarias;
    }
}