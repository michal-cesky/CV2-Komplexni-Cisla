using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_8_Temperature
{
    internal class AnnualTemperature
    {
        private int year;
        public List<double> MonthlyTemperatures = new List<double> { };
        public int Year { get => year; set => year = value; }
        public AnnualTemperature(int year, List<double> monthlyTemperatures)
        {
            Year = year;
            MonthlyTemperatures = monthlyTemperatures;
        }
        public double MaxTemperature { get => MonthlyTemperatures.Max(); }
        public double MinTemperature { get => MonthlyTemperatures.Min(); }
        public double AverageAnnualTemperature { get => MonthlyTemperatures.Average(); }
    }
}
