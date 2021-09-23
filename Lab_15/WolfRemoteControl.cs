using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15
{
    class WolfRemoteControl : AbstractRemoteControl
    {
        public WolfRemoteControl(IGasBoiler gasBoiler) : base(gasBoiler) { }

        public override void GetCurrentTemp()
        {
            gasBoiler.GetCurrentTemp();
        }

        public override void SetTemp(int temp)
        {
            gasBoiler.SetTemp(temp);
        }

        public override void SwitchOff()
        {
            gasBoiler.SwitchOff();
        }

        public override void SwitchOn()
        {
            gasBoiler.SwitchOn();
        }
    }
}
