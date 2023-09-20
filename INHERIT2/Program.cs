using INHERIT2.CS;
using System;

namespace INHERIT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun("digl",7, -40);

            Player player = new Player(800, 0, 100, "faraon", "Terrorist", gun);

            Console.WriteLine($"Health:{player.Health}");
            Console.WriteLine($"Cash:{player.Cash}");

            Console.WriteLine(player._gun.Shoot());
            Console.WriteLine(player._gun.Shoot());
            Console.WriteLine(player._gun.Shoot());
            Console.WriteLine(player._gun.Shoot());
            Console.WriteLine(player._gun.Shoot());
            Console.WriteLine(player._gun.Shoot());
            Console.WriteLine(player._gun.Shoot());
            Console.WriteLine(player._gun.Shoot());






        }
    }
}
