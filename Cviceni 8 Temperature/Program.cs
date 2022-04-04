using System;

namespace Cviceni_8_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchiveTemperature archive = new ArchiveTemperature();
            
            try
            {
                archive.Load("inputFile.txt");
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new System.IO.FileNotFoundException("File not found");
            }

            archive.PrintTemperatures();
            Console.WriteLine("\nAverage temperatures (years)");
            archive.PrintAverageAnnualTemperatures();
            Console.WriteLine("\nAverage temperatures (months)");
            archive.PrintAverageMonthlyTemperatures();
            archive.Calibration(-0.1);
            Console.WriteLine("\n\nTemperatures calibration (-0.1)");
            archive.PrintTemperatures();

            try
            {
                archive.Save("outputFile.txt");
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new System.IO.FileNotFoundException("File not found");
            }

            Console.ReadLine();
        }
    }

}
