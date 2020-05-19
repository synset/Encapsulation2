using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Chicken> chickens = new List<Chicken>()
            {
                new Chicken("Henny", 3),
                new Chicken("Hen", 8),
                new Chicken("May", 10),
                new Chicken("Minni", 2)
            };

            foreach (Chicken chicken in chickens)
            {
                Console.WriteLine("Chicken " + chicken.Name + " (age " + chicken.Age + ") can produce " + chicken.ProductPerDay + " eggs per day.");
            }
        }
    }
}
