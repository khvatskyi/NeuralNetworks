using System;
using System.Collections.Generic;

namespace RecognitionTest
{
    public class NeuralLayer<TResult> where TResult : struct, IComparable, IConvertible, IComparable<TResult>, IEquatable<TResult>
    {
        public NeuralLayer()
            :this(new List<Neuron<TResult>>())
        {
        }

        public NeuralLayer(List<Neuron<TResult>> neurons)
        {
            Neurons = neurons;
        }

        private List<Neuron<TResult>> Neurons { get; }

        public Neuron<TResult> this[int i] => Neurons[i];
    }
}
