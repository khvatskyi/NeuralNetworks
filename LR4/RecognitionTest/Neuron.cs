using System;
using System.Linq;

namespace RecognitionTest
{
    public class Neuron<TResult> where TResult : struct, IComparable, IConvertible, IComparable<TResult>, IEquatable<TResult>
    {
        private bool[] _inputs;

        private readonly Func<double, TResult> _activationFunc;

        private double S => Inputs.Select((x, index) => (x ? 1 : 0) * Weights[index]).Sum();

        public TResult Output => _activationFunc(S);

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

        public Neuron(Func<double, TResult> activationFunc)
            : this(0, activationFunc)
        {
        }

        private Neuron(uint numberOfSynapses, Func<double, TResult> activationFunc)
        {
            _activationFunc = activationFunc;
            Weights = new double[numberOfSynapses];
            Inputs = new bool[numberOfSynapses];
        }

        private void FillWeights()
        {
            var rand = new Random();

            Weights = new double[Inputs.Length];

            for (var i = 0; i < Weights.Length; i++)
            {
                Weights[i] = Math.Round(rand.NextDouble(), 2);
            }
        }
    }
}
