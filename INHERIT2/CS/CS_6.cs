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
                ReCharg();

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
        public int Score;
        public byte Health;
        public string Name;
        public string Type;
        public Gun _gun;

        public Player(int cash, int score, byte health, string name, string type, Gun gun)
        {
            Cash = cash;
            Score = score;
            Health = health;
            Name = name;
            Type = type;
            _gun = gun;
        }



        ///public byte  Protect { get; set; }

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
