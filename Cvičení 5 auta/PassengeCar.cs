using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class PassengeCar : Car
    {
        
        private int maxPassengers;
        private int passengers;

        private double maxLoad;
        private double load;

        public PassengeCar(double fuelAmount, FuelType fuelType)
            : base(fuelAmount, fuelType)
        {
            this.passengers = 6; 
            this.maxPassengers = 5;
            this.TankSize = 45;

            this.load = 100;
            this.maxLoad = 150;

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

        public double MaxLoad
        {
            get { return maxLoad; }
            private set { maxLoad = value; }
        }

        public double Load
        {
            get { return load; }
            set
            {
                if (value <= MaxLoad)
                {
                    load = value;
                }

                else
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (Exception)
                    {

                        load = maxLoad;
                        Console.WriteLine("Overlode! {0}. Max load: {1}.\n", value, MaxLoad);
                    }
                }

            }
        }

        public override string ToString()
        {
            return String.Format($"Passengers: {Passengers}, Max passengers: {MaxPassengers}, Fuel amount: {FuelAmount} , Fuel: {FuelUsed}, Load: {Load} kilograms, Max load: {MaxLoad} kilograms");

        }
    }
}
