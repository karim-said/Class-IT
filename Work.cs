using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrelLibrary;

namespace Exercise11
{
    internal class Work


    {
        static void Main(string[] args)
        {
            bool Turnoff = true;
            int command = 0;
            Perfarator Master = new Perfarator();
            
            while (Turnoff)
            {
                Console.WriteLine($"{Master.titlesp}:{Master.spd}\n;{Master.titlere}:{Master.rev}");
                Console.WriteLine($"Функции перфаратора \n" +
                    $"1-Start\n" +
                    $"2-Reverse\n" +
                    $"3-Speed\n"+
                    $"4-Stop\n") ;
                command =Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Master.Start();
                        Console.WriteLine();
                        break;
                    case 2:
                        Master.Reverse();
                        Console.WriteLine();
                        break;
                    case 3:
                        Master.Speed();
                        Console.WriteLine();
                        break;
                    case 4:
                        Master.Stop();
                        break;
                    default: 
                        Console.WriteLine("Несуществующая команда!");
                        break;
                }
            }
        }
    }
}
