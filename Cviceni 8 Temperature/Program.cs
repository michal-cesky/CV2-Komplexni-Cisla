using System;

namespace Cviceni_8_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchiveTemperature archive = new ArchiveTemperature();
            Console.WriteLine("Open file\n");
            Console.WriteLine();
            try
            {
                archive.Load(@"archiveInput.txt");
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new System.IO.FileNotFoundException("File not found.");
                return;
            }
            Console.WriteLine("Loaded file\n");
            archive.PrintTemperatures();
            Console.WriteLine("Average temperatures for all years:");
            archive.PrintAverageAnnualTemperatures();
            Console.WriteLine("Average monthly temperatures:");
            archive.PrintAverageMonthlyTemperatures();
            archive.Calibration(-0.1);
            Console.WriteLine("Temperatures after calibration of -0.1:");
            archive.PrintTemperatures();
            Console.WriteLine("file save");
            Console.ReadLine();
            try
            {
                archive.Save(@"D:\archiveOutput.txt");
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new System.IO.FileNotFoundException("File not found.");
                return;
            }
            Console.ReadLine();
        }
    }

}
