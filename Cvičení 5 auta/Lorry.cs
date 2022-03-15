using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Lorry : Car
    {
        private double maxLoad;
        private double load;

        private int maxPassengers;
        private int passengers;

        public Lorry(double fuelAmount, FuelType fuelType)
            : base(fuelAmount, fuelType)
        {
            this.load = 5; 
            this.maxLoad = 10;
            this.TankSize = 400;

            this.passengers = 1;
            this.maxPassengers = 3;
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
            return String.Format($"Load: {Load} tonne, Max load: {MaxLoad} tonnes, Fuel amount: {FuelAmount} , Fuel: {FuelUsed}, Passengers: {Passengers}, Max passengers: {MaxPassengers}\n");
        }
    }
}
