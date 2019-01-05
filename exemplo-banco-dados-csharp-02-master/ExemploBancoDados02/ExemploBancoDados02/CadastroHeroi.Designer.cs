namespace ExemploBancoDados02
{
    partial class CadastroHeroi
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEscuridao = new System.Windows.Forms.GroupBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMulher = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQuantidadeFilmes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContaBancaria = new System.Windows.Forms.TextBox();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbEscuridao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(450, 318);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 43);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // gbEscuridao
            // 
            this.gbEscuridao.Controls.Add(this.rbNao);
            this.gbEscuridao.Controls.Add(this.rbSim);
            this.gbEscuridao.Location = new System.Drawing.Point(6, 112);
            this.gbEscuridao.Name = "gbEscuridao";
            this.gbEscuridao.Size = new System.Drawing.Size(262, 55);
            this.gbEscuridao.TabIndex = 2;
            this.gbEscuridao.TabStop = false;
            this.gbEscuridao.Text = "Escuridão";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(171, 34);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(55, 22);
            this.rbNao.TabIndex = 3;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbNao_KeyDown);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(52, 34);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(54, 22);
            this.rbSim.TabIndex = 2;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbSim_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Pessoa";
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(7, 191);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(261, 26);
            this.txtNomePessoa.TabIndex = 4;
            // 
            // cbRaca
            // 
            this.cbRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Humano",
            "Orc",
            "Fada",
            "Nórdico",
            "Avatar",
            "Alien",
            "Sayajin"});
            this.cbRaca.Location = new System.Drawing.Point(7, 241);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(262, 26);
            this.cbRaca.TabIndex = 5;
            this.cbRaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbRaca_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Raca";
            // 
            // chkMulher
            // 
            this.chkMulher.AutoSize = true;
            this.chkMulher.Location = new System.Drawing.Point(15, 287);
            this.chkMulher.Name = "chkMulher";
            this.chkMulher.Size = new System.Drawing.Size(73, 22);
            this.chkMulher.TabIndex = 6;
            this.chkMulher.Text = "Mulher";
            this.chkMulher.UseVisualStyleBackColor = true;
            this.chkMulher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkMulher_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Conta Bancária";
            // 
            // nudQuantidadeFilmes
            // 
            this.nudQuantidadeFilmes.Location = new System.Drawing.Point(7, 339);
            this.nudQuantidadeFilmes.Name = "nudQuantidadeFilmes";
            this.nudQuantidadeFilmes.Size = new System.Drawing.Size(262, 26);
            this.nudQuantidadeFilmes.TabIndex = 7;
            this.nudQuantidadeFilmes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudQuantidadeFilmes_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantidade Filmes";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(6, 439);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(167, 26);
            this.dtpDataNascimento.TabIndex = 9;
            this.dtpDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDataNascimento_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Nascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descrição";
            // 
            // txtContaBancaria
            // 
            this.txtContaBancaria.Location = new System.Drawing.Point(8, 389);
            this.txtContaBancaria.Name = "txtContaBancaria";
            this.txtContaBancaria.Size = new System.Drawing.Size(261, 26);
            this.txtContaBancaria.TabIndex = 8;
            this.txtContaBancaria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContaBancaria_KeyDown);
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(304, 30);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(247, 279);
            this.rtbDescricao.TabIndex = 10;
            this.rtbDescricao.Text = "";
            this.rtbDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbDescricao_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(262, 26);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // CadastroHeroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 490);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.txtContaBancaria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudQuantidadeFilmes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkMulher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.gbEscuridao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroHeroi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.gbEscuridao.ResumeLayout(false);
            this.gbEscuridao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEscuridao;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMulher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudQuantidadeFilmes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContaBancaria;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

