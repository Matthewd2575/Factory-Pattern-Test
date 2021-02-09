using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("This rolls over a lot and gets stuck in the mud! ");
        }
    }
}
