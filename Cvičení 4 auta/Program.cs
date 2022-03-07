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
            // init of car
            Car car = new Car(30, Vehicle.FuelType.Benzine);
            Console.WriteLine("{0}:\n" + car, nameof(car));

            car.Passengers = 6; // added 6 passengers, max capacity is 5
            Console.WriteLine("{0}:\n" + car, nameof(car));

            // init of lorry
            Lorry lorry = new Lorry(400, Vehicle.FuelType.Diesel);
            Console.WriteLine("{0}:\n" + lorry, nameof(lorry));

            // refuel car with 50 l of gasoline, tank capacity is 45
            car.Refuel(Vehicle.FuelType.Benzine, 50);
            Console.WriteLine("{0}:\n" + car, nameof(car));

            // car radio
            car.RadioStatus(true);
            car.AddStation(1, 99.6);
            car.RadioSettings(1);
            Console.WriteLine(car.radioToString());

            // lorry radio
            lorry.RadioStatus(true);
            Console.WriteLine(lorry.radioToString());

            Console.ReadLine();
        }
    }
}
