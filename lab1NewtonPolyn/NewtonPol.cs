using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1NewtonPolyn
{
    class NewtonPol : IFunction
    {
        private double[] _nodes;
        private IFunction _func;
        private double[] _devidedDif;

        public NewtonPol(double[] nodes, IFunction func)
        {
            this._nodes = nodes;
            this._func = func;
            this._devidedDif = new double[nodes.Length];
            for (int i = 0; i < nodes.Length; ++i)
            {
                this._devidedDif[i] = this.GetDevidedDiff(nodes, i); 
            }
        }

        protected double GetDevidedDiff(double[] nodes, int power)
        {
            if (nodes.Length <= power)
                throw new Exception("The power is more then number of nodes");
            double result = 0;
            for (int i = 0; i <= power; ++i)
            {
                double mult = 1;
                for (int j = 0; j <= power; ++j)
                {
                    if (i != j)
                        mult *= (nodes[i] - nodes[j]);
                }
                result += this._func.Caclulate(nodes[i]) / mult;
            }
            return result;
        }

        public double Caclulate(double arg)
        {
            double result = 0;
            for (int i = 0; i < this._devidedDif.Length; ++i)
            {
                double slag = this._devidedDif[i];
                for (int j = 0; j < i; ++j)
                {
                    slag *= (arg - this._nodes[j]);
                }
                result += slag;
            }
            return result;
        }
    }
}
