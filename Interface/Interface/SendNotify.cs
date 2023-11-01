using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interface
{
    public class SendNotifyBySMS : ISendNotify
    {
        void ISendNotify.SendNotify()
        {
            Console.WriteLine("Notify was send by SMS");
        }
    }

    public class SendNotifyByEmail : ISendNotify
    {
        void ISendNotify.SendNotify()
        {
            Console.WriteLine("Notify was send by Email");
        }
    }
    public class Semblock
    {

    }


    public class MyClass : SendNotifyByEmail
    {

    }
}
