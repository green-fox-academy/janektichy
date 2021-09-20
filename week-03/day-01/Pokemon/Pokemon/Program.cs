using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonOfAsh = InitializePokemon();


            Pokemon wildPokemon = new Pokemon("Oddish", "grass", "water");


            for (int i = 0; i < pokemonOfAsh.Count; i++)
            {
                if (pokemonOfAsh[i].IsEffectiveAgainst(wildPokemon))
                {
                    Console.WriteLine("I choose you, " + pokemonOfAsh[i].Name);
                }
            }
        }

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Bulbasaur", "grass", "water"),
                new Pokemon("Pikachu", "electric", "water"),
                new Pokemon("Charizard", "fire", "grass"),
                new Pokemon("Pidgeot", "flying", "fighting"),
                new Pokemon("Kingler", "water", "fire")
            };
        }
    }
}
