using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    public class Neuron<TResult> where TResult : struct, IComparable, IConvertible, IComparable<TResult>, IEquatable<TResult>
    {
        private List<Synapse> _synapses;

        private readonly Func<double, TResult> _activationFunc;

        private double S => Synapses.Select(synapse => synapse.InputSignal * synapse.Weight).Sum();

        public TResult Output => _activationFunc(S);

        public List<double> InputSignals
        {
            get
            {
                const int startIndex = 1;
                var result = _synapses.GetRange(startIndex, _synapses.Count - startIndex)
                    .Select(synapse => synapse.InputSignal)
                    .ToList();

                return result;
            }

            set
            {
                if (InputSignals.Count != value.Count)
                {
                    var newSynapses = new List<Synapse>();
                    var random = new Random();

                    value.ForEach(inputSignal =>
                    {
                        newSynapses.Add(new Synapse
                        {
                            InputSignal = inputSignal,
                            Weight = random.NextDouble()
                        });
                    });

                    Synapses = newSynapses;
                }
                else
                {
                    for (var i = 1; i < Synapses.Count; i++)
                    {
                        Synapses[i].InputSignal = value[i-1];
                    }
                }
            }
        }

        public List<double> Weights => Synapses.Select(synapse => synapse.Weight).ToList();

        public List<Synapse> Synapses
        {
            get => _synapses;

            private set
            {
                var biasSynapse = _synapses?[0] ?? new Synapse
                {
                    InputSignal = 1,
                    Weight = new Random().NextDouble()
                };

                _synapses = new List<Synapse>
                {
                    biasSynapse
                };

                _synapses.AddRange(value);
            }
        }

        public Neuron(Func<double, TResult> activationFunc)
            : this(0, activationFunc)
        {
        }

        public Neuron(uint numberOfSynapses, Func<double, TResult> activationFunc)
        {
            _activationFunc = activationFunc;
            Synapses = new List<Synapse>();

            var random = new Random();
            for (var i = 0; i < numberOfSynapses; i++)
            {
                Synapses.Add(new Synapse
                {
                    InputSignal = new double(),
                    Weight = random.NextDouble()
                });
            }
        }
    }
}
