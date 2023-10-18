namespace Abstract.Abstract
{
    public abstract class Weapon
    {
        public abstract int CountOfSome { get; }
        public abstract void Shoot();
        public void SoliNav()
        {
            System.Console.WriteLine("Soli Nav");
        }

        public virtual void Archajon()
        {
            System.Console.WriteLine("Archajon abstract");
        }
    }

    public class AK47 : Weapon
    {
        public override int CountOfSome => 30;
        public override void Shoot()
        {
            System.Console.WriteLine("Qar Qar");
        }

        public override void Archajon()
        {
            System.Console.WriteLine("Archajon from AK47");
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

    public class Yagonchi
    {
        public virtual void JJ()
        {
            System.Console.WriteLine("JJ");
        }
    }

    public class Chumchi : Yagonchi
    {
        public override void JJ()
        {
            System.Console.WriteLine("JJ from Chumchi");
        }
    }
}
