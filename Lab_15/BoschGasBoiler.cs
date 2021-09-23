using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15
{
    class BoschGasBoiler : IGasBoiler
    {
        private int temp = 0;
        private bool isOn = false;

        public void GetCurrentTemp()
        {
            Console.WriteLine("Temp is " + temp + " on Bosch gas boiler");
        }

        public void SetTemp(int temp)
        {
            this.temp = temp;
            Console.WriteLine("Setting temp " + temp + " on Bosch gas boiler");
        }

        public void SwitchOff()
        {
            if (isOn)
            {
                Console.WriteLine("Bosch gas boiler is turned off");
            }
            else
            {
                Console.WriteLine("Bosch gas boiler already off");
            }
        }

        public void SwitchOn()
        {
            if (!isOn)
            {
                isOn = true;
                Console.WriteLine("Bosch gas boiler is turned on");
            }
            else
            {
                Console.WriteLine("Bosch gas boiler already on");
            }
        }
    }
}
