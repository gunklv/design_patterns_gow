using Strategy.Weapons;

namespace Strategy
{
    public class Character
    {
        private Weapon _currentWeapon;

        public Character()
        {
            _currentWeapon = new Sword();
        }

        public void Attack(Enemy enemy)
        {
            enemy.Health -= _currentWeapon.AttackPower;
            System.Console.WriteLine($"Attacked by: {_currentWeapon.Name}! Enemy health: {enemy.Health}");
        }

        public void ChangeWeapon(Weapon weapon)
        {
            _currentWeapon = weapon;
        }
    }
}
