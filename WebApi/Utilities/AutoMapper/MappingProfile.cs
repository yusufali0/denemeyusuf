using AutoMapper;
using Entities.Dto;
using Entities.Models;

namespace WebApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<BookDtoForUpdate, Book>();
        }
    }
}
