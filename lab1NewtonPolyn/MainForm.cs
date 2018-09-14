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
        private readonly double eps = 0.01;

        private IFunction _func;

        public MainForm()
        {
            InitializeComponent();
            _func = new Function(x => 1.0 / (5 + 9 * x * x));
        }

        private void DrawFunc()
        {
            Series grp = new Series("1/(5+9*x^2)");
            grp.ChartType = SeriesChartType.Line;
            grp.ChartArea = "func";
            for (double x = Convert.ToDouble(nmrcLeft.Value);
                x <= Convert.ToDouble(nmrcRight.Value); x += this.eps)
            {
                grp.Points.AddXY(x, this._func.Caclulate(x));
            }
            chrtFunc.Series.Add(grp);
        }

        private void btnCalcClick(object sender, EventArgs e)
        {
            this.DrawFunc();
        }
    }
}
