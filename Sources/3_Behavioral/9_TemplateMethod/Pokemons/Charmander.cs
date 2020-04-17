namespace TemplateMethod.Pokemons
{
    public class Charmander : Pokemon
    {
        public override string Name { get; set; } = "Charmander";
        public override Type Type { get; set; } = Type.Fire;

        public override int AttackPower { get; set; } = 12;
        public override int Health { get; set; } = 90;

        protected override int calculateDamage(Pokemon enemy)
        {
            var multiplier = 1.0;

            if (enemy.Type == Type.Grass)
            {
                multiplier = 2.0;
            }
            else if (enemy.Type == Type.Water)
            {
                multiplier = 0.8;
            }
            else if (enemy.Type == Type.Fire)
            {
                multiplier = 1.0;
            }

            return (int)multiplier * AttackPower;
        }
    }
}
