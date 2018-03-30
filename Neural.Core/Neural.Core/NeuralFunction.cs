using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural.Core
{
    public abstract class NeuralFunction
    {
        public abstract double Derivative(double value);
        public abstract double Process(double value);
    }

    public class Linear : NeuralFunction
    {
        public override double Derivative(double value)
        {
            return 0;
        }

        public override double Process(double value)
        {
            return value;
        }
    }

    public class Sigmoid : NeuralFunction
    {
        public override double Derivative(double value)
        {
            return Process(value) * (1 - Process(value));
        }

        public override double Process(double value)
        {
            return (1 / (1 + Math.Exp(-value)));
        }
    }
}
