using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public byte Image { get; set; }

        public int MeasurementUnitId { get; set; }
        [Required]
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}
