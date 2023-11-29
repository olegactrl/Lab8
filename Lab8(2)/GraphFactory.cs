using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2_
{
    public class GraphFactory
    {
        public IChart CreateChart(string chartType)
        {
            switch (chartType.ToLower())
            {
                case "line":
                    return new LineChartFactory().CreateChart();
                case "bar":
                    return new BarChartFactory().CreateChart();
                case "pie":
                    return new PieChartFactory().CreateChart();
                default:
                    throw new ArgumentException("error");
            }
        }
    }
}
