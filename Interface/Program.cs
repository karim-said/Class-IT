using Interface.Interface;
using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISendNotify[] sendNotify = { new SendNotifyBySMS(), new SendNotifyByEmail() };

            foreach (var besharaph in sendNotify)
            {
                besharaph.SendNotify();
            }
        }
    }
}
