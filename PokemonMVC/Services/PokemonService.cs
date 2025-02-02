using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonMVC.Models;
using RestSharp;

namespace PokemonMVC.Services
{
    public class PokemonService
    {
        private readonly RestClient _client;

        public PokemonService() { 
            _client = new RestClient("https://pokeapi.co/api/v2/"); 
        }
        public Pokemon GetPokemon(string name)
        {
            var request = new RestRequest($"pokemon/{name.ToLower()}");
            var response = _client.Get(request);
            if (!response.IsSuccessful) 
                return null;

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Pokemon>(response.Content);
        }

    }
}