using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15
{
    public interface IGasBoiler
    {
        void SwitchOn();
        void SetTemp(int temp);
        void SwitchOff();
        void GetCurrentTemp();
    }
}
