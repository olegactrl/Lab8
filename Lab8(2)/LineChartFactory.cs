using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2_
{
    public class LineChartFactory : IChartFactory
    {
        public IChart CreateChart()
        {
            return new LineChart();
        }
    }
}
