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
        public void Load(string path)
        {
            string line;
            int year;

            try
            {
                StreamReader reader = File.OpenText(@path);

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    char[] separator = { ' ', ':', ';' };
                    string[] partition = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    List<double> temparatures = new List<double>();

                    year = Int32.Parse(partition[0]);

                    for (int i = 1; i < partition.Length; i++)
                    {
                        temparatures.Add(Double.Parse(partition[i]));
                    }

                    _archive.Add(year, new AnnualTemperature(year, temparatures));
                }

                reader.Close();
                Console.WriteLine("File {0} loaded", path);
            }
            catch (System.IO.FileNotFoundException)
            {

                throw new System.IO.FileNotFoundException("File not found.");
            }
        }
        public void Calibration(double calConstant)
        {
            foreach (AnnualTemperature yearEntry in _archive.Values)
            {
                yearEntry.MonthlyTemperatures = yearEntry.MonthlyTemperatures.Select(s => s + calConstant).ToList();
            }
        }
        public AnnualTemperature Find(int year)
        {
            if (!_archive.ContainsKey(year)) throw new Exception("This entry does not exist");
            return _archive[year];
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
                double sum = 0;
                foreach (AnnualTemperature yearEntry in _archive.Values)
                {
                    sum += yearEntry.MonthlyTemperatures[month - 1];
                }
                Console.Write(" {0,6:F1}", sum / _archive.Count());
            }
            Console.WriteLine();
        }
    }
}
