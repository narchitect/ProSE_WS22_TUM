using System;
namespace Lec08_Exercises
{
	public class Pokemon
	{
		public int Id { get; set; }
		public int dex { get; set; }
		public string name { get; set; }
		public string type { get; set; }
		
		private Pokemon() { }

		public Pokemon(string name, int dex, string type )
		{
			this.dex = dex;
			this.name = name;
			this.type = type;
		}

	}
}

