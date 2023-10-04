namespace ConsoleApp1.Floder
{
 
    public class A 
    {
        public A()
        {

        }
        public A(string a) => System.Console.WriteLine("Constructor from A" + a);
    }

    public class B : A
    {
        public B()
        {

        }
        static string b = "Tojikiston ba pesh";
        public B(int a) : base(b) => System.Console.WriteLine("Constructor from B");
    }

    public class C : B { }

    public class Participant
    {
        public string EmployeeName { get; set; }
        public int DocumentId { get; set; }
        public int EmployeeId { get; set; }
        public int OrganithationId { get; set; }
    }

    public class SenderDocument : Participant { }
    public class RecipientDocument : Participant 
    {
        public bool Status { get; set; }
    }
}
