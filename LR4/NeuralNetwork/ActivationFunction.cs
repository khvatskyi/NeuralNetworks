using System;

namespace NeuralNetwork
{
    public static class ActivationFunction
    {
        public static double HyperbolicTangent(double x)
        {
            var ePow2X = Math.Pow(Math.E, 2 * x);

            return (ePow2X - 1) / (ePow2X + 1);
        }

        public static double MoreThanZero(double x)
        {
            return x > 0 ? 1 : 0;
        }

        public static double Sigmoid(double x)
        {
            var ePowMinusX = Math.Pow(Math.E, -x);

            return 1 / (1 + ePowMinusX);
        }
    }
}
