namespace ExemploListaWFA
{
    partial class Principal
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
            this.btnExemplo01 = new System.Windows.Forms.Button();
            this.btnExemplo02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExemplo01
            // 
            this.btnExemplo01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemplo01.Location = new System.Drawing.Point(24, 12);
            this.btnExemplo01.Name = "btnExemplo01";
            this.btnExemplo01.Size = new System.Drawing.Size(144, 37);
            this.btnExemplo01.TabIndex = 0;
            this.btnExemplo01.Text = "Exemplo 01";
            this.btnExemplo01.UseVisualStyleBackColor = true;
            this.btnExemplo01.Click += new System.EventHandler(this.btnExemplo01_Click);
            // 
            // btnExemplo02
            // 
            this.btnExemplo02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemplo02.Location = new System.Drawing.Point(24, 56);
            this.btnExemplo02.Name = "btnExemplo02";
            this.btnExemplo02.Size = new System.Drawing.Size(144, 37);
            this.btnExemplo02.TabIndex = 1;
            this.btnExemplo02.Text = "Exemplo 02";
            this.btnExemplo02.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 105);
            this.Controls.Add(this.btnExemplo02);
            this.Controls.Add(this.btnExemplo01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExemplo01;
        private System.Windows.Forms.Button btnExemplo02;
    }
}

