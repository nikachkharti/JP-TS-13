using JP_TS_13_MainConnsole.Shooter.Weapons;

namespace JP_TS_13_MainConnsole.Shooter
{
    public abstract class ShootableWeapon : Weapon
    {
        public abstract void Shoot(Player playerToShoot, bool additinoalFeaturesEnabled = false);
    }
}
