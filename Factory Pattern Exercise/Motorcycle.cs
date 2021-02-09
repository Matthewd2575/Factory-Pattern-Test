using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
   public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("vrooooooooom");
        }
    }


}
