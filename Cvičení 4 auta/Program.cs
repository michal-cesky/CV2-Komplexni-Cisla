using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengeCar car = new PassengeCar(30, Car.FuelType.Benzine);
            Console.WriteLine("{0}:\n" + car, nameof(car));
            car.Passengers = 6;

            Lorry lorry = new Lorry(400, Car.FuelType.Diesel);
            Console.WriteLine("{0}:\n" + lorry, nameof(lorry));

            Console.WriteLine("car refuel:");
            car.Refuel(Car.FuelType.Benzine, 5);
            Console.WriteLine("" + car, nameof(car));
            car.Passengers = 5;

            Console.WriteLine("\nlorry refeul:");
            lorry.Refuel(Car.FuelType.Diesel, 20);

            Console.WriteLine("lorry refeul: (wrong fuel)");
            lorry.Refuel(Car.FuelType.Benzine, 5000);

            Console.WriteLine("car radio:");
            car.RadioStatus(true);
            car.AddStation(1, 98.3);
            car.RadioSettings(1);
            Console.WriteLine(car.radioToString());

            Console.WriteLine("lorry radio:");
            lorry.RadioStatus(false);
            lorry.AddStation(1, 98.3);
            Console.WriteLine(lorry.radioToString());

            Console.ReadLine();
        }
    }
}
