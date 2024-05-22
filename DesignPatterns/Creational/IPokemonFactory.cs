using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public interface IPokemonFactory
    {
        public Pokemon CreatePokemon();
    }

    public class RandomPokemonFactory : IPokemonFactory
    {
        public Pokemon CreatePokemon()
        {
            //Generates a random pokemon
            return new Pokemon();
            
        }
    }

    public class LegendaryPokemonFactory : IPokemonFactory
    {
        public Pokemon CreatePokemon()
        {
            //Generates a legendary pokemon
            return new Pokemon();

        }
    }
}
