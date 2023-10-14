using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD dvd = new DVD("50CENT",false,false,"CD",100,"Candy");
            dvd.Play();
            

            Console.ReadKey();
        }
    }
}
