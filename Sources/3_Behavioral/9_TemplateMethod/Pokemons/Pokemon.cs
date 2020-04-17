namespace TemplateMethod.Pokemons
{
    public abstract class Pokemon
    {
        public abstract string Name { get; set; }

        public abstract Type Type { get; set; }
        public abstract int AttackPower { get; set; }
        public abstract int Health { get; set; }

        public void attack(Pokemon enemyPokemon)
        {
            //check the status of the field
            //check enemy dodge rate
            //chosing ability

            var damage = calculateDamage(enemyPokemon);

            //some other moves, dunno
            //...
            enemyPokemon.Health -= damage;

            System.Console.WriteLine($"{Name} attacked {enemyPokemon.Name}! Remaining hp: {enemyPokemon.Health}");
        }

        protected abstract int calculateDamage(Pokemon enemy);
    }

    public enum Type
    {
        Normal,
        Grass,
        Fire,
        Water
    }
}
