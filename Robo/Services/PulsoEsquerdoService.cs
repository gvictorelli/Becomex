using Robo.RoboCotovelo;
using Robo.Interfaces;
using Robo.Pulso;

namespace Robo.Services
{
    public class PulsoEsquerdoService : IPulsoEsquerdoService
    {
        private PulsoEsquerdo pulsoEsquerdo;
        private CotoveloEsquerdo cotoveloEsquerdo;
        public PulsoEsquerdoService()
        {
            pulsoEsquerdo = Singleton<PulsoEsquerdo>.Instance();
            cotoveloEsquerdo = Singleton<CotoveloEsquerdo>.Instance();
            ValidaEstadoCotovelo();
        }

        public void Movimento135Graus()
        {
            pulsoEsquerdo.RealizaMovimento135Graus();
        }

        public void Movimento180Graus()
        {
            pulsoEsquerdo.RealizaMovimento180Graus();
        }

        public void Movimento45Graus()
        {
            pulsoEsquerdo.RealizaMovimento45Graus();
        }

        public void Movimento90Graus()
        {
            pulsoEsquerdo.RealizaMovimento90Graus();
        }

        public void MovimentoEmRepouso()
        {
            pulsoEsquerdo.RealizaMovimentoEmRepouso();
        }

        public void MovimentoMenos45Graus()
        {
            pulsoEsquerdo.RealizaMovimentoMenos45Graus();
        }

        public void MovimentoMenos90Graus()
        {
            pulsoEsquerdo.RealizaMovimentoMenos90Graus();
        }

        private void ValidaEstadoCotovelo()
        {
            if (cotoveloEsquerdo.Descricao != "FortementeContraido")
                throw new Exception("Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído!");
        }
    }
}
