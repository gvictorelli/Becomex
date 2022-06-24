using Microsoft.AspNetCore.Mvc;
using Robo.Interfaces;

namespace Robo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PulsoDireitoController : ControllerBase
    {

        private readonly ILogger<PulsoDireitoController> _logger;
        private readonly IPulsoDireitoService _pulsoDireitoService;

        public PulsoDireitoController(ILogger<PulsoDireitoController> logger, 
            IPulsoDireitoService PulsoDireitoService)
        {
            _logger = logger;
            _pulsoDireitoService = PulsoDireitoService;
        }

        [HttpPost("RotacaoMenos90Graus")]
        public void RotacaoMenos90Graus()
        {
            _pulsoDireitoService.MovimentoMenos90Graus();
        }

        [HttpPost("RotacaoMenos45Graus")]
        public void RotacaoMenos45Graus()
        {
            _pulsoDireitoService.MovimentoMenos45Graus();
        }

        [HttpPost("EmRepouso")]
        public void EmRepouso()
        {
            _pulsoDireitoService.MovimentoEmRepouso();
        }

        [HttpPost("Rotacao45Graus")]
        public void Rotacao45Graus()
        {
            _pulsoDireitoService.Movimento45Graus();
        }

        [HttpPost("Rotacao90Graus")]
        public void Rotacao90Graus()
        {
            _pulsoDireitoService.Movimento90Graus();
        }

        [HttpPost("Rotacao135Graus")]
        public void Rotacao135Graus()
        {
            _pulsoDireitoService.Movimento135Graus();
        }

        [HttpPost("Rotacao180Graus")]
        public void Rotacao180Graus()
        {
            _pulsoDireitoService.Movimento180Graus();
        }
    }
}