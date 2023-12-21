using AutoMapper;
using System.Xml.Serialization;
using WebApi8.FisstApp.Dto.Create;
using WebApi8.FisstApp.Dto.Get;
using WebApi8.FisstApp.Models;

namespace WebApi8.FisstApp.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMappings();
            GetMappings();            
        }

        private void CreateMappings()
        {
            CreateMap<CreateTodo, Todo>(MemberList.Source);
            CreateMap<CreateSubTask, SubTask>(MemberList.Source);
        }

        private void GetMappings()
        {
            CreateMap<Todo, GetTodo>(MemberList.Destination);
            CreateMap<SubTask, GetSubTask>(MemberList.Destination);
        }
    }
}
