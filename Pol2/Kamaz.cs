using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol2
{
    public class Kamaz<T>
    {
        public T Yagonchi { get; set; }
        public void Move()
        {
            Console.WriteLine("Qan ban ban");
        }
    }

    public class Mixer
    {
        public void Mixing()
        {
            Console.WriteLine("Juj juj mixer");
        }
    }

    public class Ovkasha
    {
        public void Pushss()
        {
            Console.WriteLine("Pshhsfdsf");
        }
    }

}
