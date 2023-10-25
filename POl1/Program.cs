using System;

namespace POl1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laser laser = new Laser();
            M16 m = new M16(laser);

            m.OnLaser();
            m.Shoot();
        }
    }
}
