using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using static QualiCalc.core.Pareto;

namespace QualiCalc.core
{
    public static class VariableControlChart
    {
        public static Out Exec(List<double> data, double utl, double ltl)
        {
            double n = data.Count();
            double avg = data.Sum() / n;                                         // Average
            double dev = Math.Sqrt(data.Sum(x => Math.Pow(x - avg, 2)) / (n-1)); // Standard Deviation
            double ucl = avg + 3 * dev;                                          // Upper Control Limit
            double lcl = avg - 3 * dev;                                          // Lower Control Limit
            double cp = (utl - ltl) / (6 * dev);                                 // Capability
            double ucp = (utl - avg) / (3 * dev);                                // Upper Capability
            double lcp = (avg - ltl) / (3 * dev);                                // Lower Capability

            Out res = new Out();
            res.data = data;

            res.isControlled = true;
            foreach (double value in data) 
                if (value > ucl || value < lcl) 
                    res.isControlled = false;
            
            if (res.isControlled)
            {
                res.isAcceptable = true;
                foreach (double value in data) 
                    if (value > utl || value < ltl) 
                        res.isAcceptable = false;
            }

            res.isNonconfirming = cp < 1;
            if (!res.isNonconfirming)
            {
                res.isCentered = cp == ucp && cp == lcp;
                if (res.isCentered && cp >= 1.33f)
                    res.isCapable = true;
            }

            res.n = n;
            res.avg = avg;
            res.dev = dev;
            res.ucl = ucl;
            res.lcl = lcl;
            res.utl = utl;
            res.ltl = ltl;
            res.cp = cp;
            res.ucp = ucp;
            res.lcp = lcp;
            return res;
        }

        public struct Out
        {
            public double n;
            public double avg;     // Average
            public double dev;     // Standard Deviation
            public double ucl;     // Upper Control Limit
            public double lcl;     // Lower Control Limit
            public double utl;     // Upper Tolerant Limit
            public double ltl;     // Lower Tolerant Limit
            public double cp;      // Capability
            public double ucp;     // Upper Capability
            public double lcp;     // Lower Capability
            public bool isControlled;
            public bool isAcceptable;
            public bool isNonconfirming;
            public bool isCentered;
            public bool isCapable;
            public List<double> data;
        }
    }
}
