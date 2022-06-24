using Robo.RoboCotovelo;
using Robo.Interfaces;

namespace Robo.Services
{
    public class CotoveloDireitoService : ICotoveloDireitoService
    {
        private CotoveloDireito cotoveloDireito;
        public CotoveloDireitoService()
        {
            cotoveloDireito = Singleton<CotoveloDireito>.Instance();
        }

        public void MovimentoEmRepouso()
        {
            cotoveloDireito.RealizaMovimentoEmRepouso();
        }

        public void MovimentoLevementeContraido()
        {
            cotoveloDireito.RealizaMovimentoLevementeContraido();
        }

        public void MovimentoContraido()
        {
            cotoveloDireito.RealizaMovimentoContraido();
        }

        public void MovimentoFortementeContraido()
        {
            cotoveloDireito.RealizaMovimentoFortementeContraido();
        }
    }
}
