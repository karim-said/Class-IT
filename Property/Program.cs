using System;

namespace Property
{
        //private
        //protected
        //public
    public class B
    {
        public string Move()
        {
            Console.WriteLine("Move from object B");
            return "";
        }
    }

    public class A
    {
        B _b = new B();

        public A()
        {
            _b.Move();
        }

    }
    internal class Program
    {
        static void Foo()
        {
            A a = new A();
        }

        static void Main(string[] args)
        {
            Foo();
        }
       
    }
}
