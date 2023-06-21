using AutoMapper;
using GeminApi.Domain.Dtos;
using GeminApi.Domain.models;

namespace GeminApi.Domain.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Usuario, UsuarioCreacionDto>().ReverseMap();
        }
    }
}
