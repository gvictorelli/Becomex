using Microsoft.AspNetCore.Mvc;
using Robo.Interfaces;

namespace Robo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CotoveloDireitoController : ControllerBase
    {
        private readonly ICotoveloDireitoService _cotoveloDireitoService;

        public CotoveloDireitoController(ICotoveloDireitoService cotoveloDireitoService)
        {
            _cotoveloDireitoService = cotoveloDireitoService;
        }

        [HttpPost("EmRepouso")]
        public void EmRepouso()
        {
            _cotoveloDireitoService.MovimentoEmRepouso();
        }

        [HttpPost("MovimentoLevementeContraido")]
        public void MovimentoLevementeContraido()
        {
            _cotoveloDireitoService.MovimentoLevementeContraido();
        }

        [HttpPost("MovimentoContraido")]
        public void MovimentoContraido()
        {
            _cotoveloDireitoService.MovimentoContraido();
        }

        [HttpPost("MovimentoFortementeContraido")]
        public void MovimentoFortementeContraido()
        {
            _cotoveloDireitoService.MovimentoFortementeContraido();
        }
    }
}