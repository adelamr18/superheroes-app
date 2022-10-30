using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApi.Models;


namespace SuperHeroApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SuperHeroController : Controller
    {

        private static List<SuperHero> heroes = new List<SuperHero>
            {
                new SuperHero {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName="Parker",
                    Place ="New York City"
                }
            };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            
            return Ok(heroes);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {

            heroes.Add(hero);
            return Ok(heroes);

        }

    }
}

