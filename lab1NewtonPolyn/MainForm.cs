using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1NewtonPolyn
{
    public partial class MainForm : Form
    {
        /// <summary>A step to draw function</summary>
        private readonly double eps = 0.001;

        /// <summary>The function</summary>
        private IFunction _func;

        /// <summary>
        /// A constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            // ___1___ 
            // 5 + 9x^2
            _func = new Function(x => 1.0 / (5 + 9 * x * x));
        }

        /// <summary>
        /// Draws a given function on a chart
        /// </summary>
        /// <param name="chrt">The chart, on which it needs to draw</param>
        /// <param name="func">The function it needs to draw</param>
        /// <param name="left">A left border</param>
        /// <param name="right">A right border</param>
        /// <param name="name">A comment of the graph</param>
        private void DrawFunc(
            Chart chrt, 
            IFunction func, 
            double left, 
            double right, 
            string name = "")
        {
            if (chrt.Series.IndexOf(name) != -1)
                chrt.Series.Remove(chrt.Series[name]);
            var grp = new Series(name);
            grp.ChartType = SeriesChartType.Line;
            grp.ChartArea = "main";
            for (double x = left + eps; x <= right - eps; x += this.eps)
            {
                grp.Points.AddXY(x, func.Caclulate(x));
            }
            chrt.Series.Add(grp);
        }

        /// <summary>
        /// An overloaded version that takes borders from the form
        /// </summary>
        /// <param name="chrt">The chart, on which it needs to draw</param>
        /// <param name="func">The function it needs to draw</param>
        /// <param name="name">A comment of the graph</param>
        private void DrawFunc(Chart chrt, IFunction func, string name = "")
        {
            double a = Convert.ToDouble(nmrcLeft.Value);
            double b = Convert.ToDouble(nmrcRight.Value);
            this.DrawFunc(chrt, func, a, b, name);
        }

        /// <summary>
        /// Event handler to get a polynom
        /// </summary>
        private void btnCalcClick(object sender, EventArgs e)
        {
            this.DrawFunc(chrtFunc, this._func, "func");

            double a = Convert.ToDouble(nmrcLeft.Value);
            double b = Convert.ToDouble(nmrcRight.Value);
            int n = Convert.ToInt32(nmrcPowerPol.Value);
            double[] nodes = rdBtnEven.Checked ?
                EvenSplitting(a, b, n) : ChebyshevsSplitting(a, b, n);
   
            var pol = new NewtonPol(new FunctionsTable(nodes, this._func));
            this.DrawFunc(chrtFunc, pol, "polynom");
            this.DrawFunc(
                chrtError, 
                new Function(
                    x => Math.Abs(this._func.Caclulate(x) - pol.Caclulate(x))), 
                "error");
        }

        /// <summary>
        /// Gets an even splitting of a section
        /// </summary>
        /// <param name="left">A left border</param>
        /// <param name="right">A right border</param>
        /// <param name="n">A number of parts</param>
        /// <returns></returns>
        private double[] EvenSplitting(double left, double right, int n)
        {
            double[] nodes = new double[n + 1];
            nodes[0] = left;
            nodes[nodes.Length - 1] = right;
            for (int i = 1; i < nodes.Length - 1; ++i)
            {
                nodes[i] = left + (right - left) * i / n;
            }
            return nodes;
        }

        /// <summary>
        /// Gets a Chebyshev's splitting of a segment
        /// </summary>
        /// <param name="left">A left border</param>
        /// <param name="right">A right border</param>
        /// <param name="n">A number of parts</param>
        /// <returns></returns>
        private double[] ChebyshevsSplitting(double a, double b, int n)
        {
            double[] nodes = new double[n + 1];
            nodes[0] = a;
            nodes[nodes.Length - 1] = b;
            for (int i = 1; i < nodes.Length - 1; ++i)
            {
                nodes[i] = (a + b) / 2 + (b - a) / 2 *
                    Math.Cos((double)(2 * i + 1) / (2 * n + 2) * Math.PI);
            }
            return nodes;
        }

        /// <summary>
        /// Event handler on change event
        /// </summary>
        private void ChangeEvent(object sender, EventArgs e)
        {
            chrtFunc.Series.Clear();
            chrtError.Series.Clear();
        }
    }
}
