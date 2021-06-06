using System;
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
                {false, true, true, true, false},
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

        public static int Learn(ref Neuron<double> neuron, double speed, int wordIndex)
        {
            bool wasCorrected;
            var learningIterations = 0;

            do
            {
                wasCorrected = false;

                for (var i = 0; i < X.GetLength(0); i++)
                {
                    neuron.Inputs = ArrayExtensions<bool>.FromThreeDimensionsToOne(X, i); 

                    var d = i.Equals(wordIndex).ConvertToInt();

                    var neuralError = GetNeuralError(d, neuron.Output);

                    while (neuralError is > 0.15 or < 0)
                    {
                        if (!wasCorrected)
                        {
                            wasCorrected = true;
                        }

                        for (var j = 0; j < neuron.Weights.Length; j++)
                        {
                            var deltaW = Math.Round(speed * neuralError * neuron.Inputs[j].ConvertToInt(), 2);
                            neuron.Weights[j] += deltaW;
                        }

                        neuralError = GetNeuralError(d, neuron.Output);
                    }
                }

                learningIterations++;

            } while (wasCorrected);

            return learningIterations;
        }

        private static double GetNeuralError(double d, double output)
        {
            return output * (1 - output) * (d - output);
        }
    }
}
