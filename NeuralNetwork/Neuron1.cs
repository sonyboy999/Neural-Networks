using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Neuron1
    {
        public List<double> Weights { get; }
        public TypeNeuron NeuronType { get; }
        public double Output { get; private set; }
        public Neuron1(int inputCount, TypeNeuron type = TypeNeuron.Normal) 
        {
            NeuronType = type;
            Weights = new List<double>();
            for (int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }

        }



        //Работа с сумматором
        public double FeedForward (List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }

            Output = Sigmoid(sum);
            return Output;
        }

        //Передаем результат сигмоиду
        private double Sigmoid (double x)
        {
            var result = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return result;
        }

        public override string ToString()
        {
            return Output.ToString();
        }
    }
}
