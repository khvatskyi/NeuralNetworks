namespace NeuronLearning
{
    public class AlphabetLearning
    {
        private const int ThDim = 33;
        private const int SDim = 5;
        private const int FDim = 5;
        private readonly double _speed;

        public static bool[,,] X { get; } = new bool[ThDim, SDim, FDim]
        {
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

        public AlphabetLearning(double speed)
        {
            _speed = speed;
        }

        public int Learn(ref Neuron neuron, int wordIndex)
        {
            bool wasCorrected;

            var learningIterations = 0;

            do
            {
                wasCorrected = false;
                
                for (var i = 0; i < X.GetLength(0); i++)
                {
                    neuron.X = ArrayExtensions<bool>.FromThreeDimensionsToOne(X, i); 

                    var d = i.Equals(wordIndex).ConvertToInt();
                    var y = neuron.Y.ConvertToInt();

                    var eps = GetEpsilon(d, y);

                    while (eps != 0)
                    {
                        if (!wasCorrected)
                        {
                            wasCorrected = true;
                        }

                        for (var j = 0; j < neuron.W.Length; j++)
                        {
                            var deltaW = _speed * eps * neuron.X[j].ConvertToInt();
                            neuron.W[j] += deltaW;
                        }

                        eps = GetEpsilon(d, neuron.Y.ConvertToInt());
                    }
                }

                learningIterations++;

            } while (wasCorrected);

            return learningIterations;
        }

        private static int GetEpsilon(int d, int y)
        {
            return d - y;
        }
    }
}
