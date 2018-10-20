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
            this.FirstMassTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SecondSpringStiffnessUnitLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondMassUnitLabel = new System.Windows.Forms.Label();
            this.FirstMassUnit = new System.Windows.Forms.Label();
            this.SecondSpringStiffnessLabel = new System.Windows.Forms.Label();
            this.FirstSpringStiffnessLabel = new System.Windows.Forms.Label();
            this.SecondMassLabel = new System.Windows.Forms.Label();
            this.Mass1Label = new System.Windows.Forms.Label();
            this.SecondSpringStiffness = new System.Windows.Forms.TextBox();
            this.FirstSpringStiffnessTextBox = new System.Windows.Forms.TextBox();
            this.SecondMassTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlotButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstMassTextBox
            // 
            this.FirstMassTextBox.Location = new System.Drawing.Point(109, 28);
            this.FirstMassTextBox.Name = "FirstMassTextBox";
            this.FirstMassTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstMassTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SecondSpringStiffnessUnitLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SecondMassUnitLabel);
            this.groupBox1.Controls.Add(this.FirstMassUnit);
            this.groupBox1.Controls.Add(this.SecondSpringStiffnessLabel);
            this.groupBox1.Controls.Add(this.FirstSpringStiffnessLabel);
            this.groupBox1.Controls.Add(this.SecondMassLabel);
            this.groupBox1.Controls.Add(this.Mass1Label);
            this.groupBox1.Controls.Add(this.SecondSpringStiffness);
            this.groupBox1.Controls.Add(this.FirstSpringStiffnessTextBox);
            this.groupBox1.Controls.Add(this.SecondMassTextBox);
            this.groupBox1.Controls.Add(this.FirstMassTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1236, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // SecondSpringStiffnessUnitLabel
            // 
            this.SecondSpringStiffnessUnitLabel.AutoSize = true;
            this.SecondSpringStiffnessUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondSpringStiffnessUnitLabel.Location = new System.Drawing.Point(1199, 28);
            this.SecondSpringStiffnessUnitLabel.Name = "SecondSpringStiffnessUnitLabel";
            this.SecondSpringStiffnessUnitLabel.Size = new System.Drawing.Size(33, 16);
            this.SecondSpringStiffnessUnitLabel.TabIndex = 2;
            this.SecondSpringStiffnessUnitLabel.Text = "N/m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(838, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "N/m";
            // 
            // SecondMassUnitLabel
            // 
            this.SecondMassUnitLabel.AutoSize = true;
            this.SecondMassUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondMassUnitLabel.Location = new System.Drawing.Point(486, 29);
            this.SecondMassUnitLabel.Name = "SecondMassUnitLabel";
            this.SecondMassUnitLabel.Size = new System.Drawing.Size(24, 16);
            this.SecondMassUnitLabel.TabIndex = 2;
            this.SecondMassUnitLabel.Text = "Kg";
            // 
            // FirstMassUnit
            // 
            this.FirstMassUnit.AutoSize = true;
            this.FirstMassUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstMassUnit.Location = new System.Drawing.Point(215, 28);
            this.FirstMassUnit.Name = "FirstMassUnit";
            this.FirstMassUnit.Size = new System.Drawing.Size(24, 16);
            this.FirstMassUnit.TabIndex = 2;
            this.FirstMassUnit.Text = "Kg";
            // 
            // SecondSpringStiffnessLabel
            // 
            this.SecondSpringStiffnessLabel.AutoSize = true;
            this.SecondSpringStiffnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondSpringStiffnessLabel.Location = new System.Drawing.Point(898, 26);
            this.SecondSpringStiffnessLabel.Name = "SecondSpringStiffnessLabel";
            this.SecondSpringStiffnessLabel.Size = new System.Drawing.Size(189, 18);
            this.SecondSpringStiffnessLabel.TabIndex = 1;
            this.SecondSpringStiffnessLabel.Text = "Second Spring Stiffness";
            // 
            // FirstSpringStiffnessLabel
            // 
            this.FirstSpringStiffnessLabel.AutoSize = true;
            this.FirstSpringStiffnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSpringStiffnessLabel.Location = new System.Drawing.Point(565, 27);
            this.FirstSpringStiffnessLabel.Name = "FirstSpringStiffnessLabel";
            this.FirstSpringStiffnessLabel.Size = new System.Drawing.Size(161, 18);
            this.FirstSpringStiffnessLabel.TabIndex = 1;
            this.FirstSpringStiffnessLabel.Text = "First Spring Siffness";
            // 
            // SecondMassLabel
            // 
            this.SecondMassLabel.AutoSize = true;
            this.SecondMassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondMassLabel.Location = new System.Drawing.Point(263, 27);
            this.SecondMassLabel.Name = "SecondMassLabel";
            this.SecondMassLabel.Size = new System.Drawing.Size(111, 18);
            this.SecondMassLabel.TabIndex = 1;
            this.SecondMassLabel.Text = "Second Mass";
            // 
            // Mass1Label
            // 
            this.Mass1Label.AutoSize = true;
            this.Mass1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mass1Label.Location = new System.Drawing.Point(15, 27);
            this.Mass1Label.Name = "Mass1Label";
            this.Mass1Label.Size = new System.Drawing.Size(88, 18);
            this.Mass1Label.TabIndex = 1;
            this.Mass1Label.Text = "First Mass";
            // 
            // SecondSpringStiffness
            // 
            this.SecondSpringStiffness.Location = new System.Drawing.Point(1093, 27);
            this.SecondSpringStiffness.Name = "SecondSpringStiffness";
            this.SecondSpringStiffness.Size = new System.Drawing.Size(100, 20);
            this.SecondSpringStiffness.TabIndex = 0;
            // 
            // FirstSpringStiffnessTextBox
            // 
            this.FirstSpringStiffnessTextBox.Location = new System.Drawing.Point(732, 28);
            this.FirstSpringStiffnessTextBox.Name = "FirstSpringStiffnessTextBox";
            this.FirstSpringStiffnessTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstSpringStiffnessTextBox.TabIndex = 0;
            // 
            // SecondMassTextBox
            // 
            this.SecondMassTextBox.Location = new System.Drawing.Point(380, 28);
            this.SecondMassTextBox.Name = "SecondMassTextBox";
            this.SecondMassTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondMassTextBox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1236, 669);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1228, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1228, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PlotButton
            // 
            this.PlotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotButton.Location = new System.Drawing.Point(16, 757);
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.Size = new System.Drawing.Size(84, 29);
            this.PlotButton.TabIndex = 3;
            this.PlotButton.Text = "Plot";
            this.PlotButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1160, 757);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(84, 29);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Body1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1216, 631);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "DisplacementTitle";
            title1.Text = "Displacement";
            this.chart1.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 798);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlotButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstMassTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Mass1Label;
        private System.Windows.Forms.Label SecondSpringStiffnessUnitLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SecondMassUnitLabel;
        private System.Windows.Forms.Label FirstMassUnit;
        private System.Windows.Forms.Label SecondSpringStiffnessLabel;
        private System.Windows.Forms.Label FirstSpringStiffnessLabel;
        private System.Windows.Forms.Label SecondMassLabel;
        private System.Windows.Forms.TextBox SecondSpringStiffness;
        private System.Windows.Forms.TextBox FirstSpringStiffnessTextBox;
        private System.Windows.Forms.TextBox SecondMassTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button PlotButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

