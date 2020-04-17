namespace TemplateMethod.Pokemons
{
    public class Squirtle : Pokemon
    {
        public override string Name { get; set; } = "Squirtle";
        public override Type Type { get; set; } = Type.Water;

        public override int AttackPower { get; set; } = 10;
        public override int Health { get; set; } = 100;

        protected override int calculateDamage(Pokemon enemy)
        {
            var multiplier = 1.0;

            if(enemy.Type == Type.Fire)
            {
                multiplier = 2.0;
            }
            else if(enemy.Type == Type.Grass)
            {
                multiplier = 0.8;
            }
            else if(enemy.Type == Type.Water)
            {
                multiplier = 1.0;
            }

            return (int)multiplier * AttackPower;
        }
    }
}
