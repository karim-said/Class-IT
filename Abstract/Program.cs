using Abstract.Abstract;
using System;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weapon[] Vintovka = {new AK47(), new M16()};

            Vintovka[0].Shoot();
            Vintovka[1].Shoot();            
            
        }
    }
}
