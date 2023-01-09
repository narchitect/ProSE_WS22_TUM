using System;
namespace Lec08_Exercises
{
	public class Pokemon
	{
		public int Id { get; set; }
		public int dex { get; set; }
		public string name { get; set; }
		public List<string> types { get; set; }
		

		public Pokemon(string name, int dex, List<string> types )
		{
			this.dex = dex;
			this.name = name;
			this.types = types;
		}

	}
}

