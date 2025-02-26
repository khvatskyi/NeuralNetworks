using System;
using System.Linq;
using NeuralNetwork;

namespace RecognitionTest
{
    public static class AlphabetLearning
    {
        public static bool[,,] X { get; } = {
            {
                {false, false, true, false, false},
                {false, true, false, true, false},
                {true, true, true, true, true},
                {false, true, false, true, false},
                {true, false, false, false, true},
            },
            {
                {true, true, true, true, true},
                {true, false, false, false, false},
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
            },
            {
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
            },
            {
                {true, true, true, true, true},
                {true, false, false, false, false},
                {true, false, false, false, false},
                {true, false, false, false, false},
                {true, false, false, false, false},
            },
            {
                {true, true, true, false, true},
                {true, false, false, true, false},
                {true, false, false, false, false},
                {true, false, false, false, false},
                {true, false, false, false, false},
            },
            {
                {false, true, true, true, false},
                {false, true, false, true, false},
                {false, true, false, true, false},
                {true, true, true, true, true},
                {true, false, false, false, true},
            },
            {
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
                {true, false, false, false, false},
                {true, true, true, true, true},
            },
            {
                {true, true, true, true, true},
                {true, false, false, false, false},
                {true, true, true, true, true},
                {true, false, false, false, false},
                {true, true, true, true, true},
            },
            {
                {true, false, true, false, true},
                {false, true, true, true, false},
                {false, false, true, false, false},
                {false, true, true, true, false},
                {true, false, true, false, true},
            },
            {
                {false, false, true, true, true},
                {false, false, false, false, true},
                {false, false, true, true, true},
                {false, false, false, false, true},
                {false, false, true, true, true},
            },
            {
                {true, false, false, false, true},
                {true, false, false, true, true},
                {true, false, true, false, true},
                {true, true, false, false, true},
                {true, false, false, false, true},
            },
            {
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
            },
            {
                {false, true, false, true, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
            },
            {
                {true, false, true, false, true},
                {true, false, false, true, true},
                {true, false, true, false, true},
                {true, true, false, false, true},
                {true, false, false, false, true},
            },
            {
                {true, false, false, false, true},
                {true, false, true, true, false},
                {true, true, false, false, false},
                {true, false, true, true, false},
                {true, false, false, false, true},
            },
            {
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, true, false, true, false},
                {false, true, false, true, false},
                {true, false, false, false, true},
            },
            {
                {true, false, false, false, true},
                {true, true, false, true, true},
                {true, true, true, true, true},
                {true, false, true, false, true},
                {true, false, true, false, true},
            },
            {
                {true, false, false, false, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, false, false, false, true},
            },
            {
                {false, true, true, true, false},
                {true, false, false, false, true},
                {true, false, false, false, true},
                {true, false, false, false, true},
                {false, true, true, true, false},
            },
            {
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, false, false, false, true},
                {true, false, false, false, true},
                {true, false, false, false, true},
            },
            {
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
                {true, false, false, false, false},
                {true, false, false, false, false},
            },
            {
                {false, true, true, true, true},
                {true, false, false, false, false},
                {true, false, false, false, false},
                {true, false, false, false, false},
                {false, true, true, true, true},
            },
            {
                {true, true, true, true, true},
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
                {false, false, true, false, false},
            },
            {
                {true, false, false, false, true},
                {true, false, false, false, true},
                {false, true, true, true, true},
                {false, false, false, false, true},
                {true, true, true, true, true},
            },
            {
                {false, true, true, true, false},
                {true, false, true, false, true},
                {true, false, true, false, true},
                {true, false, true, false, true},
                {false, true, true, true, false},
            },
            {
                {true, false, false, false, true},
                {false, true, false, true, false},
                {false, false, true, false, false},
                {false, true, false, true, false},
                {true, false, false, false, true},
            },
            {
                {true, false, false, true, false},
                {true, false, false, true, false},
                {true, false, true, true, false},
                {true, true, false, true, false},
                {true, false, false, true, true},
            },
            {
                {true, false, false, false, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
                {false, false, false, false, true},
                {false, false, false, false, true},
            },
            {
                {true, false, true, false, true},
                {true, false, true, false, true},
                {true, false, true, false, true},
                {true, false, true, false, true},
                {true, true, true, true, true},
            },
            {
                {true, false, true, false, true},
                {true, false, true, false, true},
                {true, false, true, false, true},
                {true, false, true, true, false},
                {true, true, true, true, true},
            },
            {
                {true, false, false, false, false},
                {true, true, true, true, true},
                {true, false, false, false, true},
                {true, false, false, false, true},
                {true, true, true, true, true},
            },
            {
                {true, false, false, true, false},
                {true, false, true, false, true},
                {true, true, true, false, true},
                {true, false, true, false, true},
                {true, false, false, true, false},
            },
            {
                {false, false, false, true, false},
                {false, false, true, false, true},
                {false, false, false, true, true},
                {false, false, true, false, true},
                {true, true, false, false, true},
            },
        };

        public static int Learn(ref Neuron<double> neuron, double speed, int wordIndex, int maxEpoch = 7)
        {
            for(var i = 0; i < maxEpoch; i++)
            {
                for (var j = 0; j < X.GetLength(0); j++)
                {
                    var inputs = ArrayExtensions<bool>.FromThreeDimensionsToOne(X, j)
                        .Select(BoolExtension.ConvertToDouble)
                        .ToList();

                    neuron.InputSignals = inputs;

                    var d = j.Equals(wordIndex).ConvertToInt();

                    var neuralError = GetNeuralError(d, neuron.Output);

                    while (Math.Abs(d - neuron.Output) > 0.10)
                    {
                        foreach (var synapse in neuron.Synapses)
                        {
                            var deltaW = speed * neuralError * synapse.InputSignal;
                            synapse.Weight += deltaW;
                        }

                        neuralError = GetNeuralError(d, neuron.Output);
                    }
                }
            }

            return maxEpoch;
        }

        private static double GetNeuralError(double d, double output)
        {
            var result = output * (1 - output) * (d - output);
            return result;
        }
    }
}
