using System;

namespace Pol2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var kamaz = new Kamaz<Ovkashak>();

            kamaz.Move();
            kamaz.Yagonchi.Pushss();
        }
    }
}
