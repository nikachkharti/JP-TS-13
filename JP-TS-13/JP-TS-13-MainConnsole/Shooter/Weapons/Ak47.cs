namespace JP_TS_13_MainConnsole.Shooter.Weapons
{
    public class Ak47 : ShootableWeapon
    {
        public override string Name { get; set; } = "AK47";
        public override double Price { get; set; } = 100;
        public override int Damage { get; set; } = 40;

        public override void Shoot(Player playerToShoot, bool additinoalFeaturesEnabled = false)
        {
            playerToShoot.Health -= Damage;
        }
    }
}
