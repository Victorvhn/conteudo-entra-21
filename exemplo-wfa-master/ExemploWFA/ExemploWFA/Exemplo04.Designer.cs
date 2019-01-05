namespace ExemploWFA
{
    partial class Exemplo04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exemplo04));
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbPlayerFrancisGodsbattlegrounds = new System.Windows.Forms.RadioButton();
            this.rbLegueOfFrancisco = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGostaDeJogo = new System.Windows.Forms.GroupBox();
            this.gbNomeDoJogo = new System.Windows.Forms.GroupBox();
            this.gbGostaDeJogo.SuspendLayout();
            this.gbNomeDoJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Checked = true;
            this.rbSim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(6, 22);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(61, 26);
            this.rbSim.TabIndex = 0;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(6, 48);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(62, 26);
            this.rbNao.TabIndex = 1;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbPlayerFrancisGodsbattlegrounds
            // 
            this.rbPlayerFrancisGodsbattlegrounds.AutoSize = true;
            this.rbPlayerFrancisGodsbattlegrounds.Checked = true;
            this.rbPlayerFrancisGodsbattlegrounds.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayerFrancisGodsbattlegrounds.Location = new System.Drawing.Point(6, 48);
            this.rbPlayerFrancisGodsbattlegrounds.Name = "rbPlayerFrancisGodsbattlegrounds";
            this.rbPlayerFrancisGodsbattlegrounds.Size = new System.Drawing.Size(314, 26);
            this.rbPlayerFrancisGodsbattlegrounds.TabIndex = 2;
            this.rbPlayerFrancisGodsbattlegrounds.TabStop = true;
            this.rbPlayerFrancisGodsbattlegrounds.Text = "PlayerFrancisGod\'s battlegrounds";
            this.rbPlayerFrancisGodsbattlegrounds.UseVisualStyleBackColor = true;
            // 
            // rbLegueOfFrancisco
            // 
            this.rbLegueOfFrancisco.AutoSize = true;
            this.rbLegueOfFrancisco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLegueOfFrancisco.Location = new System.Drawing.Point(6, 22);
            this.rbLegueOfFrancisco.Name = "rbLegueOfFrancisco";
            this.rbLegueOfFrancisco.Size = new System.Drawing.Size(196, 26);
            this.rbLegueOfFrancisco.TabIndex = 3;
            this.rbLegueOfFrancisco.Text = "Legue Of Francisco";
            this.rbLegueOfFrancisco.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, -25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // gbGostaDeJogo
            // 
            this.gbGostaDeJogo.Controls.Add(this.label1);
            this.gbGostaDeJogo.Controls.Add(this.rbSim);
            this.gbGostaDeJogo.Controls.Add(this.rbNao);
            this.gbGostaDeJogo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGostaDeJogo.Location = new System.Drawing.Point(213, 34);
            this.gbGostaDeJogo.Name = "gbGostaDeJogo";
            this.gbGostaDeJogo.Size = new System.Drawing.Size(200, 74);
            this.gbGostaDeJogo.TabIndex = 6;
            this.gbGostaDeJogo.TabStop = false;
            this.gbGostaDeJogo.Text = "Gosta de Jogo";
            // 
            // gbNomeDoJogo
            // 
            this.gbNomeDoJogo.BackColor = System.Drawing.Color.White;
            this.gbNomeDoJogo.Controls.Add(this.rbPlayerFrancisGodsbattlegrounds);
            this.gbNomeDoJogo.Controls.Add(this.rbLegueOfFrancisco);
            this.gbNomeDoJogo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNomeDoJogo.Location = new System.Drawing.Point(12, 294);
            this.gbNomeDoJogo.Name = "gbNomeDoJogo";
            this.gbNomeDoJogo.Size = new System.Drawing.Size(342, 82);
            this.gbNomeDoJogo.TabIndex = 7;
            this.gbNomeDoJogo.TabStop = false;
            this.gbNomeDoJogo.Text = "Nome do jogo";
            // 
            // Exemplo04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(358, 388);
            this.Controls.Add(this.gbNomeDoJogo);
            this.Controls.Add(this.gbGostaDeJogo);
            this.Name = "Exemplo04";
            this.Text = "Exemplo04";
            this.gbGostaDeJogo.ResumeLayout(false);
            this.gbGostaDeJogo.PerformLayout();
            this.gbNomeDoJogo.ResumeLayout(false);
            this.gbNomeDoJogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbPlayerFrancisGodsbattlegrounds;
        private System.Windows.Forms.RadioButton rbLegueOfFrancisco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGostaDeJogo;
        private System.Windows.Forms.GroupBox gbNomeDoJogo;
    }
}