using Enums.Enum;
using System;

namespace Enums
{
 
    internal class Program
    {


        static void Main(string[] args)
        {
            DayOfWeekCustom day = DayOfWeekCustom.Dushanbe;        
            
           
            switch(day)
            {
                case DayOfWeekCustom.Dushanbe:
                    int a, b, c;
                    a = 2;
                    b = 3;
                    b = a + b;
                    break;
                case DayOfWeekCustom.Seshanbe:
                    //some statment
                    break;
                case DayOfWeekCustom.Chorshanb:
                    //some statment
                    break;
                case DayOfWeekCustom.Panjshanbe:
                    //some statment
                    break;
                case DayOfWeekCustom.Juma:
                    //some statment
                    break;
            }

            string result = day switch 
            {
                DayOfWeekCustom.Dushanbe => "dushanbe",
                DayOfWeekCustom.Seshanbe => "Seshanbe",
                DayOfWeekCustom.Chorshanb => "Chorshanb",
                DayOfWeekCustom.Panjshanbe => "Panjshanbe",
                DayOfWeekCustom.Juma => "Juma",
                DayOfWeekCustom.Shanbe => "Shanbe",
                DayOfWeekCustom.Yakshanbe => "Yakshanbe",
                _ => ""
            };

            Console.WriteLine(result);
        }
    }
}
