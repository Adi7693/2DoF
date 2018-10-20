using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Complex;

namespace _2DoF
{
    class InputData
    {

        private bool MassMatrixNeedsToRecalculate;
        private bool StiffnessMatrixNeedsToRecalculate;

        public InputData()
        {
            Mass1 = 0.0;
            Mass2 = 0.0;
            SpringStiffness1 = 0.0;
            SpringStiffness2 = 0.0;


            MassMatrixNeedsToRecalculate = false;
            StiffnessMatrixNeedsToRecalculate = false;
        }

        private double mass1;

        public double Mass1
        {
            get
            {
                return mass1;
            }

            set
            {
                if (!value.Equals(mass1))
                {
                    mass1 = value;


                    MassMatrix[0, 0] = mass1;
                    MassMatrixNeedsToRecalculate = true;

                }
            }
        }

        private double mass2;

        public double Mass2
        {
            get
            {
                return mass2;
            }

            set
            {
                if (!value.Equals(mass2))
                {
                    mass2 = value;


                    MassMatrix[1, 1] = mass2;
                    MassMatrixNeedsToRecalculate = true;
                }
            }
        }

        private double springStiffness1;

        public double SpringStiffness1
        {
            get
            {
                return springStiffness1;
            }

            set
            {
                if (!value.Equals(springStiffness1))
                {
                    springStiffness1 = value;
                    StiffnessMatrixNeedsToRecalculate = true;



                }
            }
        }

        private double springStiffness2;

        public double SpringStiffness2
        {
            get
            {
                return springStiffness2;
            }

            set
            {
                springStiffness2 = value;
                StiffnessMatrixNeedsToRecalculate = true;
            }
        }




        private Matrix<double> massMatrix;

        public Matrix<double> MassMatrix
        {
            get
            {
                if (massMatrix == null)
                {
                    massMatrix = Matrix<double>.Build.Dense(2, 2);
                }

                massMatrix[0, 0] = Mass1;
                massMatrix[1, 1] = Mass2;

                return massMatrix;
            }
        }

        private Matrix<double> stiffnessMatrix;

        public Matrix<double> StiffnessMatrix
        {
            get
            {
                if (stiffnessMatrix == null)
                {
                    stiffnessMatrix = Matrix<double>.Build.Dense(2, 2);
                }

                StiffnessMatrix[0, 0] = SpringStiffness1 + SpringStiffness2;
                StiffnessMatrix[0, 1] = -SpringStiffness2;
                StiffnessMatrix[1, 0] = -SpringStiffness2;
                StiffnessMatrix[1, 1] = SpringStiffness2;

                return stiffnessMatrix;


            }
        }


        public Matrix<double> A
        {
            get
            {
                try
                {
                   return MassMatrix.Inverse() * StiffnessMatrix;
                }
                catch
                {

                }

                return Matrix<double>.Build.Dense(2, 2);
            }
        }

    }
}