using Abstract.Abstract;
using System;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AK47 a = new AK47(); 
            a.Shoot();
            a.Archajon();
           

            M16 m = new M16(); 
            m.Shoot();
            m.Archajon();

            Chumchi c = new Chumchi();
            c.JJ();
                
        }
    }
}
