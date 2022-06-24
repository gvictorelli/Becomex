using Microsoft.AspNetCore.Mvc;
using Robo.Interfaces;

namespace Robo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabecaInclinacaoController : ControllerBase
    {
        private readonly ICabecaInclinacaoService _cabecaInclinacaoService;

        public CabecaInclinacaoController(ICabecaInclinacaoService cabecaInclinacaoService)
        {
            _cabecaInclinacaoService = cabecaInclinacaoService;
        }

        [HttpPost("MovimentoParaCima")]
        public void MovimentoParaCima()
        {
            _cabecaInclinacaoService.MovimentoParaCima();
        }

        [HttpPost("EmRepouso")]
        public void EmRepouso()
        {
            _cabecaInclinacaoService.MovimentoEmRepouso();
        }

        [HttpPost("MovimentoParaBaixo")]
        public void MovimentoParaBaixo()
        {
            _cabecaInclinacaoService.MovimentoParaBaixo();
        }
    }
}