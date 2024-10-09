using ApiAutoMapper.DTOs;
using ApiAutoMapper.Models;
using AutoMapper;

namespace ApiAutoMapper.Mapper
{
    public class PerfilDeMapeo : Profile
    {
        public PerfilDeMapeo()
        {
            CreateMap<Usuario, UsuarioDto>()
                .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.Nombre));

            CreateMap<Producto, ProductoDto>();
        }

       
       
           
        
    }
}
