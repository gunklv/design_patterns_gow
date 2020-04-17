using Strategy.Weapons;
using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            var character = new Character();
            var enemy = new Enemy();

            character.Attack(enemy);
            character.ChangeWeapon(new Mace());
            character.Attack(enemy);
            character.ChangeWeapon(new Lance());
            character.Attack(enemy);

            Console.ReadLine();
        }
    }
}
