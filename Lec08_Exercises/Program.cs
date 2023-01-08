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

            pokemonList.GetPokemon();

        }

        
    }
}