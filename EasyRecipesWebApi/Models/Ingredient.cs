using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRecipesWebApi.Models
{
    public class Ingredient
    {
        //TODO Add image property later on

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public MeasurementUnit Unit { get; set; }
    }
}
