using System;
namespace Lec08_Exercises
{
	public class DatabaseFramework
	{
		public static void AddPokemon(Pokemon pokemon)
		{
			using (var context = new PokedexContext())
			{
				context.Add(pokemon);
				context.SaveChanges();
			}
		}
	}
}

