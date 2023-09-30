namespace INHERIT2.CS
{
    public class Gun
    {
        public string Name;
        public int CountOfBullet;
        public readonly int Demage;
        public Gun(string name, int cout,int demage)
        {
            Name = name;
            Demage = demage;
            CountOfBullet = cout;
        }
        
        public string Shoot()
        {
            if (CountOfBullet == 0)
            {
                ReCharg();
                return null;
            }

            CountOfBullet--;
           return $"Pah pah {CountOfBullet}";
        }
        public void ReCharg()
        {
            CountOfBullet = 7;
            System.Console.WriteLine("Sharah parah"); 
        }
    }

    public class Player
    {
        public int Cash;
        public int Score = 0;
        public byte Health = 100;
        protected string Type;
        public string Name;


        public string MoveFront() => "I'm going to front";
        public string MoveBack() => "I'm going back";
        public string MoveLeft() => "I try to left";
        public string MoveRight() => "I try to right";
        public string Jump() => "I try to jump";
        public string Seat() => "I try to seat";

        public string Rotate(double x, double y, double z) 
            => $"I try to see that coordinate" +
            $"X:{x}\n" +
            $"Y:{y}\n" +
            $"Z:{z}\n";
    }
}
