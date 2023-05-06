using AutoMapper;
using System.Runtime.CompilerServices;
using Drinks_app.Models;
using Drinks_app.Models.DTO;

namespace Drinks_app.Services.Helpers.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.ApplicationUser))
                .ReverseMap();
        }
    }

}
