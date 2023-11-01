using SoliNav;
using System;

namespace Sturct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime;
            //PointStruct pS;
            PointClass pC = new PointClass();

            pS.x = 32;
            pS.y = 32;

            pC.x = 90;
            pC.y = 90;

            Console.WriteLine("Values before pass");
            Console.WriteLine($"Sturct x:{pS.x}  y:{pS.y}");
            Console.WriteLine($"Class x:{pC.x}  y:{pC.y}");

            FooS(ref pS);
            FooC(pC);

            Console.WriteLine("Values after pass");
            Console.WriteLine($"Sturct x:{pS.x}  y:{pS.y}");
            Console.WriteLine($"Class x:{pC.x}  y:{pC.y}");
        }

        static void FooS(ref PointStruct ps)
        {
            ps.x++;
            ps.y++;
        }

        static void FooC(PointClass pc)
        {
            pc.x++;
            pc.y++;
        }
    }
}
