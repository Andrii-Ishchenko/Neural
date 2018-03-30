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

            Inputs = new List<NeuralLink>();
            Outputs = new List<NeuralLink>();
        }

        public List<NeuralLink> Inputs { get; private set; }
        public List<NeuralLink> Outputs { get; private set; }

        public NeuralFunction NetworkFunction { get; private set; }

        protected double SumOfCharges { get; private set; }

        public void ResetSumOfCharges()
        {
            SumOfCharges = 0.0;
        }

        public double Process(double value)
        {
            return NetworkFunction.Process(value);
        }

        public void Input(double value)
        {
            SumOfCharges += value;
        }

        public void SetInputLink(NeuralLink link)
        {
            Inputs.Add(link);
        }

        public void SetOutputLink(NeuralLink link)
        {
            Outputs.Add(link);
        }

        public double Fire()
        {
            foreach(var link in Inputs)
            {
                var linkedNeuron = link.LinkedNeuron;

                var weight = link.Weigth;
                var charge = SumOfCharges;
                var Xi = Process(charge);
                var output = Xi * weight;

                link.Signal = Xi;
                linkedNeuron.Input(output);
            }

            return SumOfCharges;
        }     
    }

    public class OutputNeuronDecorator : Neuron
    {
        public OutputNeuronDecorator(NeuralFunction networkFunction) : base(networkFunction)
        {
        }
    }

    public class HiddenNeuronDecorator : Neuron
    {
        public HiddenNeuronDecorator(NeuralFunction networkFunction) : base(networkFunction)
        {
        }
    }
}
