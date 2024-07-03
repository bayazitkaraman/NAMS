namespace Neural_Activity_Monitoring_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlListView = new System.Windows.Forms.GroupBox();
            this.listViewRecord = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioActivity = new System.Windows.Forms.RadioButton();
            this.radioAntipodal = new System.Windows.Forms.RadioButton();
            this.listViewRecord2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRecord3 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlNetwork = new System.Windows.Forms.GroupBox();
            this.networkBrowser = new System.Windows.Forms.WebBrowser();
            this.allNetwork = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlBrainImg = new System.Windows.Forms.GroupBox();
            this.pnlControl = new System.Windows.Forms.GroupBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.hScrollBarSpeed = new System.Windows.Forms.HScrollBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.pnlIntensity = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSignal = new System.Windows.Forms.GroupBox();
            this.pnlGraphs = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSelAnal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHilbertSize = new System.Windows.Forms.TextBox();
            this.txtPrecision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioWNorm = new System.Windows.Forms.RadioButton();
            this.radioANorm = new System.Windows.Forms.RadioButton();
            this.AnalysisOption = new System.Windows.Forms.GroupBox();
            this.radioButtonRNT = new System.Windows.Forms.RadioButton();
            this.radioButtonPNT = new System.Windows.Forms.RadioButton();
            this.checkBoxAmplitude = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnNeural = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.pnlListView.SuspendLayout();
            this.pnlNetwork.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlIntensity.SuspendLayout();
            this.pnlSignal.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSelAnal.SuspendLayout();
            this.AnalysisOption.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.pnlNetwork);
            this.tabPage2.Controls.Add(this.pnlListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analysis";
            // 
            // pnlListView
            // 
            this.pnlListView.Controls.Add(this.listViewRecord3);
            this.pnlListView.Controls.Add(this.listViewRecord2);
            this.pnlListView.Controls.Add(this.radioAntipodal);
            this.pnlListView.Controls.Add(this.radioActivity);
            this.pnlListView.Controls.Add(this.listViewRecord);
            this.pnlListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlListView.Location = new System.Drawing.Point(40, 6);
            this.pnlListView.Name = "pnlListView";
            this.pnlListView.Size = new System.Drawing.Size(384, 180);
            this.pnlListView.TabIndex = 32;
            this.pnlListView.TabStop = false;
            this.pnlListView.Text = "Neural Behavior Analysis Panel";
            // 
            // listViewRecord
            // 
            this.listViewRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRecord.HideSelection = false;
            this.listViewRecord.Location = new System.Drawing.Point(8, 15);
            this.listViewRecord.Name = "listViewRecord";
            this.listViewRecord.Size = new System.Drawing.Size(369, 134);
            this.listViewRecord.TabIndex = 0;
            this.listViewRecord.UseCompatibleStateImageBehavior = false;
            this.listViewRecord.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sensor Name";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time Domain";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Previous Value";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 51;
            // 
            // radioActivity
            // 
            this.radioActivity.AutoSize = true;
            this.radioActivity.Checked = true;
            this.radioActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioActivity.Location = new System.Drawing.Point(12, 156);
            this.radioActivity.Name = "radioActivity";
            this.radioActivity.Size = new System.Drawing.Size(176, 17);
            this.radioActivity.TabIndex = 1;
            this.radioActivity.TabStop = true;
            this.radioActivity.Text = "Display Activities Behavior";
            this.radioActivity.UseVisualStyleBackColor = true;
            this.radioActivity.CheckedChanged += new System.EventHandler(this.radioActivity_CheckedChanged);
            // 
            // radioAntipodal
            // 
            this.radioAntipodal.AutoSize = true;
            this.radioAntipodal.Location = new System.Drawing.Point(205, 156);
            this.radioAntipodal.Name = "radioAntipodal";
            this.radioAntipodal.Size = new System.Drawing.Size(177, 17);
            this.radioAntipodal.TabIndex = 2;
            this.radioAntipodal.Text = "Display Antipodal Behavior";
            this.radioAntipodal.UseVisualStyleBackColor = true;
            this.radioAntipodal.CheckedChanged += new System.EventHandler(this.radioAntipodal_CheckedChanged);
            // 
            // listViewRecord2
            // 
            this.listViewRecord2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6});
            this.listViewRecord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRecord2.HideSelection = false;
            this.listViewRecord2.Location = new System.Drawing.Point(8, 15);
            this.listViewRecord2.Name = "listViewRecord2";
            this.listViewRecord2.Size = new System.Drawing.Size(369, 134);
            this.listViewRecord2.TabIndex = 3;
            this.listViewRecord2.UseCompatibleStateImageBehavior = false;
            this.listViewRecord2.View = System.Windows.Forms.View.Details;
            this.listViewRecord2.Visible = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sensor";
            this.columnHeader5.Width = 57;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "3D Value";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time Domain";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 75;
            // 
            // listViewRecord3
            // 
            this.listViewRecord3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader14});
            this.listViewRecord3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRecord3.HideSelection = false;
            this.listViewRecord3.Location = new System.Drawing.Point(8, 15);
            this.listViewRecord3.Name = "listViewRecord3";
            this.listViewRecord3.Size = new System.Drawing.Size(369, 134);
            this.listViewRecord3.TabIndex = 13;
            this.listViewRecord3.UseCompatibleStateImageBehavior = false;
            this.listViewRecord3.View = System.Windows.Forms.View.Details;
            this.listViewRecord3.Visible = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Sensor ";
            this.columnHeader10.Width = 72;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Chordal Distance";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 194;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Time Domain";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 95;
            // 
            // pnlNetwork
            // 
            this.pnlNetwork.Controls.Add(this.allNetwork);
            this.pnlNetwork.Controls.Add(this.networkBrowser);
            this.pnlNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNetwork.Location = new System.Drawing.Point(558, 6);
            this.pnlNetwork.Name = "pnlNetwork";
            this.pnlNetwork.Size = new System.Drawing.Size(688, 662);
            this.pnlNetwork.TabIndex = 34;
            this.pnlNetwork.TabStop = false;
            this.pnlNetwork.Text = "Network Analysis Panel";
            // 
            // networkBrowser
            // 
            this.networkBrowser.Location = new System.Drawing.Point(6, 19);
            this.networkBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.networkBrowser.Name = "networkBrowser";
            this.networkBrowser.Size = new System.Drawing.Size(671, 637);
            this.networkBrowser.TabIndex = 27;
            // 
            // allNetwork
            // 
            this.allNetwork.Location = new System.Drawing.Point(501, 38);
            this.allNetwork.Name = "allNetwork";
            this.allNetwork.Size = new System.Drawing.Size(149, 23);
            this.allNetwork.TabIndex = 28;
            this.allNetwork.Text = "All Network Analysis";
            this.allNetwork.UseVisualStyleBackColor = true;
            this.allNetwork.Visible = false;
            this.allNetwork.Click += new System.EventHandler(this.allNetwork_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.pnlSignal);
            this.tabPage1.Controls.Add(this.pnlIntensity);
            this.tabPage1.Controls.Add(this.btn_excel);
            this.tabPage1.Controls.Add(this.pnlControl);
            this.tabPage1.Controls.Add(this.pnlBrainImg);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor & Control";
            // 
            // pnlBrainImg
            // 
            this.pnlBrainImg.BackgroundImage = global::Neural_Activity_Monitoring_System.Properties.Resources.Human_brain;
            this.pnlBrainImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBrainImg.Location = new System.Drawing.Point(6, 6);
            this.pnlBrainImg.Name = "pnlBrainImg";
            this.pnlBrainImg.Size = new System.Drawing.Size(430, 510);
            this.pnlBrainImg.TabIndex = 27;
            this.pnlBrainImg.TabStop = false;
            this.pnlBrainImg.Text = "Sensor Panel";
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnStop);
            this.pnlControl.Controls.Add(this.btnPause);
            this.pnlControl.Controls.Add(this.hScrollBarSpeed);
            this.pnlControl.Controls.Add(this.lblSpeed);
            this.pnlControl.Controls.Add(this.lbl1);
            this.pnlControl.Controls.Add(this.btnPlay);
            this.pnlControl.Controls.Add(this.lbl4);
            this.pnlControl.Controls.Add(this.lbl3);
            this.pnlControl.Controls.Add(this.lbl2);
            this.pnlControl.Controls.Add(this.lbl5);
            this.pnlControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlControl.Location = new System.Drawing.Point(6, 522);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(312, 111);
            this.pnlControl.TabIndex = 28;
            this.pnlControl.TabStop = false;
            this.pnlControl.Text = "Control Panel";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(260, 73);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(14, 13);
            this.lbl5.TabIndex = 45;
            this.lbl5.Text = "5";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(149, 73);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(14, 13);
            this.lbl2.TabIndex = 42;
            this.lbl2.Text = "2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(185, 73);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(14, 13);
            this.lbl3.TabIndex = 43;
            this.lbl3.Text = "3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(222, 73);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(14, 13);
            this.lbl4.TabIndex = 44;
            this.lbl4.Text = "4";
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Neural_Activity_Monitoring_System.Properties.Resources.play;
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(6, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 48);
            this.btnPlay.TabIndex = 46;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(111, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(14, 13);
            this.lbl1.TabIndex = 41;
            this.lbl1.Text = "1";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSpeed.Location = new System.Drawing.Point(3, 78);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(75, 25);
            this.lblSpeed.TabIndex = 39;
            this.lblSpeed.Text = "Speed";
            // 
            // hScrollBarSpeed
            // 
            this.hScrollBarSpeed.LargeChange = 1;
            this.hScrollBarSpeed.Location = new System.Drawing.Point(84, 86);
            this.hScrollBarSpeed.Maximum = 4;
            this.hScrollBarSpeed.Name = "hScrollBarSpeed";
            this.hScrollBarSpeed.Size = new System.Drawing.Size(215, 17);
            this.hScrollBarSpeed.TabIndex = 40;
            this.hScrollBarSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarSpeed_Scroll);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::Neural_Activity_Monitoring_System.Properties.Resources.pause;
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(97, 20);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(48, 48);
            this.btnPause.TabIndex = 47;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::Neural_Activity_Monitoring_System.Properties.Resources.stop;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(188, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 48);
            this.btnStop.TabIndex = 48;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Location = new System.Drawing.Point(90, 639);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(142, 33);
            this.btn_excel.TabIndex = 30;
            this.btn_excel.Text = "Write All Results to Excel";
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Visible = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // pnlIntensity
            // 
            this.pnlIntensity.Controls.Add(this.label7);
            this.pnlIntensity.Controls.Add(this.label8);
            this.pnlIntensity.Controls.Add(this.label9);
            this.pnlIntensity.Controls.Add(this.label10);
            this.pnlIntensity.Controls.Add(this.label11);
            this.pnlIntensity.Controls.Add(this.label12);
            this.pnlIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlIntensity.Location = new System.Drawing.Point(324, 522);
            this.pnlIntensity.Name = "pnlIntensity";
            this.pnlIntensity.Size = new System.Drawing.Size(112, 152);
            this.pnlIntensity.TabIndex = 31;
            this.pnlIntensity.TabStop = false;
            this.pnlIntensity.Text = "Intensity Ledger";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "High";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Moderate Low";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Low";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Very High";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Moderate High";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Very Low";
            // 
            // pnlSignal
            // 
            this.pnlSignal.Controls.Add(this.pnlGraphs);
            this.pnlSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSignal.Location = new System.Drawing.Point(442, 6);
            this.pnlSignal.Name = "pnlSignal";
            this.pnlSignal.Size = new System.Drawing.Size(809, 668);
            this.pnlSignal.TabIndex = 32;
            this.pnlSignal.TabStop = false;
            this.pnlSignal.Text = "Signal Panel";
            // 
            // pnlGraphs
            // 
            this.pnlGraphs.AutoScroll = true;
            this.pnlGraphs.Location = new System.Drawing.Point(6, 19);
            this.pnlGraphs.Name = "pnlGraphs";
            this.pnlGraphs.Size = new System.Drawing.Size(798, 643);
            this.pnlGraphs.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnNeural);
            this.tabPage3.Controls.Add(this.progressBar);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnLoad);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1256, 682);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Load EEG Data";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(186, 496);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 30);
            this.btnLoad.TabIndex = 39;
            this.btnLoad.Text = "Load EEG Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnalysisOption);
            this.groupBox1.Controls.Add(this.pnlSelAnal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 232);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis Selection";
            // 
            // pnlSelAnal
            // 
            this.pnlSelAnal.Controls.Add(this.radioANorm);
            this.pnlSelAnal.Controls.Add(this.radioWNorm);
            this.pnlSelAnal.Controls.Add(this.label1);
            this.pnlSelAnal.Controls.Add(this.txtPrecision);
            this.pnlSelAnal.Controls.Add(this.txtHilbertSize);
            this.pnlSelAnal.Controls.Add(this.label2);
            this.pnlSelAnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSelAnal.Location = new System.Drawing.Point(15, 135);
            this.pnlSelAnal.Name = "pnlSelAnal";
            this.pnlSelAnal.Size = new System.Drawing.Size(430, 87);
            this.pnlSelAnal.TabIndex = 37;
            this.pnlSelAnal.TabStop = false;
            this.pnlSelAnal.Text = "Analysis Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precision (default 5):";
            // 
            // txtHilbertSize
            // 
            this.txtHilbertSize.Location = new System.Drawing.Point(141, 24);
            this.txtHilbertSize.Name = "txtHilbertSize";
            this.txtHilbertSize.Size = new System.Drawing.Size(49, 20);
            this.txtHilbertSize.TabIndex = 14;
            this.txtHilbertSize.Text = "1024";
            // 
            // txtPrecision
            // 
            this.txtPrecision.Location = new System.Drawing.Point(365, 24);
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.Size = new System.Drawing.Size(49, 20);
            this.txtPrecision.TabIndex = 16;
            this.txtPrecision.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hilbert Window Size :";
            // 
            // radioWNorm
            // 
            this.radioWNorm.AutoSize = true;
            this.radioWNorm.Location = new System.Drawing.Point(37, 59);
            this.radioWNorm.Name = "radioWNorm";
            this.radioWNorm.Size = new System.Drawing.Size(178, 17);
            this.radioWNorm.TabIndex = 17;
            this.radioWNorm.Text = "Window Size Normalization";
            this.radioWNorm.UseVisualStyleBackColor = true;
            // 
            // radioANorm
            // 
            this.radioANorm.AutoSize = true;
            this.radioANorm.Checked = true;
            this.radioANorm.Location = new System.Drawing.Point(248, 59);
            this.radioANorm.Name = "radioANorm";
            this.radioANorm.Size = new System.Drawing.Size(150, 17);
            this.radioANorm.TabIndex = 45;
            this.radioANorm.TabStop = true;
            this.radioANorm.Text = "All Data Normalization";
            this.radioANorm.UseVisualStyleBackColor = true;
            // 
            // AnalysisOption
            // 
            this.AnalysisOption.Controls.Add(this.checkBoxAmplitude);
            this.AnalysisOption.Controls.Add(this.radioButtonPNT);
            this.AnalysisOption.Controls.Add(this.radioButtonRNT);
            this.AnalysisOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalysisOption.Location = new System.Drawing.Point(15, 31);
            this.AnalysisOption.Name = "AnalysisOption";
            this.AnalysisOption.Size = new System.Drawing.Size(430, 87);
            this.AnalysisOption.TabIndex = 38;
            this.AnalysisOption.TabStop = false;
            this.AnalysisOption.Text = "Analysis Option";
            // 
            // radioButtonRNT
            // 
            this.radioButtonRNT.AutoSize = true;
            this.radioButtonRNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRNT.Location = new System.Drawing.Point(266, 21);
            this.radioButtonRNT.Name = "radioButtonRNT";
            this.radioButtonRNT.Size = new System.Drawing.Size(97, 17);
            this.radioButtonRNT.TabIndex = 24;
            this.radioButtonRNT.Text = "RNT Method";
            this.radioButtonRNT.UseVisualStyleBackColor = true;
            // 
            // radioButtonPNT
            // 
            this.radioButtonPNT.AutoSize = true;
            this.radioButtonPNT.Checked = true;
            this.radioButtonPNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPNT.Location = new System.Drawing.Point(52, 21);
            this.radioButtonPNT.Name = "radioButtonPNT";
            this.radioButtonPNT.Size = new System.Drawing.Size(96, 17);
            this.radioButtonPNT.TabIndex = 23;
            this.radioButtonPNT.TabStop = true;
            this.radioButtonPNT.Text = "PNT Method";
            this.radioButtonPNT.UseVisualStyleBackColor = true;
            // 
            // checkBoxAmplitude
            // 
            this.checkBoxAmplitude.AutoSize = true;
            this.checkBoxAmplitude.Checked = true;
            this.checkBoxAmplitude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAmplitude.Location = new System.Drawing.Point(141, 55);
            this.checkBoxAmplitude.Name = "checkBoxAmplitude";
            this.checkBoxAmplitude.Size = new System.Drawing.Size(124, 17);
            this.checkBoxAmplitude.TabIndex = 25;
            this.checkBoxAmplitude.Text = "Intensity Analysis";
            this.checkBoxAmplitude.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 232);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtering Options";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(556, 427);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(616, 31);
            this.progressBar.TabIndex = 44;
            // 
            // btnNeural
            // 
            this.btnNeural.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeural.Location = new System.Drawing.Point(792, 181);
            this.btnNeural.Name = "btnNeural";
            this.btnNeural.Size = new System.Drawing.Size(138, 65);
            this.btnNeural.TabIndex = 45;
            this.btnNeural.Text = "Open the Neural Coding";
            this.btnNeural.UseVisualStyleBackColor = true;
            this.btnNeural.Click += new System.EventHandler(this.btnNeural_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(726, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 62);
            this.label3.TabIndex = 46;
            this.label3.Text = "If you want to use the Neural Coding program to create different audio stimuli sc" +
    "enarios, please click the button below.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(137, 24);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 714);
            this.tabControl1.TabIndex = 29;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 753);
            this.Name = "mainForm";
            this.Text = "Neural Activity Monitoring System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.pnlListView.ResumeLayout(false);
            this.pnlListView.PerformLayout();
            this.pnlNetwork.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlIntensity.ResumeLayout(false);
            this.pnlIntensity.PerformLayout();
            this.pnlSignal.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlSelAnal.ResumeLayout(false);
            this.pnlSelAnal.PerformLayout();
            this.AnalysisOption.ResumeLayout(false);
            this.AnalysisOption.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox pnlNetwork;
        private System.Windows.Forms.Button allNetwork;
        private System.Windows.Forms.WebBrowser networkBrowser;
        private System.Windows.Forms.GroupBox pnlListView;
        private System.Windows.Forms.ListView listViewRecord3;
        public System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView listViewRecord2;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RadioButton radioAntipodal;
        private System.Windows.Forms.RadioButton radioActivity;
        private System.Windows.Forms.ListView listViewRecord;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox pnlSignal;
        private System.Windows.Forms.Panel pnlGraphs;
        private System.Windows.Forms.GroupBox pnlIntensity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.GroupBox pnlControl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.HScrollBar hScrollBarSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.GroupBox pnlBrainImg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNeural;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox AnalysisOption;
        private System.Windows.Forms.CheckBox checkBoxAmplitude;
        private System.Windows.Forms.RadioButton radioButtonPNT;
        private System.Windows.Forms.RadioButton radioButtonRNT;
        private System.Windows.Forms.GroupBox pnlSelAnal;
        private System.Windows.Forms.RadioButton radioANorm;
        private System.Windows.Forms.RadioButton radioWNorm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecision;
        private System.Windows.Forms.TextBox txtHilbertSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

