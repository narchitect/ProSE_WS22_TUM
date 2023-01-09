using System;
using Microsoft.EntityFrameworkCore;

namespace Lec08_Exercises
{
	public class PokedexContext : DbContext
	{
		public DbSet<Pokemon> Pokemons { get; set; } 

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source = /Users/kimnayun/Projects/ProSE_WS22_TUM/Lec08_Exercises/PokedexDatabase.db");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

		}

    }
}

