using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassk_13
{
    public class Mouse
    {
        public double X;
        public double Y;
        public double Postion;
        public double CountOfButton;
        public bool State;

        public Mouse(double x, double y, double position, double countOfButton, bool state)
        {
            X = x;
            Y = y;
            Postion = position;
            CountOfButton = countOfButton;
            State = state;
        }
        
        public void On()
        {
            Console.WriteLine(State);
        }
        public void Off()
        {
            Console.WriteLine(State == false);
        }
        public void Click()
        {
            Console.WriteLine("Клик");
        }

        public void MoveLeft()
        {
            Console.WriteLine("перемещено влево");
        }

        public void MoveBack()
        {
            Console.WriteLine("Перемещено назад");
        }

        public void MoveFront()
        {
            Console.WriteLine("Перемещено прямо");
        }

        public void MoveRight()
        {
            Console.WriteLine("Перемещено на право");
        }


        public void DoubleClick()
        {
            Console.WriteLine("Нажата двойной клик");
        }

        public void EventKeyUp()
        {
            Console.WriteLine("Кнопка мыши отпущено");
        }

        public void EventKeyDown()
        {
            Console.WriteLine("Кнопка мыщи зажато");
        }
    }
}
