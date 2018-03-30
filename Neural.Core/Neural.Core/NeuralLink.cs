using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural.Core
{
    public class NeuralLink
    {
        public NeuralLink(Neuron start, Neuron end, double weight)
        {

        }

        protected Neuron StartNeuron { get; set; }
        protected Neuron EndNeuron { get; set; }

        public double Weigth { get; set; }
        public double Signal { get; set; }
    }

    
}
