using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1NewtonPolyn
{
    /// <summary>
    /// Provides a Newton's polygon
    /// </summary>
    class NewtonPol : IFunction
    {
        /// <summary>A table function</summary>
        private FunctionsTable _table;

        /// <summary>Devided differences</summary>
        private double[] _devidedDif;

        /// <summary>
        /// A constructor
        /// </summary>
        /// <param name="table">
        /// A table function, on which a polynom will be created
        /// </param>
        public NewtonPol(FunctionsTable table)
        {
            _table = table;
            this._devidedDif = new double[table.Length];
            for (int i = 0; i < table.Length; ++i)
            {
                this._devidedDif[i] = this.GetDevidedDiff(table, i); 
            }
        }

        /// <summary>
        /// Perfroms a devided difference
        /// </summary>
        /// <param name="table">A table function</param>
        /// <param name="power">A power of the difference</param>
        /// <returns></returns>
        protected double GetDevidedDiff(FunctionsTable table, int power)
        {
            if (table.Length <= power)
                throw new Exception("The power is more then number of nodes");
            double result = 0;
            for (int i = 0; i <= power; ++i)
            {
                double mult = 1;
                for (int j = 0; j <= power; ++j)
                {
                    if (i != j)
                        mult *= (table.X[i] - table.X[j]);
                }
                result += table.Y[i] / mult;
            }
            return result;
        }

        /// <summary>Override</summary>
        public double Caclulate(double arg)
        {
            double result = 0;
            for (int i = 0; i < this._devidedDif.Length; ++i)
            {
                double slag = this._devidedDif[i];
                for (int j = 0; j < i; ++j)
                {
                    slag *= (arg - _table.X[j]);
                }
                result += slag;
            }
            return result;
        }
    }
}
