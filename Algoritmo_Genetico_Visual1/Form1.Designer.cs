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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultadosFNE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 414);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.Name = "Convergencia";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(995, 368);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Convergencia del calculo de la TIR";
            this.chart1.Titles.Add(title1);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(936, 903);
            this.Calcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(153, 44);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 820);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inversion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inveTex
            // 
            this.inveTex.Location = new System.Drawing.Point(635, 839);
            this.inveTex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inveTex.Name = "inveTex";
            this.inveTex.Size = new System.Drawing.Size(153, 22);
            this.inveTex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 930);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de salvamento";
            // 
            // pertex
            // 
            this.pertex.Location = new System.Drawing.Point(635, 897);
            this.pertex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pertex.Name = "pertex";
            this.pertex.Size = new System.Drawing.Size(153, 22);
            this.pertex.TabIndex = 5;
            // 
            // vsstex
            // 
            this.vsstex.Location = new System.Drawing.Point(635, 950);
            this.vsstex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vsstex.Name = "vsstex";
            this.vsstex.Size = new System.Drawing.Size(153, 22);
            this.vsstex.TabIndex = 5;
            this.vsstex.TextChanged += new System.EventHandler(this.vsstex_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 878);
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
            this.poblacionNumeroTex.Location = new System.Drawing.Point(820, 839);
            this.poblacionNumeroTex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poblacionNumeroTex.Name = "poblacionNumeroTex";
            this.poblacionNumeroTex.Size = new System.Drawing.Size(153, 22);
            this.poblacionNumeroTex.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 820);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Poblacion AG";
            // 
            // Resultados
            // 
            this.Resultados.Location = new System.Drawing.Point(12, 820);
            this.Resultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resultados.Multiline = true;
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(615, 174);
            this.Resultados.TabIndex = 11;
            this.Resultados.TextChanged += new System.EventHandler(this.Resultados_TextChanged);
            // 
            // Resultadosdd
            // 
            this.Resultadosdd.AutoSize = true;
            this.Resultadosdd.Location = new System.Drawing.Point(12, 800);
            this.Resultadosdd.Name = "Resultadosdd";
            this.Resultadosdd.Size = new System.Drawing.Size(211, 17);
            this.Resultadosdd.TabIndex = 12;
            this.Resultadosdd.Text = "Resultados del calculo de la TIR";
            this.Resultadosdd.Click += new System.EventHandler(this.label6_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(15, 28);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Poblacion Inicial";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Poblacion Final";
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(995, 351);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Espacio de busqueda para el calculo de la  TIR";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Resultados de convergencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Espacio de busqueda";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ResultadosFNE
            // 
            this.ResultadosFNE.Location = new System.Drawing.Point(1395, 820);
            this.ResultadosFNE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultadosFNE.Multiline = true;
            this.ResultadosFNE.Name = "ResultadosFNE";
            this.ResultadosFNE.Size = new System.Drawing.Size(615, 174);
            this.ResultadosFNE.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1391, 800);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Resultados de la optimizacion de los FNE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(1098, 28);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "ProbMutacion";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Mutacion";
            this.chart3.Series.Add(series4);
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(882, 376);
            this.chart3.TabIndex = 22;
            this.chart3.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Tasa de Mutacion Variable";
            this.chart3.Titles.Add(title3);
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(1098, 439);
            this.chart4.Name = "chart4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "ProbCruce";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Cruce";
            this.chart4.Series.Add(series6);
            this.chart4.Series.Add(series7);
            this.chart4.Size = new System.Drawing.Size(882, 376);
            this.chart4.TabIndex = 23;
            this.chart4.Text = "chart4";
            title4.Name = "Tasa de cruce";
            title4.Text = "Tasa de Cruce";
            this.chart4.Titles.Add(title4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2028, 1013);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResultadosFNE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ResultadosFNE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}

