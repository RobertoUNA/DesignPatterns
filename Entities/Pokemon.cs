namespace Entities
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class LegendaryPokemon : Pokemon{ }

    public class PseudoLegendaryPokemon : Pokemon { }

    public class RegularPokemon : Pokemon { }
}
