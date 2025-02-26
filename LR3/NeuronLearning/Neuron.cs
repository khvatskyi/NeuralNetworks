using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace NeuronLearning
{
    public class Neuron
    {
        private bool[] _x;

        public bool Y
        {
            get
            {
                var numbers = X.Select((x, index) => (x ? 1 : 0) * W[index]);
                var sum = numbers.Sum();

                return sum > 0;
            }
        }

        public bool[] X
        {
            get => _x;
            set
            {
                _x = new bool[value.Length + 1];
                value.CopyTo(_x, 1);
                _x[0] = true;

                if (!_x.Length.Equals(W.Length))
                {
                    FillWArray();
                }
            }
        }
        public double[] W { get; private set; }

        public Neuron()
            :this(0)
        {
        }

        private Neuron(uint numberOfInputs)
        {
            W = new double[numberOfInputs];
            X = new bool[numberOfInputs];
        }

        private void FillWArray()
        {
            var rand = new Random();

            W = new double[X.Length];

            for (var i = 0; i < W.Length - 1; i++)
            {
                W[i] = Math.Round(rand.NextDouble(), 2);
            }
        }
    }
}
