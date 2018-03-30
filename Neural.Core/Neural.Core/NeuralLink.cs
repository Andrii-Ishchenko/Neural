using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural.Core
{
    public class NeuralLink
    {
        public NeuralLink(Neuron linkedTo, double weight)
        {
            LinkedNeuron = linkedTo;
            Weigth = weight;
        }

        public Neuron LinkedNeuron { get; set; }

        public double Weigth { get; set; }
        public double Signal { get; set; }
    }

   
}
