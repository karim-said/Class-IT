using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DrelLibrary
{
    public abstract  class Drel
    {
        public abstract string Name { get; }
        public abstract bool Revers { get; }
        public abstract int Volume { get;  }
        public  bool Status { get; set; }

        

        public abstract void Start();
        public abstract void Stop();
        public abstract void Move();
        public abstract void Reverse();
        public abstract void Speed();
        
            
        


    }
    public class Perfarator : Drel
    {


        public override string Name => "TOTAL";
        public string titlesp = "Режим скорости устройства";
        public string titlere = "Режим сверления устройства";
        public int spd = Convert.ToInt32(Console.ReadLine());
        public override int Volume => spd ;
        public bool rev = Convert.ToBoolean(Console.ReadLine());
        public override bool Revers => Convert.ToBoolean(rev);
        
         
            
        public override void Start() 
        {
            
            Task.Delay(100);
            if (!Status)
            {
                Status = true;
                System.Console.WriteLine($"Дрель {Name} включён");
                Move();
            }
        }
        public override void Stop() 
        {
            if (Status)
            {
                System.Console.WriteLine($"Дрель {Name} выключен");
            }
        }
        public override void Move() 
        {
            Console.WriteLine("TRRRRRRRRRRRRRRRRRRRRRRRR"); 
        }
        public override void Reverse() 
        {
            
            if (Revers)
            {
                Console.WriteLine($"Дрель {Name} крутиться в обратную сторону"); 
            }
            else
            {
                Console.WriteLine($"Дрель {Name} крутиться в нужную сторону");
            }
        }
        
        public override void Speed() 
        {
            if (Volume > 0)
            {
                System.Console.WriteLine($"Дрель {Name} поставлен на скорость: {Volume}" );
            }
            else
            {
                Stop();
            }
        }
    }
}
