using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace Program.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase 
    {
        List<Pokemon> Pokemons = new List<Pokemon>()
        {
            new Pokemon(){Name = Ligma}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Pokemons[0]);
        }
        [HttpPut]
        public ActionResult Put(Pokemon pokemon)
        {
            pokemon.add pokemon;
        }


    }
}
