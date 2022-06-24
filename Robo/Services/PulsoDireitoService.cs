using Robo.RoboCotovelo;
using Robo.Interfaces;
using Robo.Pulso;

namespace Robo.Services
{
    public class PulsoDireitoService : IPulsoDireitoService
    {
        private PulsoDireito pulsoDireito;
        private CotoveloDireito cotoveloDireito;
        public PulsoDireitoService()
        {
            pulsoDireito = Singleton<PulsoDireito>.Instance();
            cotoveloDireito = Singleton<CotoveloDireito>.Instance();
            ValidaEstadoCotovelo();
        }

        public void Movimento135Graus()
        {
            pulsoDireito.RealizaMovimento135Graus();
        }

        public void Movimento180Graus()
        {
            pulsoDireito.RealizaMovimento180Graus();
        }

        public void Movimento45Graus()
        {
            pulsoDireito.RealizaMovimento45Graus();
        }

        public void Movimento90Graus()
        {
            pulsoDireito.RealizaMovimento90Graus();
        }

        public void MovimentoEmRepouso()
        {
            pulsoDireito.RealizaMovimentoEmRepouso();
        }

        public void MovimentoMenos45Graus()
        {
            pulsoDireito.RealizaMovimentoMenos45Graus();
        }

        public void MovimentoMenos90Graus()
        {
            pulsoDireito.RealizaMovimentoMenos90Graus();
        }

        private void ValidaEstadoCotovelo()
        {
            if (cotoveloDireito.Descricao != "FortementeContraido")
                throw new Exception("Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído!");
        }
    }
}
