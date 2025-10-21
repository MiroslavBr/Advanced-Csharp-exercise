using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string data = string.Empty;
            Dictionary<string, Trainer> trainers = new();
            while ((data = Console.ReadLine()) != "Tournament")
            {
                string[] dataParts = data.Split();
                //{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}
                string trainerName = dataParts[0];
                string pokemonName = dataParts[1];
                string pokemonElement = dataParts[2];
                int pokemonHealth = int.Parse(dataParts[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new(trainerName, pokemonName, pokemonElement, pokemonHealth);
                    trainers[trainerName] = trainer;
                }
                else
                {
                    Pokemon pokemon = new(pokemonName, pokemonElement, pokemonHealth);
                    trainers[trainerName].Pokemons.Add(pokemon);
                }
            }

            while ((data = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Exists(pokemon => pokemon.Element == data))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.DecreaseHealth();
                    }
                }
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(b => b.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }

        }
    }
}
