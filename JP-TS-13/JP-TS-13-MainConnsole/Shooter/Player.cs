using JP_TS_13_MainConnsole.Shooter.Weapons;

namespace JP_TS_13_MainConnsole.Shooter
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public double Money { get; set; } = 800;
        public ShootableWeapon ShootableWeapon { get; set; }
        public Weapon Weapon { get; set; } = new Knife();
        public Status Status { get; set; }

        public Player()
        {
            if (Status == Status.Terrorist)
            {
                ShootableWeapon = new Glock();
            }
            else if (Status == Status.CounterTerrorist)
            {
                ShootableWeapon = new Usp();
            }
            else
            {
                ShootableWeapon = null;
            }
        }

        public void BuyWeapon(Weapon weaponToBuy)
        {
            if (Money >= weaponToBuy.Price)
            {
                Weapon = weaponToBuy;
                Money -= weaponToBuy.Price;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} has health {Health}% has {Money} USD uses {Weapon.Name}");
        }

        public void Shoot(Player playerToShoot)
        {
            ShootableWeapon.Shoot(playerToShoot);
            Console.WriteLine($"{Name}-->BANG BANG...");
        }
    }
}
