using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Cviceni_8_Temperature
{
    internal class ArchiveTemperature
    {
        private SortedDictionary<int, AnnualTemperature> _archive = new SortedDictionary<int, AnnualTemperature> { };
        public void Load(string filePath)
        {
            string line;
            int year;

            StreamReader reader = File.OpenText(filePath);

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                char[] separators = { ' ', ':', ';' };
                string[] print = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                List<double> temparatures = new List<double>();
                year = Int32.Parse(print[0]);

                for (int i = 1; i < print.Length; i++)
                {
                     temparatures.Add(Double.Parse(print[i]));
                }

                _archive.Add(year, new AnnualTemperature(year, temparatures));
            }

            reader.Close();
            Console.WriteLine("{0} loaded", filePath);
        }
        public void PrintTemperatures()
        {
            foreach (AnnualTemperature yearEntry in _archive.Values)
            {
                Console.WriteLine(yearEntry.Year + ":" + String.Join(" ", yearEntry.MonthlyTemperatures.Select(s => String.Format("{0,6:F1}", s))));
            }
        }
        
        public void PrintAverageAnnualTemperatures()
        {
            foreach (AnnualTemperature yearEntry in _archive.Values)
            {
                Console.WriteLine("{0}: {1,6:F1}", yearEntry.Year, yearEntry.AverageAnnualTemperature);
            }
        }
        public void PrintAverageMonthlyTemperatures()
        {
            for (int month = 1; month <= 12; month++)
            {
                double total = 0;
                foreach (AnnualTemperature yearEntry in _archive.Values)
                {
                    total += yearEntry.MonthlyTemperatures[month - 1];
                }
                Console.Write("{0,5:F1}", total / _archive.Count());
            }
        }
        public void Calibration(double calib)
        {
            foreach (AnnualTemperature yearEntry in _archive.Values)
            {
                yearEntry.MonthlyTemperatures = yearEntry.MonthlyTemperatures.Select(s => s + calib).ToList();
            }
        }
        public void Save(string filePath)
        {
            StreamWriter outputFile = File.CreateText(filePath);
            foreach (AnnualTemperature yearEntry in _archive.Values)
            {
                outputFile.Write(yearEntry.Year);
                outputFile.Write(":");
                outputFile.WriteLine(String.Join(";", yearEntry.MonthlyTemperatures.Select(s => s.ToString(CultureInfo.InvariantCulture))));
            }
            outputFile.Close();
        }
    }
}
