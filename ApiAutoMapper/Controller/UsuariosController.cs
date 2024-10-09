using ApiAutoMapper.DTOs;
using ApiAutoMapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAutoMapper.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UsuariosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioDto> ObtenerUsuario(int id)
        {
            // Simular la obtención de un usuario (en una aplicación real, obtener de la base de datos)
            var usuario = new Usuario { Id = id, Nombre = "Juan Pérez" };

            // Mapear a UsuarioDto
            var usuarioDto = _mapper.Map<UsuarioDto>(usuario);

            return Ok(usuarioDto);
        }
    }
}
