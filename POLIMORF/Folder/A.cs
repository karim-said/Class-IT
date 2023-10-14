
namespace POLIMORF.Folder
{
    public class A
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void Foo()
        {
            System.Console.WriteLine("Foo from object A");
        }
    }

    public class B
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void Bar()
        {
            System.Console.WriteLine("Bar from object B");
        }
    }

    public class C
    {
        public int  Sum(int a ,int b)
        {
            return a + b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        public void Sum(A a, B b)
        {

        }
    }
}
