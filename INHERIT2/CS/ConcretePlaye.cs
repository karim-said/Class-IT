namespace INHERIT2.CS
{
    public class ConcretePlaye : Player
    {
        public Gun _gun;        
        public ConcretePlaye(int cash, string name, string type, Gun gun)
        {
            Cash = cash;
            Name = name;
            Type = type;
            _gun = gun;
        }
        public void Foo(){}
    }
}

