namespace QM42Maneger
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.cbxBound = new System.Windows.Forms.ComboBox();
            this.txtModbusID = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxVT = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRegTemp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtalerm = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblVibracao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gfVibracao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numVibracao = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.graficoTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numTempLimite = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDatalogPoll = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numRateLog = new System.Windows.Forms.NumericUpDown();
            this.txtpainel = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerTemp = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gfVibracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVibracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempLimite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRateLog)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxPorta
            // 
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Location = new System.Drawing.Point(76, 20);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(121, 21);
            this.cbxPorta.TabIndex = 0;
            this.cbxPorta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxPorta_MouseClick);
            // 
            // cbxBound
            // 
            this.cbxBound.FormattingEnabled = true;
            this.cbxBound.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400"});
            this.cbxBound.Location = new System.Drawing.Point(76, 47);
            this.cbxBound.Name = "cbxBound";
            this.cbxBound.Size = new System.Drawing.Size(121, 21);
            this.cbxBound.TabIndex = 1;
            // 
            // txtModbusID
            // 
            this.txtModbusID.Location = new System.Drawing.Point(76, 74);
            this.txtModbusID.Name = "txtModbusID";
            this.txtModbusID.Size = new System.Drawing.Size(100, 20);
            this.txtModbusID.TabIndex = 2;
            this.txtModbusID.Text = "1";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(76, 126);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bound:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modbus ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Poll (ms):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxVT);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtRegTemp);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtalerm);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRegistro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtModbusID);
            this.groupBox1.Controls.Add(this.cbxPorta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxBound);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config Física";
            // 
            // cbxVT
            // 
            this.cbxVT.FormattingEnabled = true;
            this.cbxVT.Items.AddRange(new object[] {
            "VT2",
            "VT1"});
            this.cbxVT.Location = new System.Drawing.Point(76, 207);
            this.cbxVT.Name = "cbxVT";
            this.cbxVT.Size = new System.Drawing.Size(101, 21);
            this.cbxVT.TabIndex = 14;
            this.cbxVT.SelectedIndexChanged += new System.EventHandler(this.cbxVT_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Dispositivo:";
            // 
            // txtRegTemp
            // 
            this.txtRegTemp.Location = new System.Drawing.Point(77, 181);
            this.txtRegTemp.Name = "txtRegTemp";
            this.txtRegTemp.Size = new System.Drawing.Size(100, 20);
            this.txtRegTemp.TabIndex = 13;
            this.txtRegTemp.Text = "43";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Reg. Temp:";
            // 
            // txtalerm
            // 
            this.txtalerm.Location = new System.Drawing.Point(76, 152);
            this.txtalerm.Name = "txtalerm";
            this.txtalerm.Size = new System.Drawing.Size(100, 20);
            this.txtalerm.TabIndex = 10;
            this.txtalerm.Text = "72";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Alarm ID";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(76, 100);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro.TabIndex = 9;
            this.txtRegistro.Text = "2403";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reg. Vibração:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(146, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblVibracao
            // 
            this.lblVibracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVibracao.AutoSize = true;
            this.lblVibracao.BackColor = System.Drawing.SystemColors.Window;
            this.lblVibracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVibracao.Location = new System.Drawing.Point(892, 95);
            this.lblVibracao.Name = "lblVibracao";
            this.lblVibracao.Size = new System.Drawing.Size(24, 25);
            this.lblVibracao.TabIndex = 11;
            this.lblVibracao.Text = "0";
            this.lblVibracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(459, 725);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "status";
            // 
            // gfVibracao
            // 
            this.gfVibracao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.gfVibracao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Vibração no Tempo";
            this.gfVibracao.Legends.Add(legend1);
            this.gfVibracao.Location = new System.Drawing.Point(308, 13);
            this.gfVibracao.Name = "gfVibracao";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.LegendText = "Vibração";
            series1.Name = "Vibração (mm/s)";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.LabelForeColor = System.Drawing.Color.DarkRed;
            series2.Legend = "Legend1";
            series2.Name = "Valor Critico";
            this.gfVibracao.Series.Add(series1);
            this.gfVibracao.Series.Add(series2);
            this.gfVibracao.Size = new System.Drawing.Size(710, 356);
            this.gfVibracao.TabIndex = 13;
            this.gfVibracao.Text = "Vibração no Tempo";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(971, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "mm/s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Limite Vibr.:";
            // 
            // numVibracao
            // 
            this.numVibracao.Location = new System.Drawing.Point(99, 80);
            this.numVibracao.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numVibracao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVibracao.Name = "numVibracao";
            this.numVibracao.Size = new System.Drawing.Size(65, 20);
            this.numVibracao.TabIndex = 12;
            this.numVibracao.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Motor:";
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(99, 24);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(100, 20);
            this.txtMotor.TabIndex = 16;
            this.txtMotor.Text = "Motor01";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Medição/Log:";
            // 
            // graficoTemp
            // 
            this.graficoTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.graficoTemp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            legend2.Title = "Temperatura no tempo";
            this.graficoTemp.Legends.Add(legend2);
            this.graficoTemp.Location = new System.Drawing.Point(308, 375);
            this.graficoTemp.Name = "graficoTemp";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend2";
            series3.LegendText = "Temperatura";
            series3.Name = "Temperatura C°";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.LabelForeColor = System.Drawing.Color.DarkRed;
            series4.Legend = "Legend2";
            series4.Name = "Valor Critico";
            this.graficoTemp.Series.Add(series3);
            this.graficoTemp.Series.Add(series4);
            this.graficoTemp.Size = new System.Drawing.Size(710, 356);
            this.graficoTemp.TabIndex = 19;
            this.graficoTemp.Text = "Temperatura no Tempo";
            // 
            // numTempLimite
            // 
            this.numTempLimite.Location = new System.Drawing.Point(99, 108);
            this.numTempLimite.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numTempLimite.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.numTempLimite.Name = "numTempLimite";
            this.numTempLimite.Size = new System.Drawing.Size(65, 20);
            this.numTempLimite.TabIndex = 21;
            this.numTempLimite.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Limite Temp.:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(971, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "C°";
            // 
            // lblTemp
            // 
            this.lblTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.SystemColors.Window;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(899, 458);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(24, 25);
            this.lblTemp.TabIndex = 22;
            this.lblTemp.Text = "0";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDatalogPoll);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numRateLog);
            this.groupBox2.Controls.Add(this.numVibracao);
            this.groupBox2.Controls.Add(this.numTempLimite);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMotor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 171);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config. de Monitoramento";
            // 
            // txtDatalogPoll
            // 
            this.txtDatalogPoll.Location = new System.Drawing.Point(99, 50);
            this.txtDatalogPoll.Name = "txtDatalogPoll";
            this.txtDatalogPoll.Size = new System.Drawing.Size(100, 20);
            this.txtDatalogPoll.TabIndex = 23;
            this.txtDatalogPoll.Text = "60";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Poll DataLog(s):";
            // 
            // numRateLog
            // 
            this.numRateLog.Location = new System.Drawing.Point(99, 137);
            this.numRateLog.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numRateLog.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRateLog.Name = "numRateLog";
            this.numRateLog.Size = new System.Drawing.Size(65, 20);
            this.numRateLog.TabIndex = 22;
            this.numRateLog.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // txtpainel
            // 
            this.txtpainel.Location = new System.Drawing.Point(13, 551);
            this.txtpainel.Multiline = true;
            this.txtpainel.Name = "txtpainel";
            this.txtpainel.Size = new System.Drawing.Size(269, 180);
            this.txtpainel.TabIndex = 25;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerTemp
            // 
            this.timerTemp.Interval = 600;
            this.timerTemp.Tick += new System.EventHandler(this.timerTemp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 742);
            this.Controls.Add(this.txtpainel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.graficoTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblVibracao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gfVibracao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VT1 / VT2 Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gfVibracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVibracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempLimite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRateLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.ComboBox cbxBound;
        private System.Windows.Forms.TextBox txtModbusID;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblVibracao;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart gfVibracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numVibracao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoTemp;
        private System.Windows.Forms.NumericUpDown numTempLimite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numRateLog;
        private System.Windows.Forms.TextBox txtpainel;
        private System.Windows.Forms.TextBox txtDatalogPoll;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtalerm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRegTemp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxVT;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Timer timerTemp;
    }
}

