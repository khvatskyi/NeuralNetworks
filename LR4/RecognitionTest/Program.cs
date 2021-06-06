using System;
using System.Collections.Generic;
using NeuralNetwork;

namespace RecognitionTest
{
    internal static class Program
    {
        public static void Main()
        {
            Console.Write("Enter speed: ");
            var learnSpeed = Math.Round(double.Parse(Console.ReadLine()), 2);

            Console.Write("Enter number of letter: ");
            var indexOfAlphabet = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine();

            Func<double, double> activationFunc = ActivationFunction.Sigmoid;

            var neuron = new Neuron<double>(activationFunc);
            var learningIterations = AlphabetLearning.Learn(ref neuron, learnSpeed, indexOfAlphabet);

            Console.WriteLine("Number of iterations: {0}\n", learningIterations);

            var numberOfLetters = AlphabetLearning.X.GetLength(0);

            const int rows = 5;

            var results = new double[numberOfLetters];

            for (var i = 0; i < numberOfLetters; i++)
            {
                neuron.Inputs = ArrayExtensions<bool>.FromThreeDimensionsToOne(AlphabetLearning.X, i);
                results[i] = neuron.Output;
            }

            Display("Outputs", rows, results);

            Display("Weights", rows, neuron.Weights);
        }

        private static void Display<T>(string dataName, int rows, IReadOnlyList<T> array)
        {
            Console.WriteLine($"\n=============={dataName}==============" + Environment.NewLine);

            for (var i = 0; i < rows; i++)
            {
                for (var j = i; j < array.Count; j += rows)
                {
                    if (j >= array.Count) break;
                    Console.Write($"{j+1} => {array[j]:N}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
