using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRecipesWebApi.Domain.Models;
using EasyRecipesWebApi.Resources;

namespace EasyRecipesWebApi.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveIngredientResource, Ingredient>();
        }
    }
}
