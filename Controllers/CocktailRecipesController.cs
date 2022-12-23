using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
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
        private readonly ICocktailRecipeRepository _cocktailRecipeRepository;

        public CocktailRecipesController(ICocktailRecipeRepository cocktailRecipeRepository)
        {
            _cocktailRecipeRepository = cocktailRecipeRepository;
        }

        // GET: api/<CocktailRecipesController>
        [HttpGet]
        public IEnumerable<CocktailRecipe> GetAll()
        {

            var result = _cocktailRecipeRepository.GetAllCocktailRecipe();
            return result;
        }

        // GET api/<CocktailRecipesController>/5
        [HttpGet("{id}")]
        public CocktailRecipe Get(int id)
        {
            var result = _cocktailRecipeRepository.GetCocktailRecipeById(id);
            return result;
        }

        // POST api/<CocktailRecipesController>
        [HttpPost]
        [Authorize]
        public void Post([FromBody] CocktailRecipe cocktailRecipe)
        {
            _cocktailRecipeRepository.CreateCocktailRecipe(cocktailRecipe);
        }

        // PUT api/<CocktailRecipesController>
        [HttpPut]
        public void Put([FromBody] CocktailRecipe cocktailRecipe)
        {
            _cocktailRecipeRepository.UpdateCocktailRecipe(cocktailRecipe);
        }

        // DELETE api/<CocktailRecipesController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _cocktailRecipeRepository.DeleteCocktailRecipe(id);
        }
    }
}
