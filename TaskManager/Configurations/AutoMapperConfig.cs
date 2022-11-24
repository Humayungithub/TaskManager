using AutoMapper;
using TaskManager.DTO;
using TaskManager.Models;

namespace TaskManager.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreatePersonDto, Person>().ReverseMap();
            CreateMap<UpdatePersonDto, Person>().ReverseMap();
            CreateMap<PersonReadOnlyDto, Person>().ReverseMap();
        }
    }
}
