using QualiCalc.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualiCalc
{
    public partial class ParetoUC : UserControl
    {
        public ParetoUC()
        {
            InitializeComponent();

            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "A", 35 },
                { "B", 17 },
                { "C", 8 },
                { "D", 7 },
                { "E", 3 },
            };

            Pareto p = new Pareto(new Pareto.Input(Chart, dict));
        }
    }
}
