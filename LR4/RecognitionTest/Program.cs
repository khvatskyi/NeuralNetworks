using System;
using System.Collections.Generic;
using System.Linq;
using NeuralNetwork;

namespace RecognitionTest
{
    internal static class Program
    {
        public static void Main()
        {
            Console.Write("Enter speed: ");
            var learnSpeed = Math.Round(double.Parse(Console.ReadLine() ?? "0.1"), 2);

            Console.Write("Enter number of letter: ");
            var indexOfAlphabet = int.Parse(Console.ReadLine() ?? "1") - 1;
            Console.WriteLine();

            Func<double, double> activationFunc = ActivationFunction.Sigmoid;

            var neuron = new Neuron<double>(activationFunc);
            var epochs = AlphabetLearning.Learn(ref neuron, learnSpeed, indexOfAlphabet);

            Console.WriteLine("Number of epochs: {0}\n", epochs);

            var numberOfLetters = AlphabetLearning.X.GetLength(0);

            const int rows = 5;

            var results = new double[numberOfLetters];

            for (var i = 0; i < numberOfLetters; i++)
            {
                neuron.InputSignals = ArrayExtensions<bool>.FromThreeDimensionsToOne(AlphabetLearning.X, i)
                    .Select(BoolExtension.ConvertToDouble)
                    .ToList();

                results[i] = neuron.Output;
            }

            Display("Outputs", rows, results, 1);

            Display("Weights", rows, neuron.Weights);
        }

        private static void Display<T>(string dataName, int rows, IReadOnlyList<T> array, int indexStartsWith = 0)
        {
            Console.WriteLine($"\n=============={dataName}==============" + Environment.NewLine);

            for (var i = 0; i < rows; i++)
            {
                for (var j = i; j < array.Count; j += rows)
                {
                    if (j >= array.Count) break;
                    Console.Write($"{j + indexStartsWith} => {array[j]:N}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
