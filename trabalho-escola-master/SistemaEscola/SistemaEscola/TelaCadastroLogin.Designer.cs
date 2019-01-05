namespace SistemaEscola
{
    partial class TelaCadastroLogin
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_ConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.cb_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.cb_Setor = new System.Windows.Forms.ComboBox();
            this.cb_Privilegio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_ErroSenha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_AvisoSenha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(58, 52);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(215, 22);
            this.txt_Nome.TabIndex = 1;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(224, 218);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(108, 31);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(82, 20);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(184, 22);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_ConfirmacaoSenha
            // 
            this.txt_ConfirmacaoSenha.Location = new System.Drawing.Point(166, 125);
            this.txt_ConfirmacaoSenha.Name = "txt_ConfirmacaoSenha";
            this.txt_ConfirmacaoSenha.Size = new System.Drawing.Size(100, 22);
            this.txt_ConfirmacaoSenha.TabIndex = 7;
            this.txt_ConfirmacaoSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ConfirmacaoSenha_KeyDown);
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(166, 50);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(100, 22);
            this.txt_Login.TabIndex = 5;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(166, 99);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(100, 22);
            this.txt_Senha.TabIndex = 6;
            // 
            // cb_MostrarSenha
            // 
            this.cb_MostrarSenha.AutoSize = true;
            this.cb_MostrarSenha.Location = new System.Drawing.Point(166, 154);
            this.cb_MostrarSenha.Name = "cb_MostrarSenha";
            this.cb_MostrarSenha.Size = new System.Drawing.Size(112, 20);
            this.cb_MostrarSenha.TabIndex = 6;
            this.cb_MostrarSenha.Text = "Mostrar Senha";
            this.cb_MostrarSenha.UseVisualStyleBackColor = true;
            this.cb_MostrarSenha.CheckedChanged += new System.EventHandler(this.cb_MostrarSenha_CheckedChanged);
            // 
            // cb_Setor
            // 
            this.cb_Setor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Setor.FormattingEnabled = true;
            this.cb_Setor.Items.AddRange(new object[] {
            "Secretaria",
            "Diretoria",
            "Biblioteca",
            "Cordenação "});
            this.cb_Setor.Location = new System.Drawing.Point(136, 78);
            this.cb_Setor.Name = "cb_Setor";
            this.cb_Setor.Size = new System.Drawing.Size(137, 24);
            this.cb_Setor.TabIndex = 2;
            // 
            // cb_Privilegio
            // 
            this.cb_Privilegio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Privilegio.FormattingEnabled = true;
            this.cb_Privilegio.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cb_Privilegio.Location = new System.Drawing.Point(136, 105);
            this.cb_Privilegio.Name = "cb_Privilegio";
            this.cb_Privilegio.Size = new System.Drawing.Size(137, 24);
            this.cb_Privilegio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Privilegio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Setor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Confirmar Senha";
            // 
            // lb_ErroSenha
            // 
            this.lb_ErroSenha.AutoSize = true;
            this.lb_ErroSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ErroSenha.ForeColor = System.Drawing.Color.Red;
            this.lb_ErroSenha.Location = new System.Drawing.Point(73, 79);
            this.lb_ErroSenha.Name = "lb_ErroSenha";
            this.lb_ErroSenha.Size = new System.Drawing.Size(0, 16);
            this.lb_ErroSenha.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_AvisoSenha);
            this.groupBox1.Controls.Add(this.cb_MostrarSenha);
            this.groupBox1.Controls.Add(this.lb_ErroSenha);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Login);
            this.groupBox1.Controls.Add(this.txt_Senha);
            this.groupBox1.Controls.Add(this.txt_ConfirmacaoSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(279, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 177);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // lb_AvisoSenha
            // 
            this.lb_AvisoSenha.AutoSize = true;
            this.lb_AvisoSenha.ForeColor = System.Drawing.Color.Red;
            this.lb_AvisoSenha.Location = new System.Drawing.Point(76, 82);
            this.lb_AvisoSenha.Name = "lb_AvisoSenha";
            this.lb_AvisoSenha.Size = new System.Drawing.Size(190, 16);
            this.lb_AvisoSenha.TabIndex = 16;
            this.lb_AvisoSenha.Text = "Exemplo de senha:  sa9Woz9u";
            this.lb_AvisoSenha.Visible = false;
            // 
            // TelaCadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Privilegio);
            this.Controls.Add(this.cb_Setor);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaCadastroLogin";
            this.Text = "Cadastro Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_ConfirmacaoSenha;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.CheckBox cb_MostrarSenha;
        private System.Windows.Forms.ComboBox cb_Setor;
        private System.Windows.Forms.ComboBox cb_Privilegio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_ErroSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_AvisoSenha;
    }
}