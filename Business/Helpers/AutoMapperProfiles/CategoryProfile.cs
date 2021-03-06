using AutoMapper;
using Business.Handlers.Categories.Commands;
using Entities.Concrete;
using Entities.Dtos.Categories;

namespace Business.Helpers.AutoMapperProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, DeleteCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
        }
    }
}