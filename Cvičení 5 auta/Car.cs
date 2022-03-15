using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class Car
    {
        private double tankSize;
        private double fuelAmount;
        public enum FuelType { Benzine, Diesel }
        private FuelType fuel;
        private CarRadio radio = new CarRadio();

        public Car(double fuelAmount, FuelType fuelType)
        {
            this.fuelAmount = fuelAmount;
            this.fuel = fuelType;
        }

        public double TankSize
        {
            get { return tankSize; }
            protected set { tankSize = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            protected set { fuelAmount = value; }
        }

        public FuelType FuelUsed
        {
            get { return fuel; }
            protected set { fuel = value; }
        }

        public void Refuel(FuelType fuelType, double amount)
        {

            if ((FuelAmount + amount) <= TankSize && this.fuel == fuelType)
            {
                FuelAmount += amount;
            }
            else if (this.fuel != fuelType) 
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong fuel!\n");
                }
            }
            else
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    FuelAmount = TankSize;
                    Console.WriteLine("Fuel tank is full. Added {0}liters of fuel.\n", TankSize - FuelAmount);
                }
            }
        }

        public void AddStation(int station, double frequency)
        {
            radio.AddRadioStations(station, frequency);
        }

        public void RadioSettings(int station)
        {
            if (radio != null)
            {
                radio.RadioSettings(station);
            }
            else
                Console.WriteLine("Set radio station.\n");
        }

        public void RadioStatus(bool status)
        {
            radio.Status = status;
        }

        public string radioToString()
        {
            if (radio.Status && radio.Frequency != 0)
            {
                return String.Format($"Radio status: {radio.Status}, Radio freqency: {radio.Frequency}MHz.\n");
            }

            if (radio.Status && radio.Frequency == 0)
            {
                return String.Format("You must select station.\n");
            }
            else
            {
                return String.Format("Radio is off.\n");
            }
        }
    }
}
