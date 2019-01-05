namespace Exercicios
{
    partial class Exercicio08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio08));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPedido01 = new System.Windows.Forms.Label();
            this.lblPedido02 = new System.Windows.Forms.Label();
            this.lblPedido03 = new System.Windows.Forms.Label();
            this.nudPedido01 = new System.Windows.Forms.NumericUpDown();
            this.nudPedido02 = new System.Windows.Forms.NumericUpDown();
            this.nudPedido03 = new System.Windows.Forms.NumericUpDown();
            this.lblRestaurante = new System.Windows.Forms.Label();
            this.lblApresentacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido03)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(282, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 552);
            this.panel1.TabIndex = 0;
            // 
            // lblPedido01
            // 
            this.lblPedido01.AutoSize = true;
            this.lblPedido01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido01.Location = new System.Drawing.Point(40, 94);
            this.lblPedido01.Name = "lblPedido01";
            this.lblPedido01.Size = new System.Drawing.Size(98, 22);
            this.lblPedido01.TabIndex = 1;
            this.lblPedido01.Text = "Pedido 01";
            // 
            // lblPedido02
            // 
            this.lblPedido02.AutoSize = true;
            this.lblPedido02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido02.Location = new System.Drawing.Point(43, 184);
            this.lblPedido02.Name = "lblPedido02";
            this.lblPedido02.Size = new System.Drawing.Size(98, 22);
            this.lblPedido02.TabIndex = 2;
            this.lblPedido02.Text = "Pedido 02";
            // 
            // lblPedido03
            // 
            this.lblPedido03.AutoSize = true;
            this.lblPedido03.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido03.Location = new System.Drawing.Point(43, 282);
            this.lblPedido03.Name = "lblPedido03";
            this.lblPedido03.Size = new System.Drawing.Size(98, 22);
            this.lblPedido03.TabIndex = 3;
            this.lblPedido03.Text = "Pedido 03";
            // 
            // nudPedido01
            // 
            this.nudPedido01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPedido01.Location = new System.Drawing.Point(43, 119);
            this.nudPedido01.Name = "nudPedido01";
            this.nudPedido01.Size = new System.Drawing.Size(120, 29);
            this.nudPedido01.TabIndex = 4;
            // 
            // nudPedido02
            // 
            this.nudPedido02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPedido02.Location = new System.Drawing.Point(43, 214);
            this.nudPedido02.Name = "nudPedido02";
            this.nudPedido02.Size = new System.Drawing.Size(120, 29);
            this.nudPedido02.TabIndex = 5;
            // 
            // nudPedido03
            // 
            this.nudPedido03.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPedido03.Location = new System.Drawing.Point(43, 318);
            this.nudPedido03.Name = "nudPedido03";
            this.nudPedido03.Size = new System.Drawing.Size(120, 29);
            this.nudPedido03.TabIndex = 6;
            // 
            // lblRestaurante
            // 
            this.lblRestaurante.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurante.Location = new System.Drawing.Point(102, 23);
            this.lblRestaurante.Name = "lblRestaurante";
            this.lblRestaurante.Size = new System.Drawing.Size(100, 23);
            this.lblRestaurante.TabIndex = 7;
            this.lblRestaurante.Text = "Restaurante";
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentacao.Location = new System.Drawing.Point(95, 57);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(100, 23);
            this.lblApresentacao.TabIndex = 8;
            this.lblApresentacao.Text = "Faça quantos pedidos você quiser (no máximo 3), se não quiser pedir algum deixe 0" +
    ".";
            // 
            // Exercicio08
            // 
            this.ClientSize = new System.Drawing.Size(923, 658);
            this.Controls.Add(this.lblApresentacao);
            this.Controls.Add(this.lblRestaurante);
            this.Controls.Add(this.nudPedido03);
            this.Controls.Add(this.nudPedido02);
            this.Controls.Add(this.nudPedido01);
            this.Controls.Add(this.lblPedido03);
            this.Controls.Add(this.lblPedido02);
            this.Controls.Add(this.lblPedido01);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 08";
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPedido01;
        private System.Windows.Forms.Label lblPedido02;
        private System.Windows.Forms.Label lblPedido03;
        private System.Windows.Forms.NumericUpDown nudPedido01;
        private System.Windows.Forms.NumericUpDown nudPedido02;
        private System.Windows.Forms.NumericUpDown nudPedido03;
        private System.Windows.Forms.Label lblRestaurante;
        private System.Windows.Forms.Label lblApresentacao;

    }
}