using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class CarRadio
    {
        private double frequency;
        private bool status;
        
        private Dictionary<int, double> radioStation = new Dictionary<int, double>();

        
        public double Frequency
        {
            get { return frequency; }
            protected set { frequency = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

       
        public void AddRadioStations(int station, double frequency)
        {
            radioStation.Add(station, frequency);
        }

        
        public void RadioSettings(int station)
        {
    
            if (radioStation.ContainsKey(station) && status)
            {
                Frequency = radioStation[station];
            }
            
            else if (!status)
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Radio is off. You must turn it on.\n");
                }
            }
        }
    }
}
