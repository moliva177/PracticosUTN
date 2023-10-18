using APIFechas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFechas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FechaController : ControllerBase
    {
        [HttpGet]
        public Fecha Get() => new Fecha();

        [HttpGet("dia")]
        public int GetNumeroDia() => new Fecha().DiaSemana;
    }
}
