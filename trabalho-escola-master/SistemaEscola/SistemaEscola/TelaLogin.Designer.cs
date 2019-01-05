namespace SistemaEscola
{
    partial class TelaLogin
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
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lb_ErroLogin = new System.Windows.Forms.Label();
            this.cb_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.btn_CadastroUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(168, 179);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrar.TabIndex = 3;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajuda.Location = new System.Drawing.Point(12, 223);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajuda.TabIndex = 4;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            this.btn_Ajuda.Click += new System.EventHandler(this.btn_Ajuda_Click);
            // 
            // txt_Login
            // 
            this.txt_Login.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.Location = new System.Drawing.Point(100, 66);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(143, 22);
            this.txt_Login.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(100, 115);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(143, 22);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            this.txt_Senha.Leave += new System.EventHandler(this.txt_Senha_Leave);
            // 
            // lb_ErroLogin
            // 
            this.lb_ErroLogin.AutoSize = true;
            this.lb_ErroLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ErroLogin.ForeColor = System.Drawing.Color.Red;
            this.lb_ErroLogin.Location = new System.Drawing.Point(97, 96);
            this.lb_ErroLogin.Name = "lb_ErroLogin";
            this.lb_ErroLogin.Size = new System.Drawing.Size(155, 16);
            this.lb_ErroLogin.TabIndex = 4;
            this.lb_ErroLogin.Text = "Senha e/ou Login inválido";
            this.lb_ErroLogin.Visible = false;
            // 
            // cb_MostrarSenha
            // 
            this.cb_MostrarSenha.AutoSize = true;
            this.cb_MostrarSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MostrarSenha.Location = new System.Drawing.Point(100, 142);
            this.cb_MostrarSenha.Name = "cb_MostrarSenha";
            this.cb_MostrarSenha.Size = new System.Drawing.Size(112, 20);
            this.cb_MostrarSenha.TabIndex = 5;
            this.cb_MostrarSenha.Text = "Mostrar Senha";
            this.cb_MostrarSenha.UseVisualStyleBackColor = true;
            this.cb_MostrarSenha.CheckedChanged += new System.EventHandler(this.cb_MostrarSenha_CheckedChanged);
            // 
            // btn_CadastroUsuario
            // 
            this.btn_CadastroUsuario.Location = new System.Drawing.Point(213, 223);
            this.btn_CadastroUsuario.Name = "btn_CadastroUsuario";
            this.btn_CadastroUsuario.Size = new System.Drawing.Size(115, 23);
            this.btn_CadastroUsuario.TabIndex = 6;
            this.btn_CadastroUsuario.Text = "Cadastro Usuario";
            this.btn_CadastroUsuario.UseVisualStyleBackColor = true;
            this.btn_CadastroUsuario.Click += new System.EventHandler(this.btn_CadastroUsuario_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(340, 258);
            this.Controls.Add(this.btn_CadastroUsuario);
            this.Controls.Add(this.cb_MostrarSenha);
            this.Controls.Add(this.lb_ErroLogin);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.btn_Entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Ajuda;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lb_ErroLogin;
        private System.Windows.Forms.CheckBox cb_MostrarSenha;
        private System.Windows.Forms.Button btn_CadastroUsuario;
    }
}