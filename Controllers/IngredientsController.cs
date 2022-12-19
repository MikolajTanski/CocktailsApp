﻿using Drinks_app.Models;
using Drinks_app.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Drinks_app.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        // GET: api/<IngredientsController>
        [HttpGet]
        public IEnumerable<Ingredient> Get()
        {
            
            var result = _ingredientService.GetAllIngredient();
            return result;
        }

        // GET api/<IngredientsController>/5
        [HttpGet("{id}")]
        public Ingredient Get(int id)
        {
            var result = _ingredientService.GetIngredientById(id);
            return result;
        }

        // POST api/<IngredientsController>
        [HttpPost]
        [Authorize]
        public void Post([FromBody] Ingredient ingredient)
        {
            _ingredientService.CreateIngredient(ingredient);
        }

        // PUT api/<IngredientsController>
        [HttpPut("{id}")]
        public void Put([FromBody] Ingredient ingredient)
        {
            _ingredientService.CreateIngredient(ingredient);
        }

        // DELETE api/<IngredientsController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _ingredientService.DeleteIngredient(id);
        }
    }
}
