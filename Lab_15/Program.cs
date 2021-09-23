using System;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractRemoteControl abstractRemoteControl;
            abstractRemoteControl = new BoschRemoteControl(new BoschGasBoiler());
            abstractRemoteControl.SwitchOn();
            abstractRemoteControl.SetTemp(25);
            abstractRemoteControl.GetCurrentTemp();
            abstractRemoteControl.SwitchOff();

            Console.WriteLine();

            abstractRemoteControl = new WolfRemoteControl(new WolfGasBoiler());
            abstractRemoteControl.SwitchOn();
            abstractRemoteControl.SetTemp(30);
            abstractRemoteControl.GetCurrentTemp();
            abstractRemoteControl.SwitchOff();
        }
    }
}
