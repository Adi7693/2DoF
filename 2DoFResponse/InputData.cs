using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Complex;
using MathNet.Numerics.LinearAlgebra.Double;

namespace _2DoF
{
    class InputData
    {

        private bool MassMatrixNeedsToRecalculate;
        private bool StiffnessMatrixNeedsToRecalculate;
        private bool ResponseNeedsToRecalculate;

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
                if (!value.Equals(springStiffness2))
                {
                    springStiffness2 = value;
                    StiffnessMatrixNeedsToRecalculate = true;
                }
            }
        }


        //First Body Initial Displacement

        private double initialConditionX1;

        public double InitialConditionX1
        {
            get
            {
                return initialConditionX1;
            }

            set
            {
                if(!value.Equals(initialConditionX1))
                {
                    initialConditionX1 = value;
                    ResponseNeedsToRecalculate = true;

                }

            }
        }

        //First Body Initial Velocity

        private double initialConditionXDot1;

        public double InitialConditionXDot1
        {
            get
            {
                return initialConditionXDot1;
            }

            set
            {
                if(!value.Equals(initialConditionXDot1))
                {
                    initialConditionXDot1 = value;
                    ResponseNeedsToRecalculate = true;
                }
            }
        }

        //Second Body Initial Displacement

        private double initialConditionX2;

        public double InitialConditionX2
        {
            get
            {
                return initialConditionX2;
            }

            set
            {
                if(!value.Equals(initialConditionX2))
                {
                    initialConditionX2 = value;
                    ResponseNeedsToRecalculate = true;
                }
            }
        }

        //Second Body Initial Velocity

        private double initialConditionXDot2;

        public double InitialConditionXDot2
        {
            get
            {
                return initialConditionXDot2;
            }

            set
            {
                if(!value.Equals(initialConditionXDot2))
                {
                    initialConditionXDot2 = value;
                    ResponseNeedsToRecalculate = true;
                }
            }
        }



        #region TestCode

        //private Matrix<double> massMatrix;

        //public Matrix<double> MassMatrix
        //{
        //    get
        //    {
        //        if (massMatrix == null)
        //        {
        //            massMatrix = Matrix<double>.Build.Dense(2, 2);
        //        }

        //        massMatrix[0, 0] = Mass1;
        //        massMatrix[1, 1] = Mass2;

        //        return massMatrix;
        //    }
        //}

        //private Matrix<double> stiffnessMatrix;

        //public Matrix<double> StiffnessMatrix
        //{
        //    get
        //    {
        //        if (stiffnessMatrix == null)
        //        {
        //            stiffnessMatrix = Matrix<double>.Build.Dense(2, 2);
        //        }

        //        StiffnessMatrix[0, 0] = SpringStiffness1 + SpringStiffness2;
        //        StiffnessMatrix[0, 1] = -SpringStiffness2;
        //        StiffnessMatrix[1, 0] = -SpringStiffness2;
        //        StiffnessMatrix[1, 1] = SpringStiffness2;

        //        return stiffnessMatrix;


        //    }
        //}


        //public Matrix<double> A
        //{
        //    get
        //    {
        //        try
        //        {
        //           return MassMatrix.Inverse() * StiffnessMatrix;
        //        }
        //        catch
        //        {

        //        }

        //        return Matrix<double>.Build.Dense(2, 2);
        //    }
        //}


        //public Vector<Complex> EigenValue
        //{
        //    get
        //    {
        //        try
        //        {
        //            Evd<double> eigen = A.Evd();
        //            Vector<Complex> eigenValue = eigen.EigenValues;
        //            return eigenValue;
        //        }

        //        catch
        //        {

        //        }

        //        return Vector<Complex>.Build.Dense(2);
        //    }
        //}

        //public Matrix<double> EigenVector
        //{
        //    get
        //    {
        //        try
        //        {
        //            Evd<double> eigen = A.Evd();
        //            Matrix<double> eigneVector = eigen.EigenVectors;
        //        }

        //        catch
        //        {

        //        }

        //        return Matrix<double>.Build.Dense(2, 2);
        //    }
        //}
        #endregion

        private Matrix<double> massMatrix;

        public Matrix<double> MassMatrix
        {
            get
            {
                if (MassMatrixNeedsToRecalculate)
                {
                    if (massMatrix == null)
                    {
                        massMatrix = Matrix<double>.Build.Dense(2, 2);
                    }
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
                if (StiffnessMatrixNeedsToRecalculate)
                {
                    if (stiffnessMatrix == null)
                    {
                        stiffnessMatrix = Matrix<double>.Build.Dense(2, 2);
                    }
                }



                stiffnessMatrix[0, 0] = SpringStiffness1 + SpringStiffness2;
                stiffnessMatrix[0, 1] = -SpringStiffness2;
                stiffnessMatrix[1, 0] = -SpringStiffness2;
                stiffnessMatrix[1, 1] = SpringStiffness2;

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


        public Vector<Complex> EigenValue
        {
            get
            {
                try
                {
                    Evd<double> eigen = A.Evd();
                    Vector<Complex> eigenValue = eigen.EigenValues;
                    return Vector<Complex>.Sqrt(eigenValue);
                }

                catch
                {

                }

                return Vector<Complex>.Build.Dense(2);
            }
        }

        public Matrix<double> EigenVector
        {
            get
            {
                try
                {
                    Evd<double> eigen = A.Evd();


                    Matrix<double> eigneVector = eigen.EigenVectors;
                    return eigneVector;
                }

                catch
                {

                }

                return Matrix<double>.Build.Dense(2, 2);
            }
        }


        // a2/a1 at First Natural Frequency


        public double AmplitudeRatio1
        {
            get
            {
                double a11 = EigenVector[0, 0];
                double a21 = EigenVector[1, 0];
                double r1 = a21 / a11;
                double R1 = Math.Round(r1, 4);


                return R1;
            }
        }

        //a2/a1 at Second Natural Frequency
        public double AmplitudeRatio2
        {
            get
            {
                double a12 = EigenVector[0, 1];
                double a22 = EigenVector[1, 1];
                double r2 = a22 / a12;
                double R2 = Math.Round(r2, 4);
                return R2;
            }
        }



        public double NaturalFrequency1
        {
            get
            {
                double w1 = Math.Round(EigenValue[0].Real, 4);
                return w1;
            }
        }


        public double NaturalFrequency2
        {
            get
            {
                double w2 = Math.Round(EigenValue[1].Real, 4);
                return w2;
            }
        }

        public double A1
        {
            get
            {
                double sqrtFirstTerm = Math.Pow((AmplitudeRatio2 * InitialConditionX1) - InitialConditionX2, 2);
                double sqrtSecondTerm = Math.Pow(((AmplitudeRatio2 * InitialConditionXDot1) - InitialConditionXDot2) / NaturalFrequency1, 2);
                double sqrtTerm = Math.Sqrt(sqrtFirstTerm + sqrtSecondTerm);
                double firstTerm = 1 / (AmplitudeRatio2 - AmplitudeRatio1);
                return Math.Round(firstTerm * sqrtTerm, 4);
            }
        }

        public double A2
        {
            get
            {
                double sqrtFirstTerm = Math.Pow(InitialConditionX2 - (AmplitudeRatio1 * InitialConditionX1), 2);
                double sqrtSecondTerm = Math.Pow((InitialConditionXDot1 - (AmplitudeRatio1 * InitialConditionXDot1)) / NaturalFrequency2, 2);
                double sqrtTerm = Math.Sqrt(sqrtFirstTerm + sqrtSecondTerm);
                double firsTerm = 1 / (AmplitudeRatio2 - AmplitudeRatio1);
                return Math.Round(firsTerm * sqrtTerm, 4);
            }
        }

        public double Phy1
        {
            get
            {
                double nume = InitialConditionXDot2 - (AmplitudeRatio2 * InitialConditionXDot1);
                double deno = ((AmplitudeRatio2 * InitialConditionX1) - InitialConditionX2) * NaturalFrequency1;
                return Math.Round(-Math.Atan(nume / deno), 4);
            }
        }

        public double Phy2
        {
            get
            {
                double nume = InitialConditionXDot2 - (AmplitudeRatio1 * InitialConditionXDot1);
                double deno = ((AmplitudeRatio1 * InitialConditionX1) - InitialConditionX2) * NaturalFrequency2;
                return Math.Round(-Math.Atan(nume / deno), 4);
            }
        }

    }
}