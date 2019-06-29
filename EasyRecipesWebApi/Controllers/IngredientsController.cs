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

        // GET api/ingredients
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetIngredients()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/ingredients/id
        [HttpGet("{id}")]
        public ActionResult<string> GetIngredient(int id)
        {
            return "value";
        }

        // POST api/ingredients
        [HttpPost]
        public void Create([FromBody] string value)
        {
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
