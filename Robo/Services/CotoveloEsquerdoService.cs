using Robo.RoboCotovelo;
using Robo.Interfaces;

namespace Robo.Services
{
    public class CotoveloEsquerdoService : ICotoveloEsquerdoService
    {
        private CotoveloEsquerdo cotoveloEsquerdo;

        public CotoveloEsquerdoService()
        {
            cotoveloEsquerdo = Singleton<CotoveloEsquerdo>.Instance();
        }

        public void MovimentoEmRepouso()
        {

            cotoveloEsquerdo.RealizaMovimentoEmRepouso();
        }

        public void MovimentoLevementeContraido()
        {
            cotoveloEsquerdo.RealizaMovimentoLevementeContraido();
        }

        public void MovimentoContraido()
        {
            cotoveloEsquerdo.RealizaMovimentoContraido();
        }

        public void MovimentoFortementeContraido()
        {
            cotoveloEsquerdo.RealizaMovimentoFortementeContraido();
        }
    }
}
