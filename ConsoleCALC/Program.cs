using System;
using CustomLibrary;



namespace ConsoleCALC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            int a = 6;
            int b = 0;

            calc.Sum(a,b);
            Console.WriteLine($"Sub {calc.Sub(a, b)}");
            Console.WriteLine($"Mul {calc.Mul(a, b)}");
            Console.WriteLine($"Div {calc.Div(a, b)}");
        }
    }
}
