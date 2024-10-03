using QualiCalc.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QualiCalc.pages
{
    public partial class VariableControlChartUC : UserControl
    {
        public VariableControlChartUC()
        {
            InitializeComponent();

            List<double> va = new List<double>()
            {
                94.9, 94.9,
                95.04,  94.79,
                95.09,  94.56,
                94.87,  94.7,
                95, 94.71,
                95.2,  95,
                94.98,   94.91,
                95.13,  94.58,
                95.17,  94.53,
                94.93,  94.56
            };

            VariableControlChart.Out _out = VariableControlChart.Exec(va, 97, 93);

            Chart.Series.Clear();

            var chartArea = Chart.ChartAreas[0];
            chartArea.AxisY.IsStartedFromZero = false;
            chartArea.AxisY.ScaleView.Zoomable = true;
            chartArea.AxisY.Minimum = Double.NaN;
            chartArea.AxisY.Maximum = Double.NaN;
            chartArea.AxisX.Minimum = Double.NaN;
            chartArea.AxisX.Maximum = Double.NaN;

            Series _data = Chart.Series.Add("Data");
            Series _avg = Chart.Series.Add("Average");
            Series _ucl = Chart.Series.Add("UCL");
            Series _lcl = Chart.Series.Add("LCL");
            Series _utl = Chart.Series.Add("UTL");
            Series _ltl = Chart.Series.Add("LTL");

            _data.Color = Color.DarkBlue;
            _avg.Color = Color.Black;
            _ucl.Color = Color.Red;
            _lcl.Color = Color.Red;
            _utl.Color = Color.Green;
            _ltl.Color = Color.Green;

            _data.ChartType = SeriesChartType.Line;
            _avg.ChartType = SeriesChartType.Line;
            _ucl.ChartType = SeriesChartType.Line;
            _lcl.ChartType = SeriesChartType.Line;
            _utl.ChartType = SeriesChartType.Line;
            _ltl.ChartType = SeriesChartType.Line;

            _avg.Points.AddXY(0, _out.avg);
            _avg.Points.AddXY(_out.n, _out.avg);

            _ucl.Points.AddXY(0, _out.ucl);
            _ucl.Points.AddXY(_out.n, _out.ucl);

            _lcl.Points.AddXY(0, _out.lcl);
            _lcl.Points.AddXY(_out.n, _out.lcl);

            _utl.Points.AddXY(0, _out.utl);
            _utl.Points.AddXY(_out.n, _out.utl);

            _ltl.Points.AddXY(0, _out.ltl);
            _ltl.Points.AddXY(_out.n, _out.ltl);

            for (int i = 0; i < _out.data.Count(); i++)
            {
                _data.Points.AddXY(i, _out.data[i]);
                chartArea.RecalculateAxesScale();
            }

            IsControlled.Checked = _out.isControlled;
            IsAcceptable.Checked = _out.isAcceptable;
            IsCapable.Checked = _out.isCapable;
            IsNonconforming.Checked = _out.isNonconfirming;
            IsCentered.Checked = _out.isCentered;
        }
    }
}
