using AutoMapper;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.DTO;

namespace Todo.Infrastructure.Map
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ToDo, TodoResponseDTO>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UpdateTaskRequestDTO, ToDo>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
