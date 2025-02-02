using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PokemonMVC.Models;
using PokemonMVC.Services;

namespace PokemonMVC.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        private readonly PokemonService _service = new PokemonService();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string pokemonName)
        {
            if (string.IsNullOrWhiteSpace(pokemonName))
            {
                ViewBag.Error = "Plase Enter a Pokemon Name";
                return View("Index");
            }

            var pokemon = _service.GetPokemon(pokemonName);
            if (pokemon == null)
            {
                ViewBag.Error = "Pokemon Not Found";
                return View("Index");
            }

            return View("Details", pokemon);
        }

        public ActionResult Details(Pokemon pokemon)
        {
            return View(pokemon);
        }
    }
}