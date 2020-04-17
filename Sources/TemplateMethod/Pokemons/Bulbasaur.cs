namespace TemplateMethod.Pokemons
{
    public class Bulbasaur : Pokemon
    {
        public override string Name { get; set; } = "Bulbasaur";
        public override Type Type { get; set; } = Type.Grass;

        public override int AttackPower { get; set; } = 11;
        public override int Health { get; set; } = 95;
        
        protected override int calculateDamage(Pokemon enemy)
        {
            var multiplier = 1.0;

            if (enemy.Type == Type.Water)
            {
                multiplier = 2.0;
            }
            else if (enemy.Type == Type.Fire)
            {
                multiplier = 0.8;
            }
            else if (enemy.Type == Type.Grass)
            {
                multiplier = 1.0;
            }

            return (int)multiplier * AttackPower;
        }
    }
}
