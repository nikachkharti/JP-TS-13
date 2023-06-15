namespace JP_TS_13_MainConnsole.Shooter.Weapons
{
    public abstract class Weapon
    {
        public abstract string Name { get; set; }
        public abstract double Price { get; set; }
        public abstract int Damage { get; set; }
    }
}
