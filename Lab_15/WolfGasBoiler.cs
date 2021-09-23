using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15
{
    class WolfGasBoiler: IGasBoiler
    {
        private int temp = 0;
        private bool isOn = false;

        public void GetCurrentTemp()
        {
            Console.WriteLine("Temp is " + temp + " on Wolf gas boiler");
        }

        public void SetTemp(int temp)
        {
            this.temp = temp;
            Console.WriteLine("Setting temp " + temp + " on Wolf gas boiler");
        }

        public void SwitchOff()
        {
            if (isOn)
            {
                Console.WriteLine("Wolf gas boiler is turned off");
            }
            else
            {
                Console.WriteLine("Wolf gas boiler already off");
            }
        }

        public void SwitchOn()
        {
            if (!isOn)
            {
                isOn = true;
                Console.WriteLine("Wolf gas boiler is turned on");
            }
            else
            {
                Console.WriteLine("Wolf gas boiler already on");
            }
        }
    }
}
