using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRecipesWebApi.Domain.Models;
using EasyRecipesWebApi.Domain.Services;
using EasyRecipesWebApi.Persistence.Contexts;
using EasyRecipesWebApi.Resources;
using Microsoft.AspNetCore.Mvc;
using EasyRecipesWebApi.Extensions;

namespace EasyRecipesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        private readonly IMapper _mapper;

        public IngredientsController(IIngredientService ingredientService, IMapper mapper)
        {
            _ingredientService = ingredientService;
            _mapper = mapper;
        }

        // GET api/ingredients
        [HttpGet]
        public async Task<IEnumerable<Ingredient>> GetAllIngredientsAsync()
        {
            var ingredients = await _ingredientService.GetAllIngredientsAsync();
            return ingredients;
        }

        public async Task<IActionResult> PostIngredientAsync([FromBody] SaveIngredientResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessage());

            _mapper.Map<SaveIngredientResource, Ingredient>(resource);

        }

        //// GET api/ingredients/id
        //[HttpGet("{id}")]
        //public ActionResult<Ingredient> Get(int id)
        //{
        //    var ingredient = _context.Ingredients.Find(id);

        //    if (ingredient == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(ingredient);
        //}

        //// POST api/ingredients
        //[HttpPost]
        //public ActionResult<Ingredient> Post(Ingredient ingredient)
        //{
        //    _context.Ingredients.Add(ingredient);
        //    _context.SaveChanges();

        //    return CreatedAtAction(nameof(Get), new Ingredient{ Id = ingredient.Id }, ingredient);
        //}

        // PUT api/ingredients/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/ingredients/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
