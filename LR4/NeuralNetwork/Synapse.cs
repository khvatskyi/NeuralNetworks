namespace NeuralNetwork
{
    public class Synapse
    {
        private double _weight;

        private double _inputSignal;

        public double InputSignal
        {
            get => _inputSignal;

            set => _inputSignal = value switch
            {
                > 1 => 1,
                < 0 => 0,
                _ => value
            };
        }

        public double Weight
        {
            get => _weight;

            set => _weight = value switch
            {
                > 1 => 1,
                < -1 => -1,
                _ => value
            };
        }
    }
}
