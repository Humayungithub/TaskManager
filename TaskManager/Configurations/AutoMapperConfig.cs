using AutoMapper;
using TaskManager.DTO.PersonDto;
using TaskManager.DTO.TaskRequestsDto;
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
            CreateMap<TaskRequestsReadOnlyDto, TaskRequests>().ReverseMap();
            CreateMap<CreateTaskRequestsDto, TaskRequests>().ReverseMap();
            CreateMap<UpdateTaskRequestsDto, TaskRequests>().ReverseMap();
        }
    }
}
