namespace INHERET3
{
    public class A
    {
        public int OneBase { get; set; }
        public int TwoBase { get; set; }
        public void Foo()
        {
            System.Console.WriteLine("Foo from object A");
        }
    }

    public class B : A
    {
        public int OneCurrent { get; set; }
        public int TwoCurrent { get; set; }
        public void Foo()
        {
            System.Console.WriteLine("Foo from object B");
        }

        public void Bar()
        {
            base.Foo();
            this.Foo();
        }
    }
}
