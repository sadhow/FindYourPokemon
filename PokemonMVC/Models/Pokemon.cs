using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PokemonMVC.Models
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }
       
        [JsonProperty("base_experience")]
        public int? BaseExperience { get; set; }

        [JsonProperty("types")]
        public List<PokemonType> Types { get; set; }

        [JsonProperty("stats")]
        public List<PokemonStat> Stats { get; set; } 
        
        [JsonProperty("abilities")]
        public List<PokemonStat> Abilities { get; set; }

        [JsonProperty("moves")]
        public List<PokemonMove> Moves { get; set; }

        [JsonProperty("species")]
        public PokemonSpecies Species { get; set; }
    }

    public class Sprites
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("other")]
        public OtherSprites Other { get; set; }
    }
    public class OtherSprites
    {
        [JsonProperty("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }
    public class PokemonType
    {
        [JsonProperty("types")]
        public TypeDetail Type { get; set; }
    }
   
    public class TypeDetail
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PokemonStat
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

        [JsonProperty("stat")]
        public StatDetail Stat { get; set; }
    }

    public class StatDetail
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PokemonMove
    {
        [JsonProperty("move")]
        public MoveDetail Move { get; set; }
    }

    public class MoveDetail
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PokemonSpecies
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}