using System.ComponentModel.DataAnnotations;
using EasyRecipesWebApi.Domain.Models;

namespace EasyRecipesWebApi.Resources
{
    public class SaveIngredientResource
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}