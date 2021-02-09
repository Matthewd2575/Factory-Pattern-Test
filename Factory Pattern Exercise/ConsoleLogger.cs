using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factory_Pattern_Exercise
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Put Key in ignition");
            Thread.Sleep(6000);
            Console.WriteLine("Turn the Key");
            Thread.Sleep(7000);

        }

    }
}
