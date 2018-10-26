namespace _2DoF
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.FirstMassTextBox = new System.Windows.Forms.TextBox();
            this.InputParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.SecondSpringStiffnessUnitLabel = new System.Windows.Forms.Label();
            this.Mass1Label = new System.Windows.Forms.Label();
            this.SecondMassTextBox = new System.Windows.Forms.TextBox();
            this.SecondSpringStiffnessTextBox = new System.Windows.Forms.TextBox();
            this.SecondMassLabel = new System.Windows.Forms.Label();
            this.SecondSpringStiffnessLabel = new System.Windows.Forms.Label();
            this.FirstMassUnit = new System.Windows.Forms.Label();
            this.FirstSpringStiffnessUnitLabel = new System.Windows.Forms.Label();
            this.FirstSpringStiffnessTextBox = new System.Windows.Forms.TextBox();
            this.FirstSpringStiffnessLabel = new System.Windows.Forms.Label();
            this.SecondMassUnitLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimeData = new System.Windows.Forms.GroupBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeUnitLabel = new System.Windows.Forms.Label();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.TimeStepUnitLabel = new System.Windows.Forms.Label();
            this.TimeStepTextBox = new System.Windows.Forms.TextBox();
            this.TimeStepLabel = new System.Windows.Forms.Label();
            this.EndTimeUnitLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InitialConditionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ICVelocity2UnitLabel = new System.Windows.Forms.Label();
            this.ICDisplacement1Label = new System.Windows.Forms.Label();
            this.ICDisplacement1TextBox = new System.Windows.Forms.TextBox();
            this.ICVelocity1Label = new System.Windows.Forms.Label();
            this.ICVelocity1TextBox = new System.Windows.Forms.TextBox();
            this.ICVelocity2Label = new System.Windows.Forms.Label();
            this.ICDisplacement2TextBox = new System.Windows.Forms.TextBox();
            this.ICDisplacement2UnitLabel = new System.Windows.Forms.Label();
            this.ICDisplacement1UnitLabel = new System.Windows.Forms.Label();
            this.ICVelocity2TextBox = new System.Windows.Forms.TextBox();
            this.ICDisplacement2Label = new System.Windows.Forms.Label();
            this.ICVelocity1UnitLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InputParametersGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TimeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.InitialConditionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstMassTextBox
            // 
            this.FirstMassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstMassTextBox.Location = new System.Drawing.Point(162, 30);
            this.FirstMassTextBox.Name = "FirstMassTextBox";
            this.FirstMassTextBox.Size = new System.Drawing.Size(100, 22);
            this.FirstMassTextBox.TabIndex = 0;
            this.FirstMassTextBox.LostFocus += new System.EventHandler(this.FirstMassTextBox_TextChanged);
            // 
            // InputParametersGroupBox
            // 
            this.InputParametersGroupBox.Controls.Add(this.SecondSpringStiffnessUnitLabel);
            this.InputParametersGroupBox.Controls.Add(this.Mass1Label);
            this.InputParametersGroupBox.Controls.Add(this.SecondMassTextBox);
            this.InputParametersGroupBox.Controls.Add(this.SecondSpringStiffnessTextBox);
            this.InputParametersGroupBox.Controls.Add(this.SecondMassLabel);
            this.InputParametersGroupBox.Controls.Add(this.SecondSpringStiffnessLabel);
            this.InputParametersGroupBox.Controls.Add(this.FirstMassUnit);
            this.InputParametersGroupBox.Controls.Add(this.FirstMassTextBox);
            this.InputParametersGroupBox.Controls.Add(this.FirstSpringStiffnessUnitLabel);
            this.InputParametersGroupBox.Controls.Add(this.FirstSpringStiffnessTextBox);
            this.InputParametersGroupBox.Controls.Add(this.FirstSpringStiffnessLabel);
            this.InputParametersGroupBox.Controls.Add(this.SecondMassUnitLabel);
            this.InputParametersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputParametersGroupBox.Location = new System.Drawing.Point(6, 121);
            this.InputParametersGroupBox.Name = "InputParametersGroupBox";
            this.InputParametersGroupBox.Size = new System.Drawing.Size(309, 145);
            this.InputParametersGroupBox.TabIndex = 1;
            this.InputParametersGroupBox.TabStop = false;
            this.InputParametersGroupBox.Text = "System Input Parameter";
            // 
            // SecondSpringStiffnessUnitLabel
            // 
            this.SecondSpringStiffnessUnitLabel.AutoSize = true;
            this.SecondSpringStiffnessUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondSpringStiffnessUnitLabel.Location = new System.Drawing.Point(268, 115);
            this.SecondSpringStiffnessUnitLabel.Name = "SecondSpringStiffnessUnitLabel";
            this.SecondSpringStiffnessUnitLabel.Size = new System.Drawing.Size(44, 16);
            this.SecondSpringStiffnessUnitLabel.TabIndex = 2;
            this.SecondSpringStiffnessUnitLabel.Text = "N/mm";
            // 
            // Mass1Label
            // 
            this.Mass1Label.AutoSize = true;
            this.Mass1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mass1Label.Location = new System.Drawing.Point(87, 31);
            this.Mass1Label.Name = "Mass1Label";
            this.Mass1Label.Size = new System.Drawing.Size(69, 16);
            this.Mass1Label.TabIndex = 1;
            this.Mass1Label.Text = "First Mass";
            // 
            // SecondMassTextBox
            // 
            this.SecondMassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondMassTextBox.Location = new System.Drawing.Point(162, 58);
            this.SecondMassTextBox.Name = "SecondMassTextBox";
            this.SecondMassTextBox.Size = new System.Drawing.Size(100, 22);
            this.SecondMassTextBox.TabIndex = 0;
            this.SecondMassTextBox.LostFocus += new System.EventHandler(this.SecondMassTextBox_TextChanged);
            // 
            // SecondSpringStiffnessTextBox
            // 
            this.SecondSpringStiffnessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondSpringStiffnessTextBox.Location = new System.Drawing.Point(162, 114);
            this.SecondSpringStiffnessTextBox.Name = "SecondSpringStiffnessTextBox";
            this.SecondSpringStiffnessTextBox.Size = new System.Drawing.Size(100, 22);
            this.SecondSpringStiffnessTextBox.TabIndex = 0;
            this.SecondSpringStiffnessTextBox.LostFocus += new System.EventHandler(this.SecondSpringStiffness_TextChanged);
            // 
            // SecondMassLabel
            // 
            this.SecondMassLabel.AutoSize = true;
            this.SecondMassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondMassLabel.Location = new System.Drawing.Point(65, 59);
            this.SecondMassLabel.Name = "SecondMassLabel";
            this.SecondMassLabel.Size = new System.Drawing.Size(91, 16);
            this.SecondMassLabel.TabIndex = 1;
            this.SecondMassLabel.Text = "Second Mass";
            // 
            // SecondSpringStiffnessLabel
            // 
            this.SecondSpringStiffnessLabel.AutoSize = true;
            this.SecondSpringStiffnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondSpringStiffnessLabel.Location = new System.Drawing.Point(6, 114);
            this.SecondSpringStiffnessLabel.Name = "SecondSpringStiffnessLabel";
            this.SecondSpringStiffnessLabel.Size = new System.Drawing.Size(150, 16);
            this.SecondSpringStiffnessLabel.TabIndex = 1;
            this.SecondSpringStiffnessLabel.Text = "Second Spring Stiffness";
            // 
            // FirstMassUnit
            // 
            this.FirstMassUnit.AutoSize = true;
            this.FirstMassUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstMassUnit.Location = new System.Drawing.Point(268, 31);
            this.FirstMassUnit.Name = "FirstMassUnit";
            this.FirstMassUnit.Size = new System.Drawing.Size(24, 16);
            this.FirstMassUnit.TabIndex = 2;
            this.FirstMassUnit.Text = "Kg";
            // 
            // FirstSpringStiffnessUnitLabel
            // 
            this.FirstSpringStiffnessUnitLabel.AutoSize = true;
            this.FirstSpringStiffnessUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSpringStiffnessUnitLabel.Location = new System.Drawing.Point(268, 87);
            this.FirstSpringStiffnessUnitLabel.Name = "FirstSpringStiffnessUnitLabel";
            this.FirstSpringStiffnessUnitLabel.Size = new System.Drawing.Size(44, 16);
            this.FirstSpringStiffnessUnitLabel.TabIndex = 2;
            this.FirstSpringStiffnessUnitLabel.Text = "N/mm";
            // 
            // FirstSpringStiffnessTextBox
            // 
            this.FirstSpringStiffnessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSpringStiffnessTextBox.Location = new System.Drawing.Point(162, 86);
            this.FirstSpringStiffnessTextBox.Name = "FirstSpringStiffnessTextBox";
            this.FirstSpringStiffnessTextBox.Size = new System.Drawing.Size(100, 22);
            this.FirstSpringStiffnessTextBox.TabIndex = 0;
            this.FirstSpringStiffnessTextBox.LostFocus += new System.EventHandler(this.FirstSpringStiffnessTextBox_TextChanged);
            // 
            // FirstSpringStiffnessLabel
            // 
            this.FirstSpringStiffnessLabel.AutoSize = true;
            this.FirstSpringStiffnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSpringStiffnessLabel.Location = new System.Drawing.Point(35, 87);
            this.FirstSpringStiffnessLabel.Name = "FirstSpringStiffnessLabel";
            this.FirstSpringStiffnessLabel.Size = new System.Drawing.Size(125, 16);
            this.FirstSpringStiffnessLabel.TabIndex = 1;
            this.FirstSpringStiffnessLabel.Text = "First Spring Siffness";
            // 
            // SecondMassUnitLabel
            // 
            this.SecondMassUnitLabel.AutoSize = true;
            this.SecondMassUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondMassUnitLabel.Location = new System.Drawing.Point(268, 59);
            this.SecondMassUnitLabel.Name = "SecondMassUnitLabel";
            this.SecondMassUnitLabel.Size = new System.Drawing.Size(24, 16);
            this.SecondMassUnitLabel.TabIndex = 2;
            this.SecondMassUnitLabel.Text = "Kg";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 774);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TimeData);
            this.tabPage1.Controls.Add(this.CalculateButton);
            this.tabPage1.Controls.Add(this.chart2);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.InitialConditionsGroupBox);
            this.tabPage1.Controls.Add(this.InputParametersGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1224, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TimeData
            // 
            this.TimeData.Controls.Add(this.StartTimeLabel);
            this.TimeData.Controls.Add(this.EndTimeTextBox);
            this.TimeData.Controls.Add(this.EndTimeLabel);
            this.TimeData.Controls.Add(this.StartTimeUnitLabel);
            this.TimeData.Controls.Add(this.StartTimeTextBox);
            this.TimeData.Controls.Add(this.TimeStepUnitLabel);
            this.TimeData.Controls.Add(this.TimeStepTextBox);
            this.TimeData.Controls.Add(this.TimeStepLabel);
            this.TimeData.Controls.Add(this.EndTimeUnitLabel);
            this.TimeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeData.Location = new System.Drawing.Point(6, 6);
            this.TimeData.Name = "TimeData";
            this.TimeData.Size = new System.Drawing.Size(309, 109);
            this.TimeData.TabIndex = 3;
            this.TimeData.TabStop = false;
            this.TimeData.Text = "Time Data";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(87, 24);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(69, 16);
            this.StartTimeLabel.TabIndex = 1;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeTextBox.Location = new System.Drawing.Point(162, 51);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.EndTimeTextBox.TabIndex = 0;
            this.EndTimeTextBox.LostFocus += new System.EventHandler(this.EndTimeTextBox_TextChanged);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLabel.Location = new System.Drawing.Point(90, 54);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(66, 16);
            this.EndTimeLabel.TabIndex = 1;
            this.EndTimeLabel.Text = "End Time";
            // 
            // StartTimeUnitLabel
            // 
            this.StartTimeUnitLabel.AutoSize = true;
            this.StartTimeUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeUnitLabel.Location = new System.Drawing.Point(268, 24);
            this.StartTimeUnitLabel.Name = "StartTimeUnitLabel";
            this.StartTimeUnitLabel.Size = new System.Drawing.Size(15, 16);
            this.StartTimeUnitLabel.TabIndex = 2;
            this.StartTimeUnitLabel.Text = "s";
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeTextBox.Location = new System.Drawing.Point(162, 23);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.StartTimeTextBox.TabIndex = 0;
            this.StartTimeTextBox.LostFocus += new System.EventHandler(this.StartTimeTextBox_TextChanged);
            // 
            // TimeStepUnitLabel
            // 
            this.TimeStepUnitLabel.AutoSize = true;
            this.TimeStepUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepUnitLabel.Location = new System.Drawing.Point(268, 80);
            this.TimeStepUnitLabel.Name = "TimeStepUnitLabel";
            this.TimeStepUnitLabel.Size = new System.Drawing.Size(15, 16);
            this.TimeStepUnitLabel.TabIndex = 2;
            this.TimeStepUnitLabel.Text = "s";
            // 
            // TimeStepTextBox
            // 
            this.TimeStepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepTextBox.Location = new System.Drawing.Point(162, 79);
            this.TimeStepTextBox.Name = "TimeStepTextBox";
            this.TimeStepTextBox.Size = new System.Drawing.Size(100, 22);
            this.TimeStepTextBox.TabIndex = 0;
            this.TimeStepTextBox.LostFocus += new System.EventHandler(this.TimeStepTextBox_TextChanged);
            // 
            // TimeStepLabel
            // 
            this.TimeStepLabel.AutoSize = true;
            this.TimeStepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepLabel.Location = new System.Drawing.Point(86, 80);
            this.TimeStepLabel.Name = "TimeStepLabel";
            this.TimeStepLabel.Size = new System.Drawing.Size(70, 16);
            this.TimeStepLabel.TabIndex = 1;
            this.TimeStepLabel.Text = "Time Step";
            // 
            // EndTimeUnitLabel
            // 
            this.EndTimeUnitLabel.AutoSize = true;
            this.EndTimeUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeUnitLabel.Location = new System.Drawing.Point(268, 52);
            this.EndTimeUnitLabel.Name = "EndTimeUnitLabel";
            this.EndTimeUnitLabel.Size = new System.Drawing.Size(15, 16);
            this.EndTimeUnitLabel.TabIndex = 2;
            this.EndTimeUnitLabel.Text = "s";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(6, 417);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(84, 29);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "Body 2";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(321, 356);
            this.chart2.Name = "chart2";
            series1.ChartArea = "Body 2";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Body 2";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(897, 344);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Body2DisplacementTitle";
            title1.Text = "Body 2 Displacement";
            this.chart2.Titles.Add(title1);
            // 
            // chart1
            // 
            chartArea2.Name = "Body 1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(321, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "Body 1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Body 1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(897, 344);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Body1DisplacementTitle";
            title2.Text = "Body 1 Displacement";
            this.chart1.Titles.Add(title2);
            // 
            // InitialConditionsGroupBox
            // 
            this.InitialConditionsGroupBox.Controls.Add(this.ICVelocity2UnitLabel);
            this.InitialConditionsGroupBox.Controls.Add(this.ICDisplacement1Label);
            this.InitialConditionsGroupBox.Controls.Add(this.ICDisplacement1TextBox);
            this.InitialConditionsGroupBox.Controls.Add(this.ICVelocity1Label);
            this.InitialConditionsGroupBox.Controls.Add(this.ICVelocity1TextBox);
            this.InitialConditionsGroupBox.Controls.Add(this.ICVelocity2Label);
            this.InitialConditionsGroupBox.Controls.Add(this.ICDisplacement2TextBox);
            this.InitialConditionsGroupBox.Controls.Add(this.ICDisplacement2UnitLabel);
            this.InitialConditionsGroupBox.Controls.Add(this.ICDisplacement1UnitLabel);
            this.InitialConditionsGroupBox.Controls.Add(this.ICVelocity2TextBox);
            this.InitialConditionsGroupBox.Controls.Add(this.ICDisplacement2Label);
            this.InitialConditionsGroupBox.Controls.Add(this.ICVelocity1UnitLabel);
            this.InitialConditionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialConditionsGroupBox.Location = new System.Drawing.Point(6, 272);
            this.InitialConditionsGroupBox.Name = "InitialConditionsGroupBox";
            this.InitialConditionsGroupBox.Size = new System.Drawing.Size(309, 139);
            this.InitialConditionsGroupBox.TabIndex = 1;
            this.InitialConditionsGroupBox.TabStop = false;
            this.InitialConditionsGroupBox.Text = "Initial Conditions";
            // 
            // ICVelocity2UnitLabel
            // 
            this.ICVelocity2UnitLabel.AutoSize = true;
            this.ICVelocity2UnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICVelocity2UnitLabel.Location = new System.Drawing.Point(268, 110);
            this.ICVelocity2UnitLabel.Name = "ICVelocity2UnitLabel";
            this.ICVelocity2UnitLabel.Size = new System.Drawing.Size(30, 16);
            this.ICVelocity2UnitLabel.TabIndex = 2;
            this.ICVelocity2UnitLabel.Text = "m/s";
            // 
            // ICDisplacement1Label
            // 
            this.ICDisplacement1Label.AutoSize = true;
            this.ICDisplacement1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICDisplacement1Label.Location = new System.Drawing.Point(55, 31);
            this.ICDisplacement1Label.Name = "ICDisplacement1Label";
            this.ICDisplacement1Label.Size = new System.Drawing.Size(101, 16);
            this.ICDisplacement1Label.TabIndex = 1;
            this.ICDisplacement1Label.Text = "Displacement 1";
            // 
            // ICDisplacement1TextBox
            // 
            this.ICDisplacement1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICDisplacement1TextBox.Location = new System.Drawing.Point(162, 30);
            this.ICDisplacement1TextBox.Name = "ICDisplacement1TextBox";
            this.ICDisplacement1TextBox.Size = new System.Drawing.Size(100, 22);
            this.ICDisplacement1TextBox.TabIndex = 0;
            this.ICDisplacement1TextBox.LostFocus += new System.EventHandler(this.ICDisplacement1TextBox_TextChanged);
            // 
            // ICVelocity1Label
            // 
            this.ICVelocity1Label.AutoSize = true;
            this.ICVelocity1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICVelocity1Label.Location = new System.Drawing.Point(90, 58);
            this.ICVelocity1Label.Name = "ICVelocity1Label";
            this.ICVelocity1Label.Size = new System.Drawing.Size(66, 16);
            this.ICVelocity1Label.TabIndex = 1;
            this.ICVelocity1Label.Text = "Velocity 1";
            // 
            // ICVelocity1TextBox
            // 
            this.ICVelocity1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICVelocity1TextBox.Location = new System.Drawing.Point(162, 56);
            this.ICVelocity1TextBox.Name = "ICVelocity1TextBox";
            this.ICVelocity1TextBox.Size = new System.Drawing.Size(100, 22);
            this.ICVelocity1TextBox.TabIndex = 0;
            this.ICVelocity1TextBox.LostFocus += new System.EventHandler(this.ICVelocity1TextBox_TextChanged);
            // 
            // ICVelocity2Label
            // 
            this.ICVelocity2Label.AutoSize = true;
            this.ICVelocity2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICVelocity2Label.Location = new System.Drawing.Point(90, 110);
            this.ICVelocity2Label.Name = "ICVelocity2Label";
            this.ICVelocity2Label.Size = new System.Drawing.Size(66, 16);
            this.ICVelocity2Label.TabIndex = 1;
            this.ICVelocity2Label.Text = "Velocity 2";
            // 
            // ICDisplacement2TextBox
            // 
            this.ICDisplacement2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICDisplacement2TextBox.Location = new System.Drawing.Point(162, 82);
            this.ICDisplacement2TextBox.Name = "ICDisplacement2TextBox";
            this.ICDisplacement2TextBox.Size = new System.Drawing.Size(100, 22);
            this.ICDisplacement2TextBox.TabIndex = 0;
            this.ICDisplacement2TextBox.LostFocus += new System.EventHandler(this.ICDisplacement2TextBox_TextChanged);
            // 
            // ICDisplacement2UnitLabel
            // 
            this.ICDisplacement2UnitLabel.AutoSize = true;
            this.ICDisplacement2UnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICDisplacement2UnitLabel.Location = new System.Drawing.Point(268, 82);
            this.ICDisplacement2UnitLabel.Name = "ICDisplacement2UnitLabel";
            this.ICDisplacement2UnitLabel.Size = new System.Drawing.Size(30, 16);
            this.ICDisplacement2UnitLabel.TabIndex = 2;
            this.ICDisplacement2UnitLabel.Text = "mm";
            // 
            // ICDisplacement1UnitLabel
            // 
            this.ICDisplacement1UnitLabel.AutoSize = true;
            this.ICDisplacement1UnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICDisplacement1UnitLabel.Location = new System.Drawing.Point(268, 31);
            this.ICDisplacement1UnitLabel.Name = "ICDisplacement1UnitLabel";
            this.ICDisplacement1UnitLabel.Size = new System.Drawing.Size(30, 16);
            this.ICDisplacement1UnitLabel.TabIndex = 2;
            this.ICDisplacement1UnitLabel.Text = "mm";
            // 
            // ICVelocity2TextBox
            // 
            this.ICVelocity2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICVelocity2TextBox.Location = new System.Drawing.Point(162, 108);
            this.ICVelocity2TextBox.Name = "ICVelocity2TextBox";
            this.ICVelocity2TextBox.Size = new System.Drawing.Size(100, 22);
            this.ICVelocity2TextBox.TabIndex = 0;
            this.ICVelocity2TextBox.LostFocus += new System.EventHandler(this.ICVelocity2TextBox_TextChanged);
            // 
            // ICDisplacement2Label
            // 
            this.ICDisplacement2Label.AutoSize = true;
            this.ICDisplacement2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICDisplacement2Label.Location = new System.Drawing.Point(55, 83);
            this.ICDisplacement2Label.Name = "ICDisplacement2Label";
            this.ICDisplacement2Label.Size = new System.Drawing.Size(101, 16);
            this.ICDisplacement2Label.TabIndex = 1;
            this.ICDisplacement2Label.Text = "Displacement 2";
            // 
            // ICVelocity1UnitLabel
            // 
            this.ICVelocity1UnitLabel.AutoSize = true;
            this.ICVelocity1UnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICVelocity1UnitLabel.Location = new System.Drawing.Point(268, 58);
            this.ICVelocity1UnitLabel.Name = "ICVelocity1UnitLabel";
            this.ICVelocity1UnitLabel.Size = new System.Drawing.Size(30, 16);
            this.ICVelocity1UnitLabel.TabIndex = 2;
            this.ICVelocity1UnitLabel.Text = "m/s";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 748);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 798);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InputParametersGroupBox.ResumeLayout(false);
            this.InputParametersGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TimeData.ResumeLayout(false);
            this.TimeData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.InitialConditionsGroupBox.ResumeLayout(false);
            this.InitialConditionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstMassTextBox;
        private System.Windows.Forms.GroupBox InputParametersGroupBox;
        private System.Windows.Forms.Label Mass1Label;
        private System.Windows.Forms.Label SecondSpringStiffnessUnitLabel;
        private System.Windows.Forms.Label FirstSpringStiffnessUnitLabel;
        private System.Windows.Forms.Label SecondMassUnitLabel;
        private System.Windows.Forms.Label FirstMassUnit;
        private System.Windows.Forms.Label SecondSpringStiffnessLabel;
        private System.Windows.Forms.Label FirstSpringStiffnessLabel;
        private System.Windows.Forms.Label SecondMassLabel;
        private System.Windows.Forms.TextBox SecondSpringStiffnessTextBox;
        private System.Windows.Forms.TextBox FirstSpringStiffnessTextBox;
        private System.Windows.Forms.TextBox SecondMassTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox InitialConditionsGroupBox;
        private System.Windows.Forms.Label ICVelocity2UnitLabel;
        private System.Windows.Forms.Label ICDisplacement2UnitLabel;
        private System.Windows.Forms.Label ICVelocity1UnitLabel;
        private System.Windows.Forms.Label ICDisplacement1UnitLabel;
        private System.Windows.Forms.Label ICVelocity2Label;
        private System.Windows.Forms.Label ICDisplacement2Label;
        private System.Windows.Forms.Label ICVelocity1Label;
        private System.Windows.Forms.Label ICDisplacement1Label;
        private System.Windows.Forms.TextBox ICVelocity2TextBox;
        private System.Windows.Forms.TextBox ICDisplacement2TextBox;
        private System.Windows.Forms.TextBox ICVelocity1TextBox;
        private System.Windows.Forms.TextBox ICDisplacement1TextBox;
        private System.Windows.Forms.GroupBox TimeData;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeUnitLabel;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private System.Windows.Forms.Label TimeStepUnitLabel;
        private System.Windows.Forms.TextBox TimeStepTextBox;
        private System.Windows.Forms.Label TimeStepLabel;
        private System.Windows.Forms.Label EndTimeUnitLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

