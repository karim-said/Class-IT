
using System;

namespace Constructor
{
    public class University
    {
        public int Num { get; set; }
    }

    public class A
    {
        private readonly University _ttu;     

        public A(University ttu)
        {
            _ttu = ttu;
        }


        public A() { }
        public A(string name) => Console.WriteLine(name);

        
        public int Id { get; set; }

        //public void Foo()
        //{
        //    ttu.Num = 23;
        //}

        public void Chumchi()
        {
            Console.WriteLine("Chchi");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var dmt = new University();

            A a = new A(dmt);              
        }
    }
}
