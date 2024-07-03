using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;


namespace Neural_Activity_Monitoring_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select the .dat file"; // Title
            open.DefaultExt = "dat"; // Extension?
            open.InitialDirectory = Environment.CurrentDirectory;
            open.ShowDialog(); // run it

            if (open.FileName.Length > 3)
            {
                tabControl1.SelectedIndex = 1;

                StreamReader readFile;

                progressBar.Maximum = 14;
                progressBar.Visible = true;
                btnPlay.Enabled = true;

                hilbertWinSize = Convert.ToInt32(txtHilbertSize.Text.ToString());
                precision = 1 / Math.Pow(10, Convert.ToInt32(txtPrecision.Text.ToString()));

                FileStream dosya = new FileStream(open.FileName, FileMode.Open); // Check the path
                dosya.Close(); // close
                readFile = new StreamReader(open.FileName);

                //loadToolStripMenuItem.Enabled = false;

                graph(readFile);

                //progressBar.Visible = false;
                pnlGraphs.Visible = true;
                btn_excel.Visible = true;
            }

            (this.tabPage3).Enabled = false;
        }


        public void click(Object sender, EventArgs e)
        {
            Button getButton = (Button)sender;
            int p = 0;
            for (; p < 14; p++)
            {
                if (getButton.Text == points[p].name)
                {
                    break;
                }
            }

            foreach (Chart crt in pnlGraphs.Controls)
            {
                if (crt.Text == "chart" + (p + 1).ToString())
                {
                    Chart chartMainTemp = new Chart();
                    MemoryStream myStream = new MemoryStream();
                    crt.Serializer.Save(myStream);
                    chartMainTemp.Serializer.Load(myStream);
                    chartMainTemp.Size = new System.Drawing.Size(780, 270);
                    chartMainTemp.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
                    chartMainTemp.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
                    Form Form2 = new Form();
                    Form2.Size = new Size(800, 300);
                    Form2.MaximumSize = new Size(800, 300);
                    Form2.Text = points[p].name;
                    Form2.Controls.Add(chartMainTemp);
                    Form2.Show();
                }
            }
        }

        public void ClearArea()
        {
            for (int i = 0; i < 14; i++)
            {
                circleButton[i].BackColor = Color.Black;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int speed = hScrollBarSpeed.Value;
            speed = timeInt[speed];
            timer.Interval = speed;
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            listViewRecord.Visible = true;
            //aSSOBToolStripMenuItem.Enabled = true;
            //riemanToolStripMenuItem.Enabled = false;
            //borsukUlamToolStripMenuItem.Enabled = false;
            //amplitudeToolStripMenuItem.Enabled = false;
            radioActivity.Enabled = false;
            radioAntipodal.Enabled = false;

            timer.Start();
        }

        private void hScrollBarSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            int speed = hScrollBarSpeed.Value;
            speed = timeInt[speed];
            timer.Interval = speed;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            countergraph = 1;
            timer.Stop();

            foreach (Chart crt in pnlGraphs.Controls)
            {
                foreach (ChartArea cra in crt.ChartAreas)
                {
                    cra.AxisX.ScaleView.Zoom(0, 128);

                }
            }

            listViewRecord.Items.Clear();
            listViewCounter = 0;

            prevStep = new int[30];
            prevValue = new double[30];

            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            timer.Stop();
        }

        //Complex for decimal numbers for better precision
        public struct Complex1
        {
            public decimal real;
            public decimal imag;
        }

        public static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
        {
            if (x < 0)
                return 0;

            //throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
        }

        Points[] points = new Points[14];
        public double[] avarg = new double[14];
        public double[] min = new double[14];
        public double[] max = new double[14];
        public int[] timeInt = new int[5];  //Time interval for speed of signal
        ShapeButton[] circleButton = new ShapeButton[14];
        public Color[] amplitudes = new Color[7];
        ShapeButton[] represesntColor = new ShapeButton[6];
        public int countergraph = 1; //counter for controlling the signal
        public int listViewCounter = 0; //counter for adding listView
        public int[] prevStep = new int[14];
        public double[] prevValue = new double[14];
        public double[] dizi2;
        public decimal[,] threeD;
        public decimal[,] threeDRho;
        int countSignal = 0;
        public decimal[,] energy;
        int knt = 0;
        public int[,] PNTReslts;
        public int[,] RNTReslts;
        int countFor3D = -1;
        public int[,] PNTpairEntropy = new int[14, 14];
        public int[,] RNTpairEntropy = new int[14, 14];
        public int[] PNTEntropy = new int[14];
        public Complex1[,] AllNormalizasyon;
        public int[] RNTEntropy = new int[14];
        static int hilbertWinSize;
        static double precision = 0.00001;
        int dongusayisi;
        int controlArraysize = 0;
        public void putAllButtons()
        {
            float currentSize = 6.5F;

            Points point = new Points();

            points = point.putAllPoints();

            for (int i = 0; i < 14; i++)
            {
                circleButton[i] = new ShapeButton();
                circleButton[i].Size = new Size(33, 33);
                circleButton[i].Location = new System.Drawing.Point(points[i].x, points[i].y);
                circleButton[i].BackColor = Color.Black;
                circleButton[i].FlatAppearance.BorderSize = 0;
                circleButton[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                circleButton[i].FlatAppearance.BorderColor = Color.Blue;
                circleButton[i].TabStop = false;
                circleButton[i].Text = points[i].name;
                circleButton[i].ForeColor = Color.White;
                circleButton[i].FlatAppearance.MouseOverBackColor = Color.Black;
                circleButton[i].Font = new Font(circleButton[i].Font.Name, currentSize,
                circleButton[i].Font.Style, circleButton[i].Font.Unit);
                circleButton[i].Click += new EventHandler(this.click);
                pnlBrainImg.Controls.Add(circleButton[i]);

            }
        }

        private void graph(StreamReader read)
        {
            int blockSize = 128;
            int y = 0;

            string data;
            string[] arr1;

            Colors color = new Colors();

            Color[] colors = new Color[14];
            colors = color.putAllColors();

            double[] arr2;

            for (int i = 1; i < 15; i++)
            {
                Chart chartMain = new Chart();

                ChartArea chartArea = new ChartArea();
                Legend legend = new Legend();
                Series series = new Series();

                chartArea.Name = "ChartArea" + i.ToString();
                chartMain.ChartAreas.Add(chartArea);

                chartArea.AxisY.Enabled = AxisEnabled.False;
                chartArea.AxisX.Enabled = AxisEnabled.False;

                legend.Name = "Legend" + i.ToString();
                chartMain.Legends.Add(legend);

                chartMain.Location = new System.Drawing.Point(0, y);
                chartMain.Name = "chartMain" + i.ToString();
                series.ChartArea = "ChartArea" + i.ToString();
                series.Legend = "Legend" + i.ToString();
                series.Name = points[i - 1].name;
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.Int32;
                series.Color = colors[i - 1];
                chartMain.Series.Add(series);
                chartMain.Size = new System.Drawing.Size(795, 50);
                chartMain.TabIndex = i;
                chartMain.Text = "chart" + i.ToString();

                data = read.ReadLine();
                arr1 = data.Split(null);

                //threeD = new double[30, arr1.Length];
                arr2 = new double[arr1.Length];

                for (int n = 0; n < arr1.Length - 1; n++)
                {
                    arr2[n] = double.Parse(arr1[n], System.Globalization.CultureInfo.InvariantCulture);
                }

                for (int a = 0; a < arr1.Length - 1; a++)
                    series.Points.AddXY(a, arr1[a]);
                var ChartArea = chartMain.ChartAreas[series.ChartArea];

                // set view range to [0,max]
                chartArea.AxisX.Minimum = 0;
                chartArea.AxisX.Maximum = arr1.Length;

                // enable autoscroll
                chartArea.CursorX.AutoScroll = true;

                // let's zoom to [0,blockSize] (e.g. [0,100])
                chartArea.AxisX.ScaleView.Zoomable = true;
                chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                int position = 0;
                int size = blockSize;
                chartArea.AxisX.ScaleView.Zoom(position, size);

                // disable zoom-reset button (only scrollbar's arrows are available)
                //chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

                // set scrollbar small change to blockSize (e.g. 100)
                chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;

                y = y + 45;

                pnlGraphs.Controls.Add(chartMain);

                max[i - 1] = arr2.Max();
                min[i - 1] = arr2.Min();
                avarg[i - 1] = (max[i - 1] - min[i - 1]) / 6;

                data = null;
                arr1 = null;

                GetTreeD(arr2);

                progressBar.Value++;

            }

            FindResults();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string curDir = Directory.GetCurrentDirectory();

            // Navigate up two levels from curDir
            string parentDir = Path.GetFullPath(Path.Combine(curDir, @"..\..\"));

            // Ensure the directory separators are correct for the URI
            string formattedParentDir = parentDir.Replace("\\", "/");

            // Set the URI for the networkBrowser
            this.networkBrowser.Url = new Uri($"file:///{formattedParentDir}Lib/network.html");

            //networkBrowser.Navigate(@"C:\Users\beyaz_000\Desktop\Cognitive Signal Processing\Cognitive Signal Processing\network.html");

            putAllButtons();

            timeInt[0] = 1000; timeInt[1] = 800; timeInt[2] = 600; timeInt[3] = 400; timeInt[4] = 200;

            Colors amplitude = new Colors();
            amplitudes = amplitude.putAllAmplitudes();

            int p = 130;

            for (int w = 0; w < 6; w++)
            {
                represesntColor[w] = new ShapeButton();
                represesntColor[w].Size = new Size(15, 15);
                represesntColor[w].Location = new System.Drawing.Point(10, p);
                represesntColor[w].BackColor = amplitudes[w];
                represesntColor[w].FlatAppearance.BorderSize = 0;
                represesntColor[w].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                represesntColor[w].FlatAppearance.BorderColor = Color.Blue;
                represesntColor[w].TabStop = false;
                //circleButton[i].Click += new EventHandler(this.click);
                pnlIntensity.Controls.Add(represesntColor[w]);

                p = p - 22;
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //DateTime date = new DateTime();
            //double b;
            //b = DateTime.Now.Millisecond;

            countFor3D++;

            if (checkBoxAmplitude.Checked == true && radioButtonRNT.Checked == false &&
             radioButtonPNT.Checked == false)
            {
                SetAmplitude();
            }
            else if (radioButtonPNT.Checked == true)
            {

                if (checkBoxAmplitude.Checked == true)
                {
                    SetAmplitude();
                    SetThreeD();
                }
                else
                {
                    foreach (Chart crt in pnlGraphs.Controls)
                    {
                        foreach (ChartArea cra in crt.ChartAreas)
                        {
                            cra.AxisX.ScaleView.Zoom(0 + countergraph, 128 + countergraph);
                        }
                    }
                    ClearArea();
                    SetThreeD();
                    countergraph = countergraph + 1;
                }
            }
            else if (radioButtonRNT.Checked == true)
            {

                if (checkBoxAmplitude.Checked == true)
                {
                    SetAmplitude();
                    SetThreeDRho();
                }
                else
                {
                    foreach (Chart crt in pnlGraphs.Controls)
                    {
                        foreach (ChartArea cra in crt.ChartAreas)
                        {
                            cra.AxisX.ScaleView.Zoom(0 + countergraph, 100 + countergraph);
                        }
                    }
                    ClearArea();
                    SetThreeDRho();
                    countergraph = countergraph + 1;
                }
            }
        }


        public void GetTreeD(double[] arrayPart)
        {
            if (controlArraysize == 0)
            {
                dongusayisi = arrayPart.Length / hilbertWinSize;
                threeD = new decimal[14, arrayPart.Length];
                threeDRho = new decimal[14, arrayPart.Length];
                energy = new decimal[14, arrayPart.Length];
                controlArraysize = 100;
                PNTReslts = new int[14, dongusayisi * hilbertWinSize];
                RNTReslts = new int[14, dongusayisi * hilbertWinSize];
                AllNormalizasyon = new Complex1[14, dongusayisi * hilbertWinSize];
            }
            for (int dongu = 0; dongusayisi > dongu; dongu++)
            {
                Complex[] samples = new Complex[hilbertWinSize];
                Complex[] samples1 = new Complex[hilbertWinSize];
                Complex[] samplesH = new Complex[hilbertWinSize];
                Complex[] samples2 = new Complex[hilbertWinSize];
                Complex[] samples3 = new Complex[hilbertWinSize];
                Complex1[] samples4 = new Complex1[hilbertWinSize];
                Complex1[] samples5 = new Complex1[hilbertWinSize];


                decimal maximum = 0;

                for (int i = 0; i < hilbertWinSize; i++)
                {
                    samples1[i] = Complex.WithRealImaginary(arrayPart[i + (dongu * hilbertWinSize)], 0);
                }

                for (int i = 0; i < hilbertWinSize; i++)
                {
                    samples[i] = samples1[i];
                }

                Transform.FourierForward(samples1, FourierOptions.Matlab);

                int signalVal = samples1.Count();

                for (int i = 0; i < hilbertWinSize; i++)
                {
                    samplesH[i] = getH(signalVal, i);
                    samples2[i] = samples1[i] * samplesH[i];
                }

                Transform.FourierInverse(samples2, FourierOptions.Matlab);

                for (int com = 0; com < hilbertWinSize; com++)
                {
                    samples3[com] = Complex.WithRealImaginary(samples[com].Real, samples2[com].Real);
                }

                decimal temp;

                for (int com = 0; com < hilbertWinSize; com++)
                {
                    samples4[com].real = Convert.ToDecimal(samples3[com].Real);
                    samples4[com].imag = Convert.ToDecimal(samples3[com].Imaginary);
                    AllNormalizasyon[countSignal, com + (dongu * hilbertWinSize)] = samples4[com];
                    temp = Sqrt((samples4[com].real * samples4[com].real) + (samples4[com].imag * samples4[com].imag));

                    if (temp > maximum)
                    {
                        maximum = temp;
                    }
                }

                if (radioWNorm.Checked == true)
                {

                    //Normalization
                    for (int com = 0; com < hilbertWinSize; com++)
                    {
                        //samples3[com] = ((Complex.WithRealImaginary(0, 1) - samples3[com]) / (Complex.WithRealImaginary(0, 1) + samples3[com]));
                        samples5[com].real = samples4[com].real / maximum;
                        samples5[com].imag = samples4[com].imag / maximum;
                    }

                    for (int com = 0; com < hilbertWinSize; com++)
                    {
                        decimal norm = (Sqrt((samples5[com].real * samples5[com].real) + (samples5[com].imag * samples5[com].imag)));
                        //Normalizasyon olmasın diye
                        decimal norm2 = (Sqrt((samples4[com].real * samples4[com].real) + (samples4[com].imag * samples4[com].imag)));
                        threeDRho[countSignal, com + (dongu * hilbertWinSize)] = (1 / Sqrt(((norm2 * norm2) + 1)));
                        threeD[countSignal, com + (dongu * hilbertWinSize)] = Sqrt(1 - (samples5[com].real * samples5[com].real) - (samples5[com].imag * samples5[com].imag));
                    }
                }

                allNetwork.Visible = true;
            }

            if (radioANorm.Checked == true)
            {
                decimal check = 0;
                decimal maxmax = 0;

                for (int i = 0; i < dongusayisi * hilbertWinSize; i++)
                {
                    check = Sqrt((AllNormalizasyon[countSignal, i].real * AllNormalizasyon[countSignal, i].real) + (AllNormalizasyon[countSignal, i].imag * AllNormalizasyon[countSignal, i].imag));

                    if (check > maxmax)
                    {
                        maxmax = check;
                    }
                }

                for (int i = 0; i < dongusayisi * hilbertWinSize; i++)
                {
                    AllNormalizasyon[countSignal, i].real = AllNormalizasyon[countSignal, i].real / maxmax;
                    AllNormalizasyon[countSignal, i].imag = AllNormalizasyon[countSignal, i].imag / maxmax;
                }

                for (int i = 0; i < dongusayisi * hilbertWinSize; i++)
                {
                    decimal norm1 = (Sqrt((AllNormalizasyon[countSignal, i].real * AllNormalizasyon[countSignal, i].real) + (AllNormalizasyon[countSignal, i].imag * AllNormalizasyon[countSignal, i].imag)));
                    threeDRho[countSignal, i] = (1 / Sqrt(((norm1 * norm1) + 1)));
                    energy[countSignal, i] = Convert.ToDecimal(-Math.Log(Convert.ToDouble(threeDRho[countSignal, i])));
                    threeD[countSignal, i] = Sqrt(1 - (AllNormalizasyon[countSignal, i].real * AllNormalizasyon[countSignal, i].real) - (AllNormalizasyon[countSignal, i].imag * AllNormalizasyon[countSignal, i].imag));
                }
            }

            countSignal++;
        }


        public static Complex getH(int count, int index)
        {
            Complex samplesH = new Complex();

            if (index == 0 || index == count / 2)
            {
                samplesH = Complex.WithRealImaginary(0, 0);
            }
            else if (index > 0 && index < count / 2)
            {
                samplesH = Complex.WithRealImaginary(0, -1);
            }
            else if (index > count / 2)
            {
                samplesH = Complex.WithRealImaginary(0, 1);
            }

            return samplesH;
        }

        public void SetAmplitude()
        {
            double valueY = 0;
            int step;
            int chrt = 0;

            foreach (Chart crt in pnlGraphs.Controls)
            {
                foreach (ChartArea cra in crt.ChartAreas)
                {
                    cra.AxisX.ScaleView.Zoom(0 + countergraph, 100 + countergraph);
                    valueY = crt.Series[0].Points[countergraph + 99].YValues[0];

                    if (valueY < 0)
                    {

                        step = Convert.ToInt32((min[chrt] - valueY) / -avarg[chrt]);
                        circleButton[chrt].BackColor = amplitudes[step];

                        if (prevStep[chrt] != step && radioActivity.Checked == true)
                        {
                            string first = Convert.ToString(prevValue[chrt]);
                            string second = Convert.ToString(valueY);

                            string name = points[chrt].name;
                            string timeDomain = Convert.ToString(countergraph + 99);

                            listViewRecord.Items.Add(name);
                            listViewRecord.Items[listViewCounter].UseItemStyleForSubItems = false;
                            listViewRecord.Items[listViewCounter].SubItems.Add(timeDomain);
                            listViewRecord.Items[listViewCounter].SubItems.Add(first);
                            listViewRecord.Items[listViewCounter].SubItems[2].ForeColor = amplitudes[prevStep[chrt]];
                            listViewRecord.Items[listViewCounter].SubItems.Add(second);
                            listViewRecord.Items[listViewCounter].SubItems[3].ForeColor = amplitudes[step];

                            listViewCounter++;
                        }
                    }
                    else
                    {
                        step = Convert.ToInt32((valueY - min[chrt]) / avarg[chrt]);
                        circleButton[chrt].BackColor = amplitudes[step];

                        if (prevStep[chrt] != step && radioActivity.Checked == true)
                        {
                            string first = Convert.ToString(prevValue[chrt]);
                            string second = Convert.ToString(valueY);

                            string name = points[chrt].name;
                            string timeDomain = Convert.ToString(countergraph + 99);

                            listViewRecord.Items.Add(name);
                            listViewRecord.Items[listViewCounter].UseItemStyleForSubItems = false;
                            listViewRecord.Items[listViewCounter].SubItems.Add(timeDomain);
                            listViewRecord.Items[listViewCounter].SubItems.Add(first);
                            listViewRecord.Items[listViewCounter].SubItems[2].ForeColor = amplitudes[prevStep[chrt]];
                            listViewRecord.Items[listViewCounter].SubItems.Add(second);
                            listViewRecord.Items[listViewCounter].SubItems[3].ForeColor = amplitudes[step];

                            listViewCounter++;

                        }
                    }

                    prevStep[chrt] = step;
                    prevValue[chrt] = valueY;

                    chrt = chrt + 1;
                }
            }

            countergraph = countergraph + 1;
            chrt = 0;


        }


        public void SetThreeD()
        {
            for (int i = 0; i < 14; i++)
            {
                if (PNTReslts[i, countFor3D] == 1)
                {
                    circleButton[i].BackColor = Color.Green;

                    if (radioAntipodal.Checked == true)
                    {

                        string name = circleButton[i].Text;

                        string value = Convert.ToString(threeD[i, countFor3D]);
                        string timeDomain = Convert.ToString(countergraph + 99);

                        listViewRecord2.Items.Add(name);
                        listViewRecord2.Items[listViewCounter].UseItemStyleForSubItems = false;
                        listViewRecord2.Items[listViewCounter].SubItems.Add(value);
                        listViewRecord2.Items[listViewCounter].SubItems.Add(timeDomain);

                        listViewCounter++;
                    }
                }
            }
        }

        public void SetThreeDRho()
        {
            for (int i = 0; i < 14; i++)
            {
                if (RNTReslts[i, countFor3D] == 1)
                {
                    circleButton[i].BackColor = Color.Green;

                    if (radioAntipodal.Checked == true)
                    {
                        string name = circleButton[i].Text;

                        string value = Convert.ToString(threeDRho[i, countFor3D]);
                        string timeDomain = Convert.ToString(countergraph + 99);

                        listViewRecord3.Items.Add(name);
                        listViewRecord3.Items[listViewCounter].UseItemStyleForSubItems = false;
                        listViewRecord3.Items[listViewCounter].SubItems.Add(value);
                        listViewRecord3.Items[listViewCounter].SubItems.Add(timeDomain);

                        listViewCounter++;
                    }
                }
            }
        }

        public void FindResults()
        {

            while (knt < dongusayisi * hilbertWinSize)
            {
                int hnt = 0;
                int tnt = 1;

                while (hnt < 13)
                {

                    for (int unt = 0; unt < 13; unt++)
                    {


                        if (tnt + unt >= 14)
                        {
                            break;
                        }
                        else
                        {

                            if (Math.Abs(threeD[hnt, knt] - threeD[tnt + unt, knt]) <= Convert.ToDecimal(precision))
                            {

                                PNTReslts[hnt, knt] = 1;
                                PNTReslts[tnt + unt, knt] = 1;
                                PNTEntropy[hnt]++;
                                PNTEntropy[tnt + unt]++;
                                PNTpairEntropy[hnt, tnt + unt]++;
                                PNTpairEntropy[tnt + unt, hnt]++;

                            }

                            if (Math.Abs(threeDRho[hnt, knt] - threeDRho[tnt + unt, knt]) <= Convert.ToDecimal(precision))
                            {
                                decimal ilk = threeDRho[hnt, knt];
                                decimal digeri = threeD[hnt, knt];

                                RNTReslts[hnt, knt] = 1;
                                RNTReslts[tnt + unt, knt] = 1;
                                RNTEntropy[hnt]++;
                                RNTEntropy[tnt + unt]++;
                                RNTpairEntropy[hnt, tnt + unt]++;
                                RNTpairEntropy[tnt + unt, hnt]++;

                            }

                        }
                    }

                    //pro++;
                    hnt++;
                    tnt++;
                }
                knt++;
            }

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            
        }

        private void radioAntipodal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPNT.Checked == true)
            {
                listViewRecord.Visible = false;
                listViewRecord2.Visible = true;
                listViewRecord3.Visible = false;
            }
            else if (radioButtonRNT.Checked == true)
            {
                listViewRecord.Visible = false;
                listViewRecord2.Visible = false;
                listViewRecord3.Visible = true;
            }
            else
            {

                if (radioAntipodal.Checked == true)
                {
                    MessageBox.Show("You must select at least one method to open Analysis panel",
            "Important Message");
                    radioActivity.Checked = true;
                }

            }
        }

        private void radioActivity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAmplitude.Checked == false)
            {
                if (radioActivity.Checked == true)
                {
                    MessageBox.Show("You can not select to open Analysis panel, until selecting the Amplitude tab",
                "Important Message");
                    radioActivity.Checked = false;
                    radioAntipodal.Checked = true;
                }
            }
            else
            {

                listViewRecord.Visible = true;
                listViewRecord2.Visible = false;
                listViewRecord3.Visible = false;
            }
        }

        private void allNetwork_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {

                for (int j = i + 1; j < 14; j++)
                {
                    if (PNTpairEntropy[i, j] > 0)
                    {
                        int a = PNTpairEntropy[i, j] * 2;
                        networkBrowser.Document.InvokeScript("addNew", new string[] { circleButton[i].Text + "," + circleButton[j].Text + "," + Convert.ToString(a) });

                    }

                }

            }
        }

        public static bool formFlag = true;

        private void btnNeural_Click(object sender, EventArgs e)
        {
            if (formFlag == true)
            {
                Stimuli form = new Stimuli();
                form.TopLevel = false;
                Controls.Add(form);
                form.BringToFront();
                form.Show();
                formFlag = false;
                //stimuliToolStripMenuItem.Enabled = false;
            }
        }
    }
}
