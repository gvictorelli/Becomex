using Microsoft.AspNetCore.Mvc;
using Robo.Interfaces;

namespace Robo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PulsoEsquerdoController : ControllerBase
    {

        private readonly ILogger<PulsoEsquerdoController> _logger;
        private readonly IPulsoEsquerdoService _pulsoEsquerdoService;

        public PulsoEsquerdoController(ILogger<PulsoEsquerdoController> logger, 
            IPulsoEsquerdoService pulsoEsquerdoService)
        {
            _logger = logger;
            _pulsoEsquerdoService = pulsoEsquerdoService;
        }

        [HttpPost("RotacaoMenos90Graus")]
        public void RotacaoMenos90Graus()
        {
            _pulsoEsquerdoService.MovimentoMenos90Graus();
        }

        [HttpPost("RotacaoMenos45Graus")]
        public void RotacaoMenos45Graus()
        {
            _pulsoEsquerdoService.MovimentoMenos45Graus();
        }

        [HttpPost("EmRepouso")]
        public void EmRepouso()
        {
            _pulsoEsquerdoService.MovimentoEmRepouso();
        }

        [HttpPost("Rotacao45Graus")]
        public void Rotacao45Graus()
        {
            _pulsoEsquerdoService.Movimento45Graus();
        }

        [HttpPost("Rotacao90Graus")]
        public void Rotacao90Graus()
        {
            _pulsoEsquerdoService.Movimento90Graus();
        }

        [HttpPost("Rotacao135Graus")]
        public void Rotacao135Graus()
        {
            _pulsoEsquerdoService.Movimento135Graus();
        }

        [HttpPost("Rotacao180Graus")]
        public void Rotacao180Graus()
        {
            _pulsoEsquerdoService.Movimento180Graus();
        }
    }
}