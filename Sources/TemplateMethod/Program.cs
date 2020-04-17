using System;
using TemplateMethod.Pokemons;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            var charmander = new Charmander();
            var bulbasaur = new Bulbasaur();

            charmander.attack(bulbasaur);
            bulbasaur.attack(charmander);

            Console.ReadLine();
        }
    }
}
