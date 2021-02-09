using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving at a safe pace......oh boy!");
            
        }
    }
}
