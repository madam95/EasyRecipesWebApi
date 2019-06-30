using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRecipesWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyRecipesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly EasyRecipesContext _context;

        public IngredientsController(EasyRecipesContext context)
        {
            _context = context;
        }

        // GET api/ingredients
        [HttpGet]
        public ActionResult<IEnumerable<Ingredient>> GetIngredients()
        {
            return _context.Ingredients.ToList();
        }

        // GET api/ingredients/id
        [HttpGet("{id}")]
        public ActionResult<Ingredient> GetIngredient(int id)
        {
            var ingredient = _context.Ingredients.Find(id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return Ok(ingredient);
        }

        // POST api/ingredients
        [HttpPost]
        public ActionResult<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();

            return CreatedAtAction("GetIngredient", new Ingredient{Id = ingredient.Id}, ingredient);
        }

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
