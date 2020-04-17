using System;

namespace Flyweight.Characters
{
    class CharacterA : Character
    {
        public CharacterA()
        {
            this.symbol = 'A';
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
