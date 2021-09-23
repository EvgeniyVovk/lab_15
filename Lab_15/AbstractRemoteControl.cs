using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15
{
    public abstract class AbstractRemoteControl
    {
        protected IGasBoiler gasBoiler;
        
        protected AbstractRemoteControl(IGasBoiler gasBoiler)
        {
            this.gasBoiler = gasBoiler;
        }

        public abstract void SwitchOn();
        public abstract void SetTemp(int temp);
        public abstract void SwitchOff();
        public abstract void GetCurrentTemp();
    }
}
