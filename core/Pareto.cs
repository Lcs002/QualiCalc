using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace QualiCalc.core
{
    public class Pareto
    {
        [AllowNull] public Input In { get; set; }

        public Pareto(Input input)
        {
            this.In = input;
            exec(In);
        }

        private void exec(Input input)
        {
            var sortedData = from entry in input.data 
                         orderby entry.Value descending
                         select entry;

            var chart = input.chart;
            chart.Series.Clear();

            var chartArea = chart.ChartAreas[0];
            chartArea.AxisX.Minimum = -1;
            chartArea.AxisX.Maximum = sortedData.Count();
            chartArea.AlignmentStyle = AreaAlignmentStyles.All;

            chart.Series.Add("C");
            chart.Series["C"].ChartType = SeriesChartType.Column;

            chart.Series.Add("Sum");
            chart.Series["Sum"].ChartType = SeriesChartType.Line;

            int i = 0;
            int tot = 0;
            foreach (var entry in sortedData)
            {
                chart.Series["C"].Points.AddXY(i, entry.Value);

                tot += entry.Value;
                chart.Series["Sum"].Points.AddXY(i++, tot);
            }

            double yPareto = tot * 0.8f;

            chart.Series.Add("Pareto");
            chart.Series["Pareto"].ChartType = SeriesChartType.Line;
            chart.Series["Pareto"].Points.AddXY(0, yPareto);
            chart.Series["Pareto"].Points.AddXY(sortedData.Count(), yPareto);

            //DataPoint intersectPareto = chart.Series["Sum"].Points.Intersect(chart.Series["T2"].Points).First();
            //chart.Series["Pareto"].Points.AddXY(intersectPareto.XValue, intersectPareto.YValues[0]);
            //chart.Series["Pareto"].Points.AddXY(intersectPareto.XValue, intersectPareto.YValues[0]);
        }

        public class Input
        {
            public Dictionary<string, int> data = new Dictionary<string, int>();
            public Chart chart;

            public Input(Chart chart, Dictionary<string, int> data)
            {
                this.chart = chart;
                this.data = data;
            }
        }
    }
}

