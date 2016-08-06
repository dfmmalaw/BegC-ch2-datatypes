using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegC_ch2_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declerations and initialization (assignment)
            int venusMoonCount = 0;
            float windSpeed = 450.0f;
            string venusFact = "Venus is the only planet " + "that rotates clockwise";
            // display the variable values
            Console.WriteLine(venusFact);
            Console.Write("Total moons = ");
            Console.WriteLine(venusMoonCount);

            Console.Write("Venusian windspeed = ");

            Console.WriteLine(windSpeed + " miles/hour.");

            Console.ReadLine();
        }
    }
}
