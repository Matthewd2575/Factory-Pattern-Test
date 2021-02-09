using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factory_Pattern_Exercise
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
            Console.WriteLine("Building a new ThreeWheeler!");
            Thread.Sleep(5000);
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("This rolls over a lot and gets stuck in the mud! ");
        }
    }
}
