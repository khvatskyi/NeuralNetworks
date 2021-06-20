using System;
using System.Collections.Generic;

namespace NeuralNetwork
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

        public List<Neuron<TResult>> Neurons { get; }

        public List<TResult> Outputs
        {
            get
            {
                var outputs = new List<TResult>();
                Neurons.ForEach(neuron => outputs.Add(neuron.Output));

                return outputs;
            }
        }

        public Neuron<TResult> this[int i] => Neurons[i];
    }
}
