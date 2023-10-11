

namespace Abstract.Abstract
{
    public abstract class Weapon
    {
        public abstract int CountOfSome { get; }
        public abstract void Shoot();
    }

    public class AK47 : Weapon
    {
        public override int CountOfSome => 30;
        public override void Shoot()
        {
            System.Console.WriteLine("Qar Qar");
        }
    }

    public class M16 : Weapon
    {
        public override int CountOfSome => 26;
        public override void Shoot()
        {
            System.Console.WriteLine("Tuf Tuf");
        }
    }
}
