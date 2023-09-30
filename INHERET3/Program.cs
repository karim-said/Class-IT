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

            Console.WriteLine("Hello World!");
        }
    }
}
