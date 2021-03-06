using AutoMapper;
using Business.Handlers.Colors.Commands;
using Entities.Concrete;
using Entities.Dtos.Colors;

namespace Business.Helpers.AutoMapperProfiles
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<Color, CreateColorCommand>().ReverseMap();
            CreateMap<Color, DeleteColorCommand>().ReverseMap();
            CreateMap<Color, UpdateColorCommand>().ReverseMap();
        }
    }
}
