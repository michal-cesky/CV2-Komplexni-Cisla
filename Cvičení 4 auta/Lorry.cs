using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Lorry : Vehicle
    {
        private double maxLoad;
        private double load;

        public Lorry(double fuelAmount, FuelType fuelType)
            : base(fuelAmount, fuelType)
        {
            this.load = 0; 
            this.maxLoad = 25;
            this.TankSize = 900;
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
            return String.Format($" Load: {Load} tonne, Max load: {MaxLoad} tonnes, Fuel amount: {FuelAmount} , Fuel: {FuelUsed}\n");
        }
    }
}
