using System;

namespace Flyweight.Characters
{
    class CharacterB : Character
    {
        public CharacterB()
        {
            this.symbol = 'B';
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
