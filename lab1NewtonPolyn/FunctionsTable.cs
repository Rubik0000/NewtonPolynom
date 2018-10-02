using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1NewtonPolyn
{
    /// <summary>
    /// Provides a function set in table form
    /// </summary>
    class FunctionsTable
    {
        /// <summary>
        /// The values of the function
        /// </summary>
        public double[] Y { get; private set; }

        /// <summary>
        /// The arguments of the function
        /// </summary>
        public double[] X { get; private set; }

        /// <summary>
        /// The length of the table
        /// </summary>
        public int Length => Y.Length; 

        /// <summary>
        /// A constructor gets a function and forms table about it
        /// </summary>
        /// <param name="xs">Arguments</param>
        /// <param name="func">The function it needs to create the table</param>
        public FunctionsTable(double[] xs, IFunction func)
        {
            X = xs;
            Y = new double[xs.Length];
            for (int i = 0; i < xs.Length; ++i)
            {
                Y[i] = func.Caclulate(xs[i]);
            }
        }

        /// <summary>
        /// A constructor gets formed arguments and function's values
        /// </summary>
        /// <param name="xs">Arguments</param>
        /// <param name="ys">Values</param>
        public FunctionsTable(double[] xs, double[] ys)
        {
            if (xs.Length != ys.Length)
                throw new Exception(
                    "The count of the arguments is not equal to" +
                    "the count of the values");
            X = xs;
            Y = ys;
        }
    }
}
