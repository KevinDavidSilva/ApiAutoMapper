using ApiAutoMapper.DTOs;
using ApiAutoMapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAutoMapper.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ProductosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductoDto> ObtenerProducto(int id)
        {
            // Simular la obtención de un producto (en una aplicación real, obtener de la base de datos)
            var producto = new Producto { Id = id, Nombre = "Laptop", Precio = 999.99m };

            // Mapear a ProductoDto
            var productoDto = _mapper.Map<ProductoDto>(producto);

            return Ok(productoDto);
        }
    }
}
