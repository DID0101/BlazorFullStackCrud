﻿
using BlazorFullStackCrud.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<Comic> comics = new List<Comic> {
            new Comic { Id = 1,Name ="Marvel"},
            new Comic { Id = 2,Name ="DC"}
        };
        public static List<SuperHero> heroes = new List<SuperHero> {
            new SuperHero {
                Id = 1,
                FirstName ="Peter",
                LastName ="Parker",
                HeroNAme = "Spiderman",
                Comic = comics[0]
            },
            new SuperHero {
                Id = 2,
                FirstName ="Bruce",
                LastName ="Wayne",
                HeroNAme = "Batman",
                Comic = comics[1]
            },
        };
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeros()
        {
          return Ok(heroes);  
        }
        [HttpGet("{id}")]
       
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var  hero = heroes.FirstOrDefault(h=> h.Id == id);
            if (hero == null)
            {
                return NotFound("Soruu Hero not found");
            }
            return Ok(hero);
        }
    }
}
