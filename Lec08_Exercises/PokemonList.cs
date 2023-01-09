using System;
using System.Linq;
namespace Lec08_Exercises
{
	public class PokemonList
	{
		public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

		public PokemonList()
		{
		}

		public void Add(Pokemon pokemon)
		{
			this.Pokemons.Add(pokemon);
		}
	}
}

