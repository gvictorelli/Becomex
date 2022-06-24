using Microsoft.AspNetCore.Mvc;
using Robo.Interfaces;

namespace Robo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabecaRotacaoController : ControllerBase
    {

        private readonly ICabecaRotacaoService _cabecaRotacaoService;

        public CabecaRotacaoController(ICabecaRotacaoService cabecaRotacaoService)
        {
            _cabecaRotacaoService = cabecaRotacaoService;
        }

        [HttpPost("RotacaoMenos90Graus")]
        public void RotacaoMenos90Graus()
        {
            _cabecaRotacaoService.MovimentoMenos90Graus();
        }

        [HttpPost("RotacaoMenos45Graus")]
        public void RotacaoMenos45Graus()
        {
            _cabecaRotacaoService.MovimentoMenos45Graus();
        }

        [HttpPost("EmRepouso")]
        public void EmRepouso()
        {
            _cabecaRotacaoService.MovimentoEmRepouso();
        }

        [HttpPost("Rotacao45Graus")]
        public void Rotacao45Graus()
        {
            _cabecaRotacaoService.Movimento45Graus();
        }

        [HttpPost("Rotacao90Graus")]
        public void Rotacao90Graus()
        {
            _cabecaRotacaoService.Movimento90Graus();
        }
    }
}