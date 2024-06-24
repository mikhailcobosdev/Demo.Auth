using Demo.Auth.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Auth.Servicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuentaController : ControllerBase
    {

        private readonly ILogger<CuentaController> _logger;
        INegocioCuenta _negocioCuenta;

        public CuentaController(ILogger<CuentaController> logger, INegocioCuenta negocioCuenta)
        {
            _logger = logger;
            _negocioCuenta = negocioCuenta;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
           return Ok(_negocioCuenta.CrearCuenta());
        }
    }
}
