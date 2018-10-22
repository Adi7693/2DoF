using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DoF
{
    public partial class Form1 : Form
    {

        private bool needsToCalculate;

        public Form1()
        {
            InitializeComponent();
        }

        //public bool NeedsToCalculate
        //{
        //    get
        //    {
        //        return needsToCalculate;
        //    }

        //    set
        //    {
        //        if(!value.Equals(needsToCalculate))
        //        {
        //            needsToCalculate = value;
        //            CalculateButton.Enabled =! needsToCalculate;
        //        }
        //    }
        //}


        private InputData data = null;

        public InputData InputData
        {
            get
            {
                if (data==null)
                {
                    data = new InputData();
                }

                return data;
            }

            private set
            {
                if(!value.Equals(data))
                {
                    data = value;

                    //NeedsToCalculate = true;
                }

            }
        }

        private void StartTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newStartTime = 0.0;

            if(double.TryParse(StartTimeTextBox.Text, out newStartTime))
            {
                InputData.StartTime = newStartTime;
                //NeedsToCalculate = true;
            }
        }

        private void EndTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newEndTime = 0.0;

            if(double.TryParse(EndTimeTextBox.Text,out newEndTime))
            {
                InputData.EndTime = newEndTime;
                //NeedsToCalculate = true;
            }
        }

        private void TimeStepTextBox_TextChanged(object sender, EventArgs e)
        {
            double newTimeStep = 0.0;

            if(double.TryParse(TimeStepTextBox.Text,out newTimeStep))
            {
                InputData.TimeStep = newTimeStep;
                //NeedsToCalculate = true;
            }
        }

        private void FirstMassTextBox_TextChanged(object sender, EventArgs e)
        {
            double newFirstMass = 0.0;

            if(double.TryParse(FirstMassTextBox.Text, out newFirstMass))
            {
                InputData.Mass1 = newFirstMass;
                //NeedsToCalculate = true;
            }
        }

        private void SecondMassTextBox_TextChanged(object sender, EventArgs e)
        {
            double newSecondMass = 0.0;
            
            if(double.TryParse(SecondMassTextBox.Text,out newSecondMass))
            {
                InputData.Mass2 = newSecondMass;
                //NeedsToCalculate = true;
            }

        }

        private void FirstSpringStiffnessTextBox_TextChanged(object sender, EventArgs e)
        {
            double newFirstSpringStiffness = 0.0;

            if(double.TryParse(FirstSpringStiffnessTextBox.Text,out newFirstSpringStiffness))
            {
                InputData.SpringStiffness1 = newFirstSpringStiffness;
                //NeedsToCalculate = true;
            }
        }

        private void SecondSpringStiffness_TextChanged(object sender, EventArgs e)
        {
            double newSecondSpringStiffness = 0.0;

            if(double.TryParse(SecondSpringStiffnessTextBox.Text,out newSecondSpringStiffness))
            {
                InputData.SpringStiffness2 = newSecondSpringStiffness;
                //NeedsToCalculate = true;
            }
        }

        private void ICDisplacement1TextBox_TextChanged(object sender, EventArgs e)
        {
            double newDisplacement1 = 0.0;

            if (double.TryParse(ICDisplacement1TextBox.Text, out newDisplacement1))
            {
                InputData.InitialConditionX1 = newDisplacement1;
                //NeedsToCalculate = true;
            }
        }

        private void ICVelocity1TextBox_TextChanged(object sender, EventArgs e)
        {
            double newVelocity1 = 0.0;

            if (double.TryParse(ICVelocity1TextBox.Text,out newVelocity1))
            {
                InputData.InitialConditionXDot1 = newVelocity1;
                //NeedsToCalculate = true;
            }
        }

        private void ICDisplacement2TextBox_TextChanged(object sender, EventArgs e)
        {
            double newDisplacement2 = 0.0;

            if (double.TryParse(ICDisplacement2TextBox.Text,out newDisplacement2))
            {
                InputData.InitialConditionX2 = newDisplacement2;
                //NeedsToCalculate = true;
            }
        }

        private void ICVelocity2TextBox_TextChanged(object sender, EventArgs e)
        {
            double newVelocity2 = 0.0;

            if(double.TryParse(ICVelocity2TextBox.Text,out newVelocity2))
            {
                InputData.InitialConditionXDot2 = newVelocity2;
                //NeedsToCalculate = false;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            InputData.Calculate();

            DataTable Body1Displacement = new DataTable("Body 1 vs Time");
            Body1Displacement.Columns.Add("Time", typeof(double));
            Body1Displacement.Columns.Add("Body 1", typeof(double));
            //Body1Displacement.Columns.Add("Body 2", typeof(double));

            for (int i = 0; i < InputData.TimeIntervals.Count; i++)
            {
                Body1Displacement.Rows.Add(InputData.TimeIntervals[i], InputData.Body1Displacement[i]);

            }

            DataTable Body2Displacement = new DataTable("Body 2 vs Time");
            Body2Displacement.Columns.Add("Time", typeof(double));
            Body2Displacement.Columns.Add("Body 2", typeof(double));

            for (int i = 0; i < InputData.TimeIntervals.Count; i++)
            {
                Body2Displacement.Rows.Add(InputData.TimeIntervals[i], InputData.Body2Displacement[i]);
            }


            chart1.ChartAreas["Body 1"].AxisX.Minimum = 0.0;
            chart1.ChartAreas["Body 1"].AxisX.MajorGrid.Interval = 1.0;
            chart1.Series["Body 1"].XValueMember = "Time";
            chart1.Series["Body 1"].YValueMembers = "Body 1";
            chart1.DataSource = Body1Displacement;
            chart1.DataBind();
            chart1.Update();


            chart2.ChartAreas["Body 2"].AxisX.Minimum = 0.0;
            chart2.ChartAreas["Body 2"].AxisX.MajorGrid.Interval = 1.0;
            chart2.Series["Body 2"].XValueMember = "Time";
            chart2.Series["Body 2"].YValueMembers = "Body 2";
            chart2.DataSource = Body2Displacement;
            chart2.DataBind();
            chart2.Update();

        }
    }
}
