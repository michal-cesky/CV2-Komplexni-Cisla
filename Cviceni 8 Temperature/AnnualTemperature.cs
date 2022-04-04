using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_8_Temperature
{
    internal class AnnualTemperature
    {
        public List<double> MonthlyTemperatures = new List<double>();
        public int Year { get; set; }
        public AnnualTemperature(int year, List<double> monthlyTemperatures)
        {
            this.Year = year;
            this.MonthlyTemperatures = monthlyTemperatures;
        }
        public double MaxTemperature => MonthlyTemperatures.Max();
        public double MinTemperature { get => MonthlyTemperatures.Min(); }
        public double AverageAnnualTemperature { get => MonthlyTemperatures.Average(); }
    }
}
