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
        private readonly double eps = 0.001;

        private IFunction _func;

        public MainForm()
        {
            InitializeComponent();
            _func = new Function(x => 1.0 / (5 + 9 * x * x));
        }

        private void DrawFunc(Chart chrt, IFunction func, 
            double a, 
            double b, 
            string name)
        {
            if (chrt.Series.IndexOf(name) != -1)
                chrt.Series.Remove(chrt.Series[name]);
            Series grp = new Series(name);
            grp.ChartType = SeriesChartType.Line;
            grp.ChartArea = "main";
            for (double x = a + eps; x <= b - eps; x += this.eps)
            {
                grp.Points.AddXY(x, func.Caclulate(x));
            }
            chrt.Series.Add(grp);
        }

        private void DrawFunc(Chart chrt, IFunction func, string name)
        {
            double a = Convert.ToDouble(nmrcLeft.Value);
            double b = Convert.ToDouble(nmrcRight.Value);
            this.DrawFunc(chrt, func, a, b, name);
        }

        private void btnCalcClick(object sender, EventArgs e)
        {
            this.DrawFunc(chrtFunc, this._func, "func");

            double a = Convert.ToDouble(nmrcLeft.Value);
            double b = Convert.ToDouble(nmrcRight.Value);
            int n = Convert.ToInt32(nmrcPowerPol.Value);
            double[] nodes = rdBtnEven.Checked ?
                EvenSplitting(a, b, n) : ChebyshevsSplitting(a, b, n);
   
            var pol = new NewtonPol(nodes, this._func);
            this.DrawFunc(chrtFunc, pol, "polynom");
            this.DrawFunc(
                chrtError, 
                new Function(
                    x => Math.Abs(this._func.Caclulate(x) - pol.Caclulate(x))), 
                "error");
        }

        private double[] EvenSplitting(double a, double b, int n)
        {
            double[] nodes = new double[n + 1];
            for (int i = 0; i < nodes.Length; ++i)
            {
                nodes[i] = a + (b - a) * i / n;
            }
            return nodes;
        }

        private double[] ChebyshevsSplitting(double a, double b, int n)
        {
            double[] nodes = new double[n + 1];
            for (int i = 0; i < nodes.Length; ++i)
            {
                nodes[i] = (a + b) / 2 + (b - a) / 2 *
                    Math.Cos((double)(2 * i + 1) / (2 * n + 2) * Math.PI);
            }
            return nodes;
        }

        private void ChangeEvent(object sender, EventArgs e)
        {
            chrtFunc.Series.Clear();
            chrtError.Series.Clear();
        }
    }
}
