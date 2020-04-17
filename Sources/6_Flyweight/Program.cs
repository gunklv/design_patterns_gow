using Flyweight.Characters;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main()
        {
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                Character character = factory.GetCharacter(c);
                character.Display();
            }

            Console.ReadKey();
        }
    }
}
