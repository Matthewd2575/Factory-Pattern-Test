using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factory_Pattern_Exercise
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a new Car!");
            Thread.Sleep(5000);
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving at a safe pace......oh boy!");
            
        }
    }
}
