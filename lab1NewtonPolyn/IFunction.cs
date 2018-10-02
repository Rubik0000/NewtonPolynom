using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1NewtonPolyn
{
    /// <summary>
    /// An interface for math functions
    /// </summary>
    public interface IFunction
    {
        /// <summary>
        /// Gets a value of the function from a given argument
        /// </summary>
        /// <param name="arg">function's argument</param>
        /// <returns>The value of the function</returns>
        double Caclulate(double arg);
    }
}
