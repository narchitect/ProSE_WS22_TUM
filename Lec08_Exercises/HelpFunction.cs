using System;
using System.Xml;

namespace Lec08_Exercises
{
	public class HelpFunction
	{
		public HelpFunction()
		{
		}

        public static PokemonList ImportXML(string path)
        {
            var pocketmonXML = new XmlDocument();
            pocketmonXML.Load(path);

            var pokemonList = new PokemonList();

            var pokemonNodes = pocketmonXML.DocumentElement.ChildNodes;

            foreach (XmlNode pokemonNode in pokemonNodes)
            {
                var pokemon = HelpFunction.GetPokemonInfo(pokemonNode);

                pokemonList.Add(pokemon);
            }

            return pokemonList;

        }

        public static Pokemon GetPokemonInfo(XmlNode pokemon)
        {
            string name = " ";
            List<string> types = new List<string>();
            int dex = 0;

            foreach (XmlNode node in pokemon)
            {
                if (node.Name == "species")
                {
                    name = node.InnerText;
                }

                // select multiple values of the child nodes with same name. 
                else if (node.Name == "types")
                {

                    for ( int i = 0; i < node.ChildNodes.Count; i ++ )
                    { 
                        types.Add(node.ChildNodes[i].InnerText);  
                    }
                }

                else if (node.Name == "dex")
                {
                    dex = Convert.ToInt32(node.InnerText);
                }
            }

            return new Pokemon(name, dex, types);
        }

        
    }
}

