using System;
using System.Linq;

namespace RecognitionTest
{
    public class Neuron
    {
        private bool[] _inputs;

        public bool Output => Inputs.Select((x, index) => (x ? 1 : 0) * Weights[index]).Sum() > 0;

        public bool[] Inputs
        {
            get => _inputs;
            set
            {
                _inputs = new bool[value.Length + 1];
                value.CopyTo(_inputs, 1);
                _inputs[0] = true;

                if (!_inputs.Length.Equals(Weights.Length))
                {
                    FillWeights();
                }
            }
        }

        public double[] Weights { get; private set; }

        public Neuron()
            :this(0)
        {
        }

        private Neuron(uint numberOfInputs)
        {
            Weights = new double[numberOfInputs];
            Inputs = new bool[numberOfInputs];
        }

        private void FillWeights()
        {
            var rand = new Random();

            Weights = new double[Inputs.Length];

            for (var i = 0; i < Weights.Length; i++)
            {
                Weights[i] = rand.NextDouble();
            }
        }
    }
}
