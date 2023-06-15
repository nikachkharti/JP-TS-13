namespace JP_TS_13_MainConnsole.Shooter.Weapons
{
    public class Usp : ShootableWeapon
    {
        public override string Name { get; set; } = "Usp";
        public override double Price { get; set; } = 50;
        public override int Damage { get; set; } = 20;
        public bool IsMuted { get; set; } = false;

        public override void Shoot(Player playerToShoot, bool additinoalFeaturesEnabled = false)
        {
            if (additinoalFeaturesEnabled)
            {
                IsMuted = true;
            }
            else
            {
                IsMuted = false;
            }

            playerToShoot.Health -= Damage;
        }
    }
}
