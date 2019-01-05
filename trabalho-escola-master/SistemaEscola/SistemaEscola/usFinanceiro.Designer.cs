namespace SistemaEscola
{
    partial class usFinanceiro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Financeiro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_Maior = new System.Windows.Forms.CheckBox();
            this.cb_Menor = new System.Windows.Forms.CheckBox();
            this.cb_Media = new System.Windows.Forms.CheckBox();
            this.cb_3D = new System.Windows.Forms.CheckBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Financeiro)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Financeiro
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Financeiro.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Financeiro.Legends.Add(legend1);
            this.chart_Financeiro.Location = new System.Drawing.Point(173, 15);
            this.chart_Financeiro.Name = "chart_Financeiro";
            this.chart_Financeiro.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart_Financeiro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Maior";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Menor";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Média";
            this.chart_Financeiro.Series.Add(series1);
            this.chart_Financeiro.Series.Add(series2);
            this.chart_Financeiro.Series.Add(series3);
            this.chart_Financeiro.Size = new System.Drawing.Size(1002, 459);
            this.chart_Financeiro.TabIndex = 0;
            this.chart_Financeiro.Text = "chart1";
            // 
            // cb_Maior
            // 
            this.cb_Maior.AutoSize = true;
            this.cb_Maior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Maior.Location = new System.Drawing.Point(20, 43);
            this.cb_Maior.Name = "cb_Maior";
            this.cb_Maior.Size = new System.Drawing.Size(67, 22);
            this.cb_Maior.TabIndex = 1;
            this.cb_Maior.Text = "Maior";
            this.cb_Maior.UseVisualStyleBackColor = true;
            this.cb_Maior.CheckedChanged += new System.EventHandler(this.cb_Maior_CheckedChanged);
            // 
            // cb_Menor
            // 
            this.cb_Menor.AutoSize = true;
            this.cb_Menor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Menor.Location = new System.Drawing.Point(20, 71);
            this.cb_Menor.Name = "cb_Menor";
            this.cb_Menor.Size = new System.Drawing.Size(71, 22);
            this.cb_Menor.TabIndex = 2;
            this.cb_Menor.Text = "Menor";
            this.cb_Menor.UseVisualStyleBackColor = true;
            this.cb_Menor.CheckedChanged += new System.EventHandler(this.cb_Menor_CheckedChanged);
            // 
            // cb_Media
            // 
            this.cb_Media.AutoSize = true;
            this.cb_Media.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Media.Location = new System.Drawing.Point(20, 99);
            this.cb_Media.Name = "cb_Media";
            this.cb_Media.Size = new System.Drawing.Size(71, 22);
            this.cb_Media.TabIndex = 3;
            this.cb_Media.Text = "Média";
            this.cb_Media.UseVisualStyleBackColor = true;
            this.cb_Media.CheckedChanged += new System.EventHandler(this.cb_Media_CheckedChanged);
            // 
            // cb_3D
            // 
            this.cb_3D.AutoSize = true;
            this.cb_3D.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_3D.Location = new System.Drawing.Point(20, 15);
            this.cb_3D.Name = "cb_3D";
            this.cb_3D.Size = new System.Drawing.Size(48, 22);
            this.cb_3D.TabIndex = 5;
            this.cb_3D.Text = "3D";
            this.cb_3D.UseVisualStyleBackColor = true;
            this.cb_3D.CheckedChanged += new System.EventHandler(this.cb_3D_CheckedChanged);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(20, 168);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(130, 34);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar Grafico";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            this.btn_Limpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Atualizar_KeyDown);
            // 
            // usFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.cb_3D);
            this.Controls.Add(this.cb_Media);
            this.Controls.Add(this.cb_Menor);
            this.Controls.Add(this.cb_Maior);
            this.Controls.Add(this.chart_Financeiro);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usFinanceiro";
            this.Size = new System.Drawing.Size(1178, 517);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Financeiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Financeiro;
        private System.Windows.Forms.CheckBox cb_Maior;
        private System.Windows.Forms.CheckBox cb_Menor;
        private System.Windows.Forms.CheckBox cb_Media;
        private System.Windows.Forms.CheckBox cb_3D;
        private System.Windows.Forms.Button btn_Limpar;
    }
}
