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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(10, 389);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series22.LabelBorderWidth = 2;
            series22.Legend = "Legend1";
            series22.Name = "Convergencia";
            this.chart1.Series.Add(series22);
            this.chart1.Size = new System.Drawing.Size(901, 361);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title13.Name = "Title1";
            title13.Text = "Convergencia del calculo de la TIR";
            this.chart1.Titles.Add(title13);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(796, 824);
            this.Calcular.Margin = new System.Windows.Forms.Padding(2);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(115, 36);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 777);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inversion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inveTex
            // 
            this.inveTex.Location = new System.Drawing.Point(544, 793);
            this.inveTex.Margin = new System.Windows.Forms.Padding(2);
            this.inveTex.Name = "inveTex";
            this.inveTex.Size = new System.Drawing.Size(116, 20);
            this.inveTex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 867);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de salvamento";
            // 
            // pertex
            // 
            this.pertex.Location = new System.Drawing.Point(544, 840);
            this.pertex.Margin = new System.Windows.Forms.Padding(2);
            this.pertex.Name = "pertex";
            this.pertex.Size = new System.Drawing.Size(116, 20);
            this.pertex.TabIndex = 5;
            // 
            // vsstex
            // 
            this.vsstex.Location = new System.Drawing.Point(544, 883);
            this.vsstex.Margin = new System.Windows.Forms.Padding(2);
            this.vsstex.Name = "vsstex";
            this.vsstex.Size = new System.Drawing.Size(116, 20);
            this.vsstex.TabIndex = 5;
            this.vsstex.TextChanged += new System.EventHandler(this.vsstex_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 824);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Periodo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 492);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // poblacionNumeroTex
            // 
            this.poblacionNumeroTex.Location = new System.Drawing.Point(674, 793);
            this.poblacionNumeroTex.Margin = new System.Windows.Forms.Padding(2);
            this.poblacionNumeroTex.Name = "poblacionNumeroTex";
            this.poblacionNumeroTex.Size = new System.Drawing.Size(116, 20);
            this.poblacionNumeroTex.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 773);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Poblacion AG";
            // 
            // Resultados
            // 
            this.Resultados.Location = new System.Drawing.Point(8, 773);
            this.Resultados.Margin = new System.Windows.Forms.Padding(2);
            this.Resultados.Multiline = true;
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(530, 223);
            this.Resultados.TabIndex = 11;
            this.Resultados.TextChanged += new System.EventHandler(this.Resultados_TextChanged);
            // 
            // Resultadosdd
            // 
            this.Resultadosdd.AutoSize = true;
            this.Resultadosdd.Location = new System.Drawing.Point(7, 758);
            this.Resultadosdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Resultadosdd.Name = "Resultadosdd";
            this.Resultadosdd.Size = new System.Drawing.Size(161, 13);
            this.Resultadosdd.TabIndex = 12;
            this.Resultadosdd.Text = "Resultados del calculo de la TIR";
            this.Resultadosdd.Click += new System.EventHandler(this.label6_Click);
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(10, 23);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series23.Legend = "Legend1";
            series23.Name = "Poblacion Inicial";
            series23.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series23.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series24.Legend = "Legend1";
            series24.Name = "Poblacion Final";
            this.chart2.Series.Add(series23);
            this.chart2.Series.Add(series24);
            this.chart2.Size = new System.Drawing.Size(901, 350);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            title14.Name = "Title1";
            title14.Text = "Espacio de busqueda para el calculo de la  TIR";
            this.chart2.Titles.Add(title14);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Resultados de convergencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Espacio de busqueda";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ResultadosFNE
            // 
            this.ResultadosFNE.Location = new System.Drawing.Point(915, 770);
            this.ResultadosFNE.Margin = new System.Windows.Forms.Padding(2);
            this.ResultadosFNE.Multiline = true;
            this.ResultadosFNE.Name = "ResultadosFNE";
            this.ResultadosFNE.Size = new System.Drawing.Size(498, 219);
            this.ResultadosFNE.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1043, 650);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Resultados de la optimizacion de los FNE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // chart3
            // 
            chartArea15.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart3.Legends.Add(legend15);
            this.chart3.Location = new System.Drawing.Point(915, 23);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series25.BorderWidth = 2;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series25.Legend = "Legend1";
            series25.Name = "ProbMutacion";
            series26.BorderWidth = 2;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series26.Legend = "Legend1";
            series26.Name = "Mutacion";
            this.chart3.Series.Add(series25);
            this.chart3.Series.Add(series26);
            this.chart3.Size = new System.Drawing.Size(939, 350);
            this.chart3.TabIndex = 22;
            this.chart3.Text = "chart3";
            title15.Name = "Title1";
            title15.Text = "Tasa de Mutacion Variable";
            this.chart3.Titles.Add(title15);
            // 
            // chart4
            // 
            chartArea16.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart4.Legends.Add(legend16);
            this.chart4.Location = new System.Drawing.Point(915, 389);
            this.chart4.Margin = new System.Windows.Forms.Padding(2);
            this.chart4.Name = "chart4";
            series27.BorderWidth = 2;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series27.Legend = "Legend1";
            series27.Name = "ProbCruce";
            series28.BorderWidth = 2;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series28.Legend = "Legend1";
            series28.Name = "Cruce";
            this.chart4.Series.Add(series27);
            this.chart4.Series.Add(series28);
            this.chart4.Size = new System.Drawing.Size(939, 361);
            this.chart4.TabIndex = 23;
            this.chart4.Text = "chart4";
            title16.Name = "Tasa de cruce";
            title16.Text = "Tasa de Cruce";
            this.chart4.Titles.Add(title16);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(912, 752);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Resultados de la optimizacion de los FNE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1865, 1007);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label7;
    }
}

