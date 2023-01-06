using Drinks_app.Models;
using Drinks_app.Models.DTO;
using Drinks_app.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Drinks_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocktailRecipesController : ControllerBase
    {
        private readonly ICocktailRecipeService _cocktailRecipeService;

        public CocktailRecipesController(ICocktailRecipeService cocktailRecipeService)
        {
            _cocktailRecipeService = cocktailRecipeService;
        }

        // GET: api/<CocktailRecipesController>
        [HttpGet]
        public IEnumerable<CocktailRecipe> GetAll()
        {

            var result = _cocktailRecipeService.GetAllCocktailRecipe();
            return result;
        }

        // GET api/<CocktailRecipesController>/5
        [HttpGet("{id}")]
        public CocktailRecipe Get(int id)
        {
            var result = _cocktailRecipeService.GetCocktailRecipeById(id);
            return result;
        }

        // POST api/<CocktailRecipesController>
        [HttpPost]
        [Authorize]
        public void Post([FromBody] CocktailRecipeDto cocktailRecipeDto)
        {
            _cocktailRecipeService.CreateCocktailRecipe(cocktailRecipeDto);
        }

        // PUT api/<CocktailRecipesController>
        [HttpPut]
        public void Put([FromBody] CocktailRecipeDto cocktailRecipe)
        {
            _cocktailRecipeService.UpdateCocktailRecipe(cocktailRecipe);
        }

        // DELETE api/<CocktailRecipesController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _cocktailRecipeService.DeleteCocktailRecipe(id);
        }
    }
}
