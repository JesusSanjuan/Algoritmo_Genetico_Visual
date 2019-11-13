namespace Algoritmo_Genetico_Visual1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inveTex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pertex = new System.Windows.Forms.TextBox();
            this.vsstex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.poblacionNumeroTex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Resultados = new System.Windows.Forms.TextBox();
            this.Resultadosdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.Name = "Convergencia";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1150, 583);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(1187, 682);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(152, 103);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1168, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inversion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inveTex
            // 
            this.inveTex.Location = new System.Drawing.Point(1171, 32);
            this.inveTex.Name = "inveTex";
            this.inveTex.Size = new System.Drawing.Size(153, 22);
            this.inveTex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1168, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de salvamento";
            // 
            // pertex
            // 
            this.pertex.Location = new System.Drawing.Point(1171, 89);
            this.pertex.Name = "pertex";
            this.pertex.Size = new System.Drawing.Size(153, 22);
            this.pertex.TabIndex = 5;
            // 
            // vsstex
            // 
            this.vsstex.Location = new System.Drawing.Point(1171, 146);
            this.vsstex.Name = "vsstex";
            this.vsstex.Size = new System.Drawing.Size(153, 22);
            this.vsstex.TabIndex = 5;
            this.vsstex.TextChanged += new System.EventHandler(this.vsstex_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1168, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Periodo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // poblacionNumeroTex
            // 
            this.poblacionNumeroTex.Location = new System.Drawing.Point(1171, 213);
            this.poblacionNumeroTex.Name = "poblacionNumeroTex";
            this.poblacionNumeroTex.Size = new System.Drawing.Size(153, 22);
            this.poblacionNumeroTex.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1168, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Poblacion AG";
            // 
            // Resultados
            // 
            this.Resultados.Location = new System.Drawing.Point(15, 626);
            this.Resultados.Multiline = true;
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(1147, 174);
            this.Resultados.TabIndex = 11;
            // 
            // Resultadosdd
            // 
            this.Resultadosdd.AutoSize = true;
            this.Resultadosdd.Location = new System.Drawing.Point(12, 606);
            this.Resultadosdd.Name = "Resultadosdd";
            this.Resultadosdd.Size = new System.Drawing.Size(79, 17);
            this.Resultadosdd.TabIndex = 12;
            this.Resultadosdd.Text = "Resultados";
            this.Resultadosdd.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 812);
            this.Controls.Add(this.Resultadosdd);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.poblacionNumeroTex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vsstex);
            this.Controls.Add(this.pertex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inveTex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inveTex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pertex;
        private System.Windows.Forms.TextBox vsstex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox poblacionNumeroTex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Resultados;
        private System.Windows.Forms.Label Resultadosdd;
    }
}

