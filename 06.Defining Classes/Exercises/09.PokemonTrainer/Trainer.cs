using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string trainerName, string pokemonName, string pokemonElement, int pokemonHealth)
        {
            this.Name = trainerName;
            this.NumberOfBadges = 0;
            this.Pokemons = new();

            Pokemon pokemon = new(pokemonName, pokemonElement, pokemonHealth);
            this.Pokemons.Add(pokemon);
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void DecreaseHealth()
        {
            this.Pokemons.ForEach(p =>
            {
                p.Health -= 10;
            });

            this.Pokemons.RemoveAll(pokemon => pokemon.Health <= 0);
        }
    }
}
