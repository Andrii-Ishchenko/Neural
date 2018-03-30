using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural.Core
{
    public class Neuron
    {
        public Neuron(NeuralFunction networkFunction)
        {
            ResetSumOfCharges();
            NetworkFunction = networkFunction;
        }

        public List<NeuralLink> Inputs { get; set; }
        public List<NeuralLink> Outputs { get; set; }

        public NeuralFunction NetworkFunction { get; private set; }

        protected double SumOfCharges { get; private set; }

        public void ResetSumOfCharges() { SumOfCharges = 0.0; }

        public double Process()
        {
            return Process(SumOfCharges);
        }

        public double Process(double value)
        {
            return NetworkFunction.Process(value);
        }

       
    }

    public class OutputNeuronDecorator : Neuron
    {

    }

    public class HiddenNeuronDecorator : Neuron
    {

    }
}
