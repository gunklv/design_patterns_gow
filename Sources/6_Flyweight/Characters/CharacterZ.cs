using System;

namespace Flyweight.Characters
{
    class CharacterZ : Character
    {
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.height = 100;
            this.width = 120;
        }

        public override void Display(string color)
        {
            this.color = color;
            Console.WriteLine(this.symbol +
              " (color " + this.color + ")");
        }
    }
}
