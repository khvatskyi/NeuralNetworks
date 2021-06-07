namespace NeuralNetwork
{
    public class Synapse
    {
        private double _weight;

        private double _inputSignal;

        public double InputSignal
        {
            get => _inputSignal;

            set => _inputSignal = value > 1
                ? 1
                : value < 0
                    ? 0
                    : value;
        }

        public double Weight
        {
            get => _weight;

            set => _weight = value > 1
                ? 1
                : value < -1
                    ? -1
                    : value;
        }
    }
}
