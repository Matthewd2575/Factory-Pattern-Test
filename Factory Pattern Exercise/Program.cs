using System;

namespace Factory_Pattern_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you would like to create");

                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (!input); //input == false

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
