using AutoMapper;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.DTO;

namespace Todo.Infrastructure.Map
{
    /// <summary>
    /// Defines the Data-to-object mappings. specifies how to map between domain entities and DTOs.
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ToDo, TodoResponseDTO>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UpdateTaskRequestDTO, ToDo>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<TodoRequestDTO, ToDo>();
         
        }
    }
}
