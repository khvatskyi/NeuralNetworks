namespace NeuronLearning
{
    public static class BoolExtension
    {
        public static int ConvertToInt(this bool element)
        {
            return element ? 1 : 0;
        }
    }
}
