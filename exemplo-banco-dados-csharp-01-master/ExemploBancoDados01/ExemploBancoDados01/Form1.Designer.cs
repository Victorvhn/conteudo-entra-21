namespace ExemploBancoDados01
{
    partial class formCores
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cbCorApagar = new System.Windows.Forms.ComboBox();
            this.lblCorApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 31);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(70, 28);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(390, 26);
            this.txtCor.TabIndex = 1;
            this.txtCor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCor_KeyDown);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(466, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 57);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(448, 211);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cores";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(466, 142);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(178, 57);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cbCorApagar
            // 
            this.cbCorApagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorApagar.FormattingEnabled = true;
            this.cbCorApagar.Location = new System.Drawing.Point(466, 278);
            this.cbCorApagar.Name = "cbCorApagar";
            this.cbCorApagar.Size = new System.Drawing.Size(186, 26);
            this.cbCorApagar.TabIndex = 6;
            this.cbCorApagar.DropDown += new System.EventHandler(this.cbCorApagar_DropDown);
            this.cbCorApagar.SelectedIndexChanged += new System.EventHandler(this.cbCorApagar_SelectedIndexChanged);
            // 
            // lblCorApagar
            // 
            this.lblCorApagar.AutoSize = true;
            this.lblCorApagar.Location = new System.Drawing.Point(467, 257);
            this.lblCorApagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorApagar.Name = "lblCorApagar";
            this.lblCorApagar.Size = new System.Drawing.Size(51, 18);
            this.lblCorApagar.TabIndex = 7;
            this.lblCorApagar.Text = "Cores";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(528, 310);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(124, 33);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Location = new System.Drawing.Point(110, 415);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(384, 26);
            this.txtNovoNome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Novo Nome";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(500, 411);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(124, 33);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Editar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // formCores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(664, 466);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblCorApagar);
            this.Controls.Add(this.cbCorApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formCores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cbCorApagar;
        private System.Windows.Forms.Label lblCorApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterar;
    }
}

