using System;
using System.Linq;
using System.Xml;

namespace Lec08_Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "./pokedex.xml";
            var pokemonList = HelpFunction.ImportXML(path);

            var electricPokemon = from p in pokemonList.Pokemons
                                  where p.types.Contains("ELECTRIC")
                                  orderby p.name
                                  select p;

            foreach (var p in electricPokemon)
            {
                Console.WriteLine(p.name);
                DatabaseFramework.AddPokemon(p);
            }     
        }

        
    }
}