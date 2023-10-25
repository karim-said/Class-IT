using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl1
{
    public class M16
    {
        private readonly Laser _laser;
        public M16()
        {}

        public M16(Laser laser)
        {
            _laser = laser;
        }

        public void Shoot()
        {
            Console.WriteLine("Bah bah");
        }
        public void OnLaser() => _laser.On();
        public void OffLaser() => _laser.Off();


    }

    public class Laser
    {
        public void Off() => Console.WriteLine("Lasser Off");
        public void On() => Console.WriteLine("Lasser On");

    }
}
