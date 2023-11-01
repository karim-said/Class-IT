using System;

namespace TypeOfNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 2;
            b = 3;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            string str = "STARLAB";

            Foo(str );

            //Console.WriteLine(a);
            //Console.WriteLine(b);


        }
        static void Foo(string str)
        {
            str = "DNN";
        }
    }
}
