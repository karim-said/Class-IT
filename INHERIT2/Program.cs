using INHERIT2.CS;
using System;

namespace INHERIT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun("digl",7, -40);
                                                             
            ConcretePlaye concretePlaye = new ConcretePlaye(800, "Star", "Police", gun);
            
            
            Console.WriteLine($"Health:{concretePlaye.Health}");
            Console.WriteLine($"Cash:{concretePlaye.Cash}");

            Console.WriteLine(concretePlaye._gun.Shoot());
            Console.WriteLine(concretePlaye._gun.Shoot());
            Console.WriteLine(concretePlaye._gun.Shoot());
            Console.WriteLine(concretePlaye._gun.Shoot());
            Console.WriteLine(concretePlaye._gun.Shoot());
            Console.WriteLine(concretePlaye._gun.Shoot());
            Console.WriteLine(concretePlaye._gun.Shoot());
            Console.WriteLine(concretePlaye._gun.Shoot());
        }
    }
}
