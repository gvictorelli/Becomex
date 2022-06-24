using Robo.Cabeca;
using Robo.Interfaces;

namespace Robo.Services
{
    public class CabecaInclinacaoService : ICabecaInclinacaoService
    {
        private CabecaInclinacao cabecaInclinacao;
        
        public CabecaInclinacaoService()
        {
            cabecaInclinacao = Singleton<CabecaInclinacao>.Instance();
        }

        public void MovimentoEmRepouso()
        {
            cabecaInclinacao.RealizaMovimentoEmRepouso();
        }

        public void MovimentoParaBaixo()
        {
            cabecaInclinacao.RealizaMovimentoParaBaixo();
        }

        public void MovimentoParaCima()
        {
            cabecaInclinacao.RealizaMovimentoParaCima();
        }
    }
}
