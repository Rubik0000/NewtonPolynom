using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1NewtonPolyn
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFunction
    {
        double Caclulate(double arg);
    }

    public class Function : IFunction
    {
        /// <summary>
        /// 
        /// </summary>
        private Func<double, double> _func;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="func">A function need to be performed</param>
        public Function(Func<double, double> func)
        {
            this._func = func;
        }

        /// <summary>
        /// Calculates the function from given argument
        /// </summary>
        /// <param name="arg">An argument of the function</param>
        /// <returns>The value of the function</returns>
        public double Caclulate(double arg)
        {
            return _func(arg);
        }
    }
}
