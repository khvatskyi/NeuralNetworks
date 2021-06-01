using System;
using System.Collections.Generic;

namespace NeuronLearning
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

            var neuron = new Neuron();
            var alphabetLearning = new AlphabetLearning(learnSpeed);
            var learningIterations = alphabetLearning.Learn(ref neuron, indexOfAlphabet);
            
            Console.WriteLine("Number of iterations: {0}\n", learningIterations);
            Console.WriteLine("==============Results==============" + Environment.NewLine);

            var numberOfLetters = AlphabetLearning.X.GetLength(0);

            const int rows = 5;

            var results = new bool[numberOfLetters];

            for (var i = 0; i < numberOfLetters; i++)
            {
                neuron.X = ArrayExtensions<bool>.FromThreeDimensionsToOne(AlphabetLearning.X, i);
                results[i] = neuron.Y;
            }

            Display(rows, results);

            Console.WriteLine("\n==============Weights==============" + Environment.NewLine);

            Display(rows, neuron.W);
        }

        private static void Display<T>(int rows, IReadOnlyList<T> array)
        {
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
