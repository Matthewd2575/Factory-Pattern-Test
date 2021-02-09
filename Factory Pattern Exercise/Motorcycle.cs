using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factory_Pattern_Exercise
{
   public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a new Motorcycle!");
            Thread.Sleep(5000);
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("vrooooooooom");
        }
    }


}
