﻿namespace JP_TS_13_MainConnsole.Shooter.Weapons
{
    public class M4 : ShootableWeapon
    {
        public override string Name { get; set; } = "M4";
        public override double Price { get; set; } = 100;
        public override int Damage { get; set; } = 40;
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
