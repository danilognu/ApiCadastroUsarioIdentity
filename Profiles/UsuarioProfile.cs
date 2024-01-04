using AutoMapper;
using LoginUsuarioAPI.Data.Dtos;
using LoginUsuarioAPI.Models;

namespace LoginUsuarioAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
