using JP_TS_13_MainConnsole.Shooter.Weapons;

namespace JP_TS_13_MainConnsole.Shooter
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public double Money { get; set; } = 800;
        public Weapon Weapon { get; set; } = new Knife();
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
    }
}
