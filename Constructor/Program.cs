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
        public A() { }
        public A(University ttu) => _ttu = ttu;
        public A(string name) => Console.WriteLine(name);
        
        public int Id { get; set; }

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

            dmt.Num = 15;
            A a = new A(dmt);              
        }
    }
}
