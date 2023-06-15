namespace JP_TS_13_MainConnsole.Shooter.Weapons
{
    public class Glock : ShootableWeapon
    {
        public override string Name { get; set; } = "Glock";
        public override double Price { get; set; } = 50;
        public override int Damage { get; set; } = 20;

        public override void Shoot(Player playerToShoot, bool additinoalFeaturesEnabled = false)
        {
            if (additinoalFeaturesEnabled)
            {
                playerToShoot.Health -= Damage * 3;
            }
            else
            {
                playerToShoot.Health -= Damage;
            }
        }
    }
}
