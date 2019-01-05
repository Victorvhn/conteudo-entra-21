namespace Exercicio01
{
    partial class CadastrarAluno
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbNota2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudQuantidadeFaltas = new System.Windows.Forms.NumericUpDown();
            this.mtbNota3 = new System.Windows.Forms.MaskedTextBox();
            this.mtbNota1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblqualqeur = new System.Windows.Forms.Label();
            this.lblFrequencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeFaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro De Aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 186);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(31, 127);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(258, 26);
            this.txtMatricula.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nota 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nota 3";
            // 
            // mtbNota2
            // 
            this.mtbNota2.Location = new System.Drawing.Point(172, 307);
            this.mtbNota2.Mask = "90.00";
            this.mtbNota2.Name = "mtbNota2";
            this.mtbNota2.Size = new System.Drawing.Size(51, 26);
            this.mtbNota2.TabIndex = 5;
            this.mtbNota2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbNota2_KeyDown);
            this.mtbNota2.Leave += new System.EventHandler(this.mtbNota2_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantidade de Faltas";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(31, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 26);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Código";
            // 
            // nudQuantidadeFaltas
            // 
            this.nudQuantidadeFaltas.Location = new System.Drawing.Point(31, 245);
            this.nudQuantidadeFaltas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudQuantidadeFaltas.Name = "nudQuantidadeFaltas";
            this.nudQuantidadeFaltas.Size = new System.Drawing.Size(120, 26);
            this.nudQuantidadeFaltas.TabIndex = 3;
            this.nudQuantidadeFaltas.Leave += new System.EventHandler(this.nudQuantidadeFaltas_Leave);
            // 
            // mtbNota3
            // 
            this.mtbNota3.Location = new System.Drawing.Point(305, 307);
            this.mtbNota3.Mask = "90.00";
            this.mtbNota3.Name = "mtbNota3";
            this.mtbNota3.Size = new System.Drawing.Size(51, 26);
            this.mtbNota3.TabIndex = 6;
            this.mtbNota3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbNota3_KeyDown);
            this.mtbNota3.Leave += new System.EventHandler(this.mtbNota3_Leave);
            // 
            // mtbNota1
            // 
            this.mtbNota1.Location = new System.Drawing.Point(31, 307);
            this.mtbNota1.Mask = "90.00";
            this.mtbNota1.Name = "mtbNota1";
            this.mtbNota1.Size = new System.Drawing.Size(51, 26);
            this.mtbNota1.TabIndex = 4;
            this.mtbNota1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbNota1_KeyDown);
            this.mtbNota1.Leave += new System.EventHandler(this.mtbNota1_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(234, 460);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 42);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Média";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(465, 310);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(17, 18);
            this.lblMedia.TabIndex = 19;
            this.lblMedia.Text = "0";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(49, 418);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(85, 18);
            this.lblSituacao.TabIndex = 21;
            this.lblSituacao.Text = "Reprovado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Situação";
            // 
            // lblqualqeur
            // 
            this.lblqualqeur.AutoSize = true;
            this.lblqualqeur.Location = new System.Drawing.Point(450, 224);
            this.lblqualqeur.Name = "lblqualqeur";
            this.lblqualqeur.Size = new System.Drawing.Size(87, 18);
            this.lblqualqeur.TabIndex = 22;
            this.lblqualqeur.Text = "Frequência";
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Location = new System.Drawing.Point(465, 247);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(53, 18);
            this.lblFrequencia.TabIndex = 23;
            this.lblFrequencia.Text = "0,00%";
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 514);
            this.Controls.Add(this.lblFrequencia);
            this.Controls.Add(this.lblqualqeur);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtbNota1);
            this.Controls.Add(this.mtbNota3);
            this.Controls.Add(this.nudQuantidadeFaltas);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbNota2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbNota2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudQuantidadeFaltas;
        private System.Windows.Forms.MaskedTextBox mtbNota3;
        private System.Windows.Forms.MaskedTextBox mtbNota1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblqualqeur;
        private System.Windows.Forms.Label lblFrequencia;
    }
}