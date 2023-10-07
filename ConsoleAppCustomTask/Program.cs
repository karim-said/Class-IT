using CustomClassTask;
using System;

namespace ConsoleAppCustomTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool turnOff = true;
            int command = 0;
            var User = new WashMashine();

            while(turnOff)
            {
                Console.WriteLine($"" +
                    $"Commands of Washmashine \n" +
                    $"1 - OpenDoor\n" +
                    $"2 - ThrowClothes\n" +
                    $"3 - CloseDoor\n" +
                    $"4 - ChooseMode\n" +
                    $"5 - Start\n" +
                    $"6 - Stop\n" +
                    $" - OpenDoor\n");

                command = Convert.ToInt32(Console.ReadLine());

                switch(command)
                {
                    case 0:
                        Console.WriteLine("WashMashine is ready");
                        break;
                    case 1:
                        User.OpenDoor();
                        break;
                    case 2:
                        User.ThrowClothes();
                        break;
                    case 3:
                        User.CloseDoor();
                        break;
                    case 4:
                        User.ChooseMode("Fast");
                        break;
                    case 5:
                        User.Start();
                        break;
                    case 6:
                        User.Stop();
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }

         
        }
    }
}
