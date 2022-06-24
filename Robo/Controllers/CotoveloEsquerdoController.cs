using Microsoft.AspNetCore.Mvc;
using Robo.Interfaces;

namespace Robo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CotoveloEsquerdoController : ControllerBase
    {

        private readonly ILogger<CotoveloEsquerdoController> _logger;
        private readonly ICotoveloEsquerdoService _cotoveloEsquerdoService;

        public CotoveloEsquerdoController(ILogger<CotoveloEsquerdoController> logger, 
            ICotoveloEsquerdoService cotoveloEsquerdoService)
        {
            _logger = logger;
            _cotoveloEsquerdoService = cotoveloEsquerdoService;
        }

        [HttpPost("EmRepouso")]
        public void EmRepouso()
        {
            _cotoveloEsquerdoService.MovimentoEmRepouso();
        }

        [HttpPost("MovimentoLevementeContraido")]
        public void MovimentoLevementeContraido()
        {
            _cotoveloEsquerdoService.MovimentoLevementeContraido();
        }

        [HttpPost("MovimentoContraido")]
        public void MovimentoContraido()
        {
            _cotoveloEsquerdoService.MovimentoContraido();
        }

        [HttpPost("MovimentoFortementeContraido")]
        public void MovimentoFortementeContraido()
        {
            _cotoveloEsquerdoService.MovimentoFortementeContraido();
        }
    }
}