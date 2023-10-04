using ClassLibrary1;
using System;

namespace INHERET3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotInternal notInternal = new NotInternal();

            notInternal.Foo();
            //Internal _internal = new Internal();

            B b = new B();

            b.Bar();
            Console.WriteLine("Hello World!");
        }
    }
}
