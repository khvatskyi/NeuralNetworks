using System;

namespace Neuron_Learning
{
    class Neuron
    {
        private double teta;

        private const int thDim = 10;
        private const int sDim = 5;
        private const int fDim = 3;

        int[,,] X => new int[thDim, sDim, fDim]
            {
                {
                    {1,1,1},
                    {1,0,1},
                    {1,0,1},
                    {1,0,1},
                    {1,1,1},
                },
                {
                    {0,0,1},
                    {0,0,1},
                    {0,0,1},
                    {0,0,1},
                    {0,0,1},
                },
                {
                    {1,1,1},
                    {0,0,1},
                    {1,1,1},
                    {1,0,0},
                    {1,1,1},
                },
                {
                    {1,1,1},
                    {0,0,1},
                    {1,1,1},
                    {0,0,1},
                    {1,1,1},
                },
                {
                    {1,0,1},
                    {1,0,1},
                    {1,1,1},
                    {0,0,1},
                    {0,0,1},
                },
                {
                    {1,1,1},
                    {1,0,0},
                    {1,1,1},
                    {0,0,1},
                    {1,1,1},
                },
                {
                    {1,1,1},
                    {1,0,0},
                    {1,1,1},
                    {1,0,1},
                    {1,1,1},
                },
                {
                    {1,1,1},
                    {0,0,1},
                    {0,0,1},
                    {0,0,1},
                    {0,0,1},
                },
                {
                    {1,1,1},
                    {1,0,1},
                    {1,1,1},
                    {1,0,1},
                    {1,1,1},
                },
                {
                    {1,1,1},
                    {1,0,1},
                    {1,1,1},
                    {0,0,1},
                    {1,1,1},
                },
            };
        double[,] W { get; set; } = new double[sDim, fDim];

        public Neuron()
        {
            Random random = new Random();
            teta = new Random().Next(300, 500) / (double)100;

            for (int j = 0; j < sDim; j++)
            {
                for (int k = 0; k < fDim; k++)
                {
                    W[j, k] = Math.Round(random.NextDouble(), 2);
                }
            }
        }

        public void Learn()
        {
            for (int i = 0; i < thDim; i++)
            {
                if (i % 2 == 0 && GetY((Numbers)i) == 0)
                {
                    for (int j = 0; j < sDim; j++)
                    {
                        for (int k = 0; k < fDim; k++)
                        {
                            W[j, k] += X[i, j, k];
                        }
                    }
                }
                else if (i % 2 == 1 && GetY((Numbers)i) == 1)
                {
                    for (int j = 0; j < sDim; j++)
                    {
                        for (int k = 0; k < fDim; k++)
                        {
                            W[j, k] -= X[i, j, k];
                        }
                    }
                }
            }
        }

        double GetS(Numbers number)
        {
            double S = 0;

            for (int j = 0; j < sDim; j++)
            {
                for (int k = 0; k < fDim; k++)
                {
                    S += W[j, k] * X[(int)number, j, k];
                }
            }

            return S;
        }

        public int GetY(Numbers number) => GetS(number) >= teta ? 1 : 0;
    }
}
