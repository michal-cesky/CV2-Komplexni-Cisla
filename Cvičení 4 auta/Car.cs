using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Car : Vehicle
    {
        
        private int maxPassengers;
        private int passengers;

        public Car(double fuelAmount, FuelType fuelType)
            : base(fuelAmount, fuelType)
        {
            this.passengers = 0; 
            this.maxPassengers = 5;
            this.TankSize = 45;

        }

   
        public int MaxPassengers
        {
            get { return maxPassengers; }
            private set { maxPassengers = value; }
        }

        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (value <= maxPassengers)
                {
                    passengers = value;
                }
                else
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (Exception)
                    {
                        passengers = maxPassengers;
                        Console.WriteLine("To many passengers: {0}\n", value);
                    }
                }
            }
        }

        public override string ToString()
        {
            return String.Format($" Passengers: {Passengers}, Max passengers: {MaxPassengers}, Fuel amount: {FuelAmount} , Fuel: {FuelUsed}\n");

        }
    }
}
