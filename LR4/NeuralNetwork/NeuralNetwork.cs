using System;
using System.Collections.Generic;

namespace NeuralNetwork
{
    public class NeuralNetwork<TResult> where TResult : struct, IComparable, IConvertible, IComparable<TResult>, IEquatable<TResult>
    {
        public NeuralNetwork(List<NeuralLayer<TResult>> layers)
        {
            Layers = layers;
        }

        public NeuralLayer<TResult> OutputLayer => Layers[^1];

        public NeuralLayer<TResult> InputLayer => Layers[0];

        public List<NeuralLayer<TResult>> HiddenLayers => Layers.GetRange(1, Layers.Count - 2);

        private List<NeuralLayer<TResult>> Layers { get; }
    }
}
