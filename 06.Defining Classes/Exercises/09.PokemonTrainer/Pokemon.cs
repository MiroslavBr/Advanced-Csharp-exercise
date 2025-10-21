using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Pokemon
    {
        public Pokemon(string pokemonName, string pokemonElement, int pokemonHealth)
        {
            Name = pokemonName;
            Element = pokemonElement;
            Health = pokemonHealth;
        }
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
    }
}
