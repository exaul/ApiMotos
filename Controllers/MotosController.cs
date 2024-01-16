using APIMotos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIMotos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotosController : ControllerBase
    {
        private static List<Motos> _motos = new List<Motos>
        {
            new Motos
            {
                Id = 1,
                Marca = "Honda",
                Modelo = "CB1 Star 2023"

            },
            new Motos
            {
                Id = 2,
                Marca = "BMW",
                Modelo = "F 900R"

            },
            new Motos
            {
                Id = 3,
                Marca = "Yamaha",
                Modelo = "YBR-125"

            },
        };

        [HttpGet]

        public IEnumerable<Motos> GetAllMotos() 
        { 
            return _motos;
        
        }

    }
}
