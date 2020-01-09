using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Algoritmo_Genetico_Visual1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultados.Text = "";
            ResultadosFNE.Text = "";
            String inve, per, vss;
            double inversion, VS;
            int periodo;
            inve = inveTex.Text;
            per = pertex.Text;
            vss = vsstex.Text;

            double[] FNE = new double[Convert.ToInt32(per)];


            FNE[0] = Convert.ToDouble(2000);
            FNE[1] = Convert.ToDouble(1000);
            FNE[2] = Convert.ToDouble(3000);
            FNE[3] = Convert.ToDouble(3000);
            FNE[4] = Convert.ToDouble(1000);
            /* for (int x = 0; x < Convert.ToInt32(per); x++)
             {
                 Console.WriteLine("\tIntroduzca el FNE {0}: ", x + 1);
                 String temporal = Console.ReadLine();
                 FNE[x] = Convert.ToDouble(temporal);
             }*/

            inversion = Convert.ToDouble(inve);
            periodo = Convert.ToInt32(per);
            VS = Convert.ToDouble(vss);

            String poblacionNumero;
            poblacionNumero = poblacionNumeroTex.Text;


            Resultados.Text = "\r\nAproximacion inicial encontrada";
            Resultados.Text = Resultados.Text+ "\r\n\n******************INICIO DE LA BUSQUEDA DE LA TIR.*****************\r\n\n";

            List<double> porcentajeconvergenciagrafica = new List<double>();            

            Stopwatch tiempo = Stopwatch.StartNew();

            double aproxInicial = aproximacioninicial(inversion, FNE, periodo);

            Random random = new Random();
            double minimo = aproxInicial - 1000;
            double maximo = aproxInicial + 1000;

            List<double> poblacion = new List<double>();

            while (poblacion.Count < Int32.Parse(poblacionNumero))
            {
                double numeroAleatorio = random.NextDouble() * (maximo - minimo) + minimo;
                if (!poblacion.Contains(numeroAleatorio))
                {
                    poblacion.Add(numeroAleatorio);
                }
            }
            List<double> poblacionGrafica = new List<double>(poblacion);
            
            int i = 1;
            double porcentajeconvergencia = 0;
            double porcentaje = (((double)100) / Int32.Parse(poblacionNumero));
            List<double> ResultadosFX;
            Random random2 = new Random();
            do
            {
                ResultadosFX = fx(inversion, FNE, VS, poblacion, periodo);

                List<int> torneo1 = posTorneo(0, poblacion.Count / 2);
                List<int> torneo2 = posTorneo(poblacion.Count / 2, poblacion.Count);
                List<double> padre = Seleccion(torneo1, torneo2, ResultadosFX, poblacion);

                List<int> cruce1 = posTorneo(0, padre.Count / 2);
                List<int> cruce2 = posTorneo(padre.Count / 2, padre.Count);

                List<double> hijos_Generados = new List<double>();

                double probCruz = random2.NextDouble();

                if (probCruz < 0.9)
                {
                    hijos_Generados = CruceTotal(padre, cruce1, cruce2, i);
                }
                else
                {
                    hijos_Generados = padre;
                }

                poblacion.Clear();
                poblacion = padre.Concat(hijos_Generados).ToList();
                poblacion = DesordenarLista(poblacion);

                var agrupacion = poblacion.GroupBy(x => x).Select(g => g.Count()).ToList();
                agrupacion = agrupacion.OrderByDescending(o => o).ToList();
                var agrupacion2 = agrupacion.GroupBy(x => x).Select(g => new { Text = g.Key, Count = g.Count() }).ToList();
                var agrupacion3 = agrupacion.GroupBy(x => x).Select(g => g.Key).ToList();
                var valormax = agrupacion3.Max();

                foreach (var el in agrupacion2)
                {
                    if (el.Text == valormax && el.Count == 1)
                    {
                        double valor = Convert.ToDouble(el.Text);
                        porcentajeconvergencia = porcentaje * valor;
                    }
                    break;
                }
                Resultados.Text = Resultados.Text + "\tGeneracion: " +i+" , Convergencia del: "+ porcentajeconvergencia + "\r\n";
               // Console.WriteLine("\tGeneracion: {0} , Convergencia del: {1}\n", i, porcentajeconvergencia);                
                porcentajeconvergenciagrafica.Add(porcentajeconvergencia);

                if(porcentajeconvergencia < (double)99.9)
                {
                    i = i + 1;
                }                
            } while (porcentajeconvergencia < (double)99.9);
            tiempo.Stop();            

            chart1.Series["Convergencia"].Points.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Generaciones";
            chart1.ChartAreas[0].AxisY.Title = "Porcentaje de Convergencia";            
            for (int a=1; a<porcentajeconvergenciagrafica.Count+1;a++)
            {
                chart1.Series["Convergencia"].Points.AddXY(a, porcentajeconvergenciagrafica[a-1]);
            }

            /*Limites de ejes de grafica*/
            chart1.ChartAreas[0].AxisY.Maximum = 100; 
                double valorConDecimal = (double)porcentajeconvergenciagrafica.Count / 10;
                long valorSinDecimal = (long)valorConDecimal;
                double decimales = valorConDecimal - (double)valorSinDecimal;
                if(decimales!=0)
                {
                    valorSinDecimal=valorSinDecimal + 1;
                }
                int someIntT = (int)valorSinDecimal * 10;
                chart1.ChartAreas[0].AxisX.Maximum = someIntT;
                chart1.ChartAreas[0].AxisX.Interval = someIntT/10;

                chart2.Series["Poblacion Inicial"].Points.Clear();
                chart2.Series["Poblacion Final"].Points.Clear();
                chart2.ChartAreas[0].AxisX.Title = "Numero Cromosoma";
                chart2.ChartAreas[0].AxisY.Title = "Valor de Cromosoma";
                for (int a = 1; a < Int32.Parse(poblacionNumero); a++)
                {
                    chart2.Series["Poblacion Inicial"].Points.AddXY(a, poblacionGrafica[a]);
                    //chart2.Series["Poblacion Final"].Points.AddXY(a, poblacion[a]);
                }
                chart2.ChartAreas[0].AxisX.Interval = Int32.Parse(poblacionNumero) / 10;
                chart2.ChartAreas[0].AxisY.Maximum = maximo+200;
            /*Limites de ejes de grafica*/

            Resultados.Text = Resultados.Text + "\r\n******************CONCLUIDA LA BUSQUEDA DE LA TIR.*****************";
            var resultTIR = poblacion.GroupBy(x => x).Select(g => new { Text = g.Key, Count = g.Count() }).ToList();
            resultTIR = resultTIR.OrderByDescending(o => o.Count).ToList();

            var resultTMR = ResultadosFX.GroupBy(x => x).Select(g => new { Text = g.Key, Count = g.Count() }).ToList();
            resultTMR = resultTMR.OrderByDescending(o => o.Count).ToList();

            ResultadosFNE.Text = ResultadosFNE.Text + "\r\n\r\n******************INICIO DE OPTIMIZACION DE FNE.*******************\r\n\r\n";

            /*Optimizacion de  FLUJOS NETOS DE EFECTIVO*/

            List<double> porcentajeconvergenciagrafica2 = new List<double>();

            Stopwatch tiempofne = Stopwatch.StartNew();
            List<double> FNEList = FNE.ToList();
            double FNEMax = FNEList.Max();
            double FNEMin = FNEList.Min();

            double porcentajeFNEMax = FNEMax / 100;
            double porcentajeFNEMin = FNEMin / 100;

            FNEMax = FNEMax + (porcentajeFNEMax * 10);
            FNEMin = FNEMin - (porcentajeFNEMin * 10);

            List<List<double>> poblacion2 = new List<List<double>>();

            while (poblacion2.Count < Int32.Parse(poblacionNumero))
            {
                List<double> poblaciontem = new List<double>();
                while (poblaciontem.Count < Convert.ToInt32(per))
                {
                    double numeroAleatorio = random.NextDouble() * ((FNEMax + 1) - (FNEMin - 1)) + (FNEMin - 1);
                    if (!poblaciontem.Contains(numeroAleatorio))
                    {
                        poblaciontem.Add(numeroAleatorio);
                    }
                }
                poblacion2.Add(poblaciontem);
            }

            List<List<double>> poblacionGrafica2 = new List<List<double>>(poblacion2);

            int j = 1;
            double porcentajeconvergencia2 = 0;
            double porcentaje2 = (((double)100) / Int32.Parse(poblacionNumero));
            List<double> ResultadosFX2;
            Random random2b = new Random();
            do
            {
                ResultadosFX2 = fxFNE(inversion, poblacion2, VS, Convert.ToDouble(resultTIR[0].Text), periodo);

                List<int> torneo1b = posTorneo(0, poblacion2.Count / 2);
                List<int> torneo2b = posTorneo(poblacion2.Count / 2, poblacion2.Count);
                List<List<double>> padre2 = SeleccionFNE(torneo1b, torneo2b, ResultadosFX2, poblacion2, FNEMax);

                List<int> cruce1b = posTorneo(0, padre2.Count / 2);
                List<int> cruce2b = posTorneo(padre2.Count / 2, padre2.Count);

                List<List<double>> hijos_Generadosb = new List<List<double>>();

                double probCruzb = random2b.NextDouble();

                if (probCruzb < 0.9)
                {
                    hijos_Generadosb = CruceTotal2(padre2, cruce1b, cruce2b, j);
                }
                else
                {
                    hijos_Generadosb = padre2;
                }

                poblacion2.Clear();
                poblacion2 = padre2.Concat(hijos_Generadosb).ToList();
                poblacion2 = DesordenarLista(poblacion2);
                //List<List<double>> poblacionanalisis = new List<List<double>>(poblacion2); permite pasar en otra lista
                List<double> convergencia = medir_convergencia2(poblacion2);
                var agrupacion = convergencia.OrderByDescending(o => o).ToList();
                var agrupacion2 = agrupacion.GroupBy(x => x).Select(g => new { Text = g.Key, Count = g.Count() }).ToList();
                var valormax = agrupacion.Max();

                foreach (var el in agrupacion2)
                {
                    if (el.Text == valormax && el.Count == 1)
                    {
                        double valor = Convert.ToDouble(el.Text);
                        porcentajeconvergencia2 = porcentaje2 * valor;
                    }
                    break;
                }
                ResultadosFNE.Text = ResultadosFNE.Text + "\tGeneracion: " + j + " , Convergencia del: " + porcentajeconvergencia2 + "\r\n";
                porcentajeconvergenciagrafica2.Add(porcentajeconvergencia2);
                if (porcentajeconvergencia2 < (double)99.9)
                {
                    j = j + 1;
                }                
                
            } while (porcentajeconvergencia2 < (double)99.9);
            tiempofne.Stop();
            ResultadosFNE.Text = ResultadosFNE.Text + "\r\n******************FINALIZACION DE OPTIMIZACION DE FNE.*******************\r\n\r\n";
            /*Optimiazacion de  FLUJOS NETOS DE EFECTIVO*/                   

            chart4.Series["Convergencia"].Points.Clear();
            chart4.ChartAreas[0].AxisX.Title = "Generaciones";
            chart4.ChartAreas[0].AxisY.Title = "Porcentaje de Convergencia";
            for (int a = 1; a < porcentajeconvergenciagrafica2.Count+1; a++)
            {
                chart4.Series["Convergencia"].Points.AddXY(a, porcentajeconvergenciagrafica2[a-1]);
            }

            chart3.ChartAreas[0].AxisX.Title = "Numero Cromosoma";
            chart3.ChartAreas[0].AxisY.Title = "Valor de Cromosoma";
            for (int c = 0; c < periodo; c++)
            {
                try
                {
                    chart3.Series.Add("Cromosoma " + c);
                    chart3.Series["Cromosoma " + c].ChartType = SeriesChartType.Point;
                }
                catch (System.ArgumentException ae)
                {

                }
            }

            for (int c = 0; c < periodo; c++)
            {
                chart3.Series["Cromosoma " + c].Points.Clear();
            }

            for (int a = 1; a < Int32.Parse(poblacionNumero); a++)
            {
                 List<double> temporal = new List<double>();
                temporal=poblacionGrafica2[a];
                for (int b = 0; b < temporal.Count; b++)
                {
                    chart3.Series["Cromosoma " + b].Points.AddXY(a, temporal[b]);

                }                
            }


            /*Limites de ejes de grafica*/
                chart3.ChartAreas[0].AxisX.Interval = Int32.Parse(poblacionNumero) / 10;
                //chart3.ChartAreas[0].AxisY.Maximum = FNEMax;

                chart4.ChartAreas[0].AxisY.Maximum = 100;
                double valorConDecimal2 = (double)porcentajeconvergenciagrafica2.Count / 10;
                long valorSinDecimal2 = (long)valorConDecimal2;
                double decimales2 = valorConDecimal2 - (double)valorSinDecimal2;
                if (decimales2 != 0)
                {
                    valorSinDecimal2 = valorSinDecimal2 + 1;
                }
                int someIntT2 = (int)valorSinDecimal2 * 10;
                chart4.ChartAreas[0].AxisX.Maximum = someIntT2;
                chart4.ChartAreas[0].AxisX.Interval = someIntT2 / 10;
            /*Limites de ejes de grafica*/


            /*     for (int c = 0; c < periodo; c++)
                 {
                     try
                     {
                         chart3.Series.Add("Cromosoma Optimo " + c);
                         chart3.Series["Cromosoma Optimo " + c].ChartType = SeriesChartType.Point;
                     }
                     catch (System.ArgumentException ae)
                     {

                     }
                 }

                 for (int c = 0; c < periodo; c++)
                 {
                     chart3.Series["Cromosoma Optimo " + c].Points.Clear();
                 }

                 for (int a = 0; a < Int32.Parse(poblacionNumero); a++)
                 {
                     List<double> temporal2 = new List<double>();
                     temporal2 = poblacion2[a];
                     for (int b = 0; b < temporal2.Count; b++)
                     {
                         chart3.Series["Cromosoma Optimo " + b].Points.AddXY(a, temporal2[b]);

                     }
                 }*/

            /*IMPRIMIENDO RESULTADOS FINALES*/
            Resultados.Text = Resultados.Text + "********RESULTADOS DE LA BUSQUEDA DE LA TIR*************";
            Resultados.Text = Resultados.Text + "\r\n\tAproximacion inicial es:" + aproxInicial + "\r\n";
            Resultados.Text = Resultados.Text + "\tTotal de Generaciones: " + i + " , Convergencia del: " + porcentajeconvergencia;
            Resultados.Text = Resultados.Text + "\r\n\r\n\t\t RESULTADO TMAR: " + resultTMR[0].Text;
            Resultados.Text = Resultados.Text + "\r\n\t\t RESULTADO TIR: " + resultTIR[0].Text;
            Resultados.Text = Resultados.Text + $"\r\n\r\n\t\t\tTiempo para la busqueda de la TIR y TMAR: {tiempo.Elapsed.TotalSeconds} segundos";
            Resultados.Text = Resultados.Text + "\r\n\r\n********RESULTADOS DE LA BUSQUEDA DE LA TIR*************";

            ResultadosFNE.Text = ResultadosFNE.Text + "\r\n\r\n********RESULTADOS DE LA OPTIMIZACION DE LOS FNE************";
            ResultadosFNE.Text = ResultadosFNE.Text + "\r\n\r\n\tTotal de Generaciones: " + j + " , Convergencia del: " + porcentajeconvergencia2 + "\r\n";
            List<double> poblacionMuestra = new List<double>();
            poblacionMuestra = poblacion2[0];
            for (int x = 0; x < poblacionMuestra.Count; x++)
            {
                ResultadosFNE.Text = ResultadosFNE.Text + "\r\n\t\t FNE   Original " + x+": "+FNE[x]+ ",          FNE Opimizado " + x + ": "+ poblacionMuestra[x];
            }
            ResultadosFNE.Text = ResultadosFNE.Text + "\r\n\r\n\t\t\tRESULTADO TMAR: " + ResultadosFX2[0];
            ResultadosFNE.Text = ResultadosFNE.Text + "\r\n\t\t\tRESULTADO TIR: "+ resultTIR[0].Text;
            ResultadosFNE.Text = ResultadosFNE.Text + $"\r\n\r\n\t\t\tTiempo para la optimizacion de los FNE: {tiempofne.Elapsed.TotalSeconds} segundos";
            ResultadosFNE.Text = ResultadosFNE.Text + "\r\n\r\n********RESULTADOS DE LA OPTIMIZACION DE LOS FNE********";
            /*IMPRIMIENDO RESULTADOS FINALES*/
        }
       
        public static double aproximacioninicial(double Inversion, double[] FNE, int Periodo)
        {
            double resultado, sumasuperior = 0, sumainferior = 0;
            for (int i = 0; i < FNE.Length; i++)
            {
                double t = (FNE[i] * (i + 1));
                sumasuperior = sumasuperior + t;
                sumainferior = sumainferior + FNE[i];
            }
            resultado = sumasuperior / sumainferior;

            double x0;
            double t1 = sumainferior / Inversion;
            t1 = Math.Abs(t1);
            double t2 = 1 / resultado;
            x0 = Math.Pow(t1, t2);
            x0 = (x0 - 1) * 100;
            return x0;
        }

        static List<double> fx(double Inversion, double[] FNE, double VS, List<double> poblacion, int Periodo)
        {
            List<double> ResultadosFX = new List<double>();
            double valorFX = 0;
            foreach (double contenido in poblacion)
            {
                valorFX = CalcularVPN(Inversion, FNE, VS, contenido / 100, Periodo);
                ResultadosFX.Add(valorFX);
            }
            return ResultadosFX;
        }

        static List<int> posTorneo(int inicio, int tamañopoblacion)
        {
            var torneo = new List<int>();
            var resultorneo = new List<int>();
            for (int i = inicio; i < tamañopoblacion; i++)
            {
                torneo.Add(i);
            }
            resultorneo = DesordenarLista(torneo);
            return resultorneo;
        }

        public static List<T> DesordenarLista<T>(List<T> input)
        {
            List<T> arr = input;
            List<T> arrDes = new List<T>();

            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                arrDes.Add(arr[val]);
                arr.RemoveAt(val);
            }
            return arrDes;
        }

        static List<double> Seleccion(List<int> p1, List<int> p2, List<double> ResultadosFX, List<double> poblacion)
        {
            List<double> padre = new List<double>();
            List<double> padrefx = new List<double>();

            for (int i = 0; i < p1.Count; i++)
            {
                double fx1 = ResultadosFX[p1[i]];
                double fx2 = ResultadosFX[p2[i]];

                double pob1 = poblacion[p1[i]];
                double pob2 = poblacion[p2[i]];

                List<double> tem = new List<double>();
                tem.Add(fx1);
                tem.Add(fx2);

                double ganador = 0;
                int indexganadorPob = 0;

                if (fx1 >= 0 && fx2 >= 0)
                {
                    List<double> reorganizacionPos = tem.Where(x => x >= 0).ToList();
                    ganador = reorganizacionPos.Min(x => x);
                    indexganadorPob = ResultadosFX.FindIndex(x => x == ganador);
                    padrefx.Add(ganador);
                    padre.Add(poblacion[indexganadorPob]);
                }
                else if (fx1 < -0 && fx2 < -0)
                {
                    List<double> reorganizacionNega = tem.Where(x => x < 0).ToList();
                    ganador = reorganizacionNega.Max(x => x);
                    indexganadorPob = ResultadosFX.FindIndex(x => x == ganador);
                    padrefx.Add(ganador);
                    padre.Add(poblacion[indexganadorPob]);
                }
                else
                {
                    double fx1p, fx2p;
                    fx1p = Math.Abs(fx1);
                    fx2p = Math.Abs(fx2);

                    tem.Clear();

                    tem.Add(fx1p);
                    tem.Add(fx2p);

                    if (fx1 < -0)
                    {
                        List<double> reorganizacionPos = tem.Where(x => x >= 0).ToList();
                        ganador = reorganizacionPos.Min(x => x);
                        if (fx1p == ganador)
                        {
                            indexganadorPob = ResultadosFX.FindIndex(x => x == fx1);
                            padrefx.Add(fx1);
                            padre.Add(poblacion[indexganadorPob]);
                        }
                        else
                        {
                            indexganadorPob = ResultadosFX.FindIndex(x => x == fx2p);
                            padrefx.Add(fx2);
                            padre.Add(poblacion[indexganadorPob]);
                        }
                    }
                    else
                    {
                        List<double> reorganizacionPos = tem.Where(x => x > 0).ToList();
                        ganador = reorganizacionPos.Min(x => x);
                        if (fx2p == ganador)
                        {
                            indexganadorPob = ResultadosFX.FindIndex(x => x == fx2);
                            padrefx.Add(fx2);
                            padre.Add(poblacion[indexganadorPob]);
                        }
                        else
                        {
                            indexganadorPob = ResultadosFX.FindIndex(x => x == fx1p);
                            padrefx.Add(fx1);
                            padre.Add(poblacion[indexganadorPob]);
                        }
                    }
                }
            }
            return padre;
        }

        static List<double> CruceTotal(List<double> padre, List<int> cruce1, List<int> cruce2, int iteracion)
        {
            Random random = new Random();
            List<double> poblacionnueva1a = Cruce(cruce1, cruce2, padre);
            List<double> poblacionnueva1 = mutacion(poblacionnueva1a, iteracion, random);
            double p = Math.Pow(2 + (((15 - 2) / (80 - 1)) * iteracion), -1);
            cruce1 = DesordenarLista(cruce1);
            cruce2 = DesordenarLista(cruce2);
            List<double> poblacionnueva2a = Cruce(cruce1, cruce2, padre);
            List<double> poblacionnueva2 = mutacion(poblacionnueva2a, iteracion, random);
            return poblacionnueva1.Concat(poblacionnueva2).ToList();
        }

        static List<double> Cruce(List<int> cruce1, List<int> cruce2, List<double> padre)
        {
            List<double> hijos = new List<double>();
            for (int i = 0; i < cruce1.Count; i++)
            {
                double padre1 = padre[cruce1[i]];
                double padre2 = padre[cruce2[i]];

                double media = (padre1 + padre2) / 2;
                //double media_geometrica = (double)Math.Sqrt((Math.Pow((double)padre1,2) * (Math.Pow((double)padre2,2))));
                //double media_geometrica = (double)Math.Sqrt((double)(padre1*padre2));
                hijos.Add(media);
            }
            return hijos;
        }

        static List<double> mutacion(List<double> poblacion1, int iteracion, Random random)
        {
            ////List<double> mutacionResultado = new List<double>();
            double p=0;
            for (int i = 0; i < poblacion1.Count; i++)
            {
                // double numeroAleatorio = random.NextDouble();
                double longitud = Convert.ToString(poblacion1[i]).Length - 1;
                p = Math.Pow(2 + (((longitud - 2) / (80 - 1)) * iteracion), -1);
                // Console.WriteLine("\n\t\t\t\t\tMUTACION {0}", numeroAleatorio);
                if (p > .1)//AQUI PERMITE LA MUTACION lgo invertido
                {
                    double mediageometrica = poblacion1.Sum() / poblacion1.Count;
                    double desviasion = desviasionstandar(poblacion1, mediageometrica);
                    double z = (poblacion1[i] - mediageometrica) / desviasion;
                    poblacion1[i] = poblacion1[i] + z;
                    //Console.WriteLine("\n\t\t\t\tMUTACION");
                }
                else
                {
                    poblacion1[i] = poblacion1[i];
                }
            }
            return poblacion1;
        }

        static double desviasionstandar(List<double> poblacion1, double mediageometrica)
        {
            double sumatoria = 0;
            for (int i = 0; i < poblacion1.Count; i++)
            {
                sumatoria = sumatoria + Math.Pow((poblacion1[0] - mediageometrica), 2);
            }
            return Math.Sqrt(sumatoria / (poblacion1.Count - 1));
        }

        static List<double> CruceImpar(double padre1, double padre2)
        {
            List<double> hijos = new List<double>();
            double media = (padre1 + padre2) / 2;
            hijos.Add(media);
            return hijos;
        }

        public static double CalcularVPN(double Inversion, double[] FNE, double VS, double TMAR, int Periodo)
        {
            double FNEAcumulado = 0, fVPN = 0;
            int i = 0;
            double DivTMAR = 1 + TMAR;
            for (i = 1; i < Periodo; i++)
            {
                double valorinferior = Math.Pow(DivTMAR, i);
                if (valorinferior == 0 && DivTMAR > 0)
                {
                    valorinferior = Double.MaxValue;
                }
                if (valorinferior == 0 && DivTMAR < 0)
                {
                    valorinferior = Double.MinValue;
                }
                FNEAcumulado = FNEAcumulado + (FNE[i - 1] / valorinferior);
            }
            double valorinferiorF = Math.Pow(DivTMAR, i);
            if (valorinferiorF == 0 && DivTMAR > 0)
            {
                valorinferiorF = Double.MaxValue;
            }
            if (valorinferiorF == 0 && DivTMAR < 0)
            {
                valorinferiorF = Double.MinValue;
            }
            FNEAcumulado = FNEAcumulado + ((FNE[i - 1] + VS) / valorinferiorF);
            fVPN = -Inversion + FNEAcumulado;
            return fVPN;
        }

        /*Optimiazacion de  FLUJOS NETOS DE EFECTIVO (inversion, poblacion, VS, Tir , periodo);*/
        static List<double> fxFNE(double Inversion, List<List<double>> poblacion, double VS, double tir, int Periodo)
        {
            List<double> ResultadosFX = new List<double>();
            double valorFX = 0;
            foreach (List<double> contenido in poblacion)
            {
                double[] array = contenido.ToArray();
                valorFX = CalcularVPN(Inversion, array, VS, tir / 100, Periodo);
                ResultadosFX.Add(valorFX);
            }
            return ResultadosFX;
        }

        static List<List<double>> SeleccionFNE(List<int> p1, List<int> p2, List<double> ResultadosFX, List<List<double>> poblacion, double FNEMax)
        {
            List<List<double>> padre = new List<List<double>>();
            List<double> padrefx = new List<double>();

            for (int i = 0; i < p1.Count; i++)
            {
                double fx1 = ResultadosFX[p1[i]];
                double fx2 = ResultadosFX[p2[i]];

                List<double> pob1 = poblacion[p1[i]];
                List<double> pob2 = poblacion[p2[i]];

                List<double> tem = new List<double>();
                tem.Add(fx1);
                tem.Add(fx2);

                double ganador = 0;

                int indexganadorPob = 0;

                ganador = tem.Max(x => x);

                indexganadorPob = ResultadosFX.FindIndex(x => x == ganador);

                List<double> pobganador = poblacion[indexganadorPob];

                Boolean t1 = false;
                for (int j = 0; j < pobganador.Count; j++)
                {
                    if (pobganador[j] <= (FNEMax + 100))
                    {
                        t1 = true;
                    }
                    else
                    {
                        t1 = false;
                        break;
                    }

                }
                if (t1)
                {
                    padrefx.Add(ganador);
                    padre.Add(poblacion[indexganadorPob]);
                }
                else
                {
                    double perdedor = 0;
                    int indexperdedorPob = 0;
                    perdedor = tem.Min(x => x);
                    indexperdedorPob = ResultadosFX.FindIndex(x => x == perdedor);
                    padrefx.Add(perdedor);
                    padre.Add(poblacion[indexperdedorPob]);
                }
            }
            return padre;
        }

        static List<List<double>> CruceTotal2(List<List<double>> padre, List<int> cruce1, List<int> cruce2, int iteracion)
        {
            Random random = new Random();
            List<List<double>> poblacionnueva1a = Cruce2(cruce1, cruce2, padre);
            List<List<double>> poblacionnueva1 = mutacion2(poblacionnueva1a, iteracion, random);
            cruce1 = DesordenarLista(cruce1);
            cruce2 = DesordenarLista(cruce2);
            List<List<double>> poblacionnueva2a = Cruce2(cruce1, cruce2, padre);
            List<List<double>> poblacionnueva2 = mutacion2(poblacionnueva2a, iteracion, random);
            return poblacionnueva1.Concat(poblacionnueva2).ToList();
        }

        static List<List<double>> Cruce2(List<int> cruce1, List<int> cruce2, List<List<double>> padre)
        {
            List<List<double>> hijos = new List<List<double>>();
            for (int i = 0; i < cruce1.Count; i++)
            {
                List<double> padre1 = padre[cruce1[i]];
                List<double> padre2 = padre[cruce2[i]];
                List<double> crucemedias = new List<double>();

                for (int j = 0; j < padre1.Count; j++)
                {
                    double media = (padre1[j] + padre2[j]) / 2;
                    crucemedias.Add(media);
                }
                //double media = (padre1 + padre2) / 2;
                //double media_geometrica = (double)Math.Sqrt((Math.Pow((double)padre1,2) * (Math.Pow((double)padre2,2))));
                //double media_geometrica = (double)Math.Sqrt((double)(padre1*padre2));
                hijos.Add(crucemedias);
            }
            return hijos;
        }

        static List<List<double>> mutacion2(List<List<double>> poblacion1, int iteracion, Random random)
        {
            List<List<double>> mutacionResultado = new List<List<double>>();
            for (int i = 0; i < poblacion1.Count; i++)
            {
                List<double> poblaciontrabajo = poblacion1[i];

                for (int j = 0; j < poblaciontrabajo.Count; j++)
                {
                    double longitud = Convert.ToString(poblaciontrabajo[j]).Length - 1;
                    double p = Math.Pow(2 + (((longitud - 2) / (70 - 1)) * iteracion), -1);
                    // double numeroAleatorio = random.NextDouble();

                    // Console.WriteLine("\n\t\t\t\t\tMUTACION {0}", numeroAleatorio);
                    if (p > .1)//AQUI PERMITE LA MUTACION lgo invertido
                    {
                        double mediageometrica = poblaciontrabajo.Sum() / poblaciontrabajo.Count;
                        double desviasion = desviasionstandar(poblaciontrabajo, mediageometrica);
                        double z = (poblaciontrabajo[j] - mediageometrica) / desviasion;
                        poblaciontrabajo[j] = poblaciontrabajo[j] + z;
                        //Console.WriteLine("\n\t\t\t\tMUTACION");
                    }
                    else
                    {
                        poblaciontrabajo[j] = poblaciontrabajo[j];
                    }
                }
                mutacionResultado.Add(poblaciontrabajo);
            }
            return mutacionResultado;
        }

        public static List<double> medir_convergencia2(List<List<double>> poblacion)
        {
            int[] valida_pos = new int[poblacion.Count];
            List<double> resultadosFinales = new List<double>();

            for (int i = 0; i < poblacion.Count; i++)
            {
                if (valida_pos[i] == 0)
                {
                    valida_pos[i] = 1;
                    int contador = 1;
                    List<double> v1 = poblacion[i];
                    for (int j = 0; j < poblacion.Count; j++)
                    {
                        if (valida_pos[j] == 0)
                        {
                            List<double> v2 = poblacion[j];
                            if (v1.SequenceEqual(v2))
                            {
                                contador++;
                                valida_pos[j] = 1;
                            }
                        }
                    }
                    resultadosFinales.Add(contador);
                }
            }
            return resultadosFinales;
        }

        /*Optimiazacion de  FLUJOS NETOS DE EFECTIVO*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Resultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void vsstex_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultados_TextChanged(object sender, EventArgs e)
        {
            Resultados.SelectionStart = Resultados.Text.Length;
            Resultados.ScrollToCaret();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
