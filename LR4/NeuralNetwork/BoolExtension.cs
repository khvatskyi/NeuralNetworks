namespace NeuralNetwork
{
    public static class BoolExtension
    {
        public static int ConvertToInt(this bool element)
        {
            return element ? 1 : 0;
        }

        public static double ConvertToDouble(this bool element)
        {
            return element ? 1 : 0;
        }
    }
}
