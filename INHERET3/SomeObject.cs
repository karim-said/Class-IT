namespace INHERET3
{
    public class A
    {
        public void Foo()
        {
            System.Console.WriteLine("Foo from object A");
        }

    }

    public class B : A
    {
        public void Foo()
        {
            System.Console.WriteLine("Foo from object B");
        }
    }
}
