using Robo.Cabeca;
using Robo.Interfaces;

namespace Robo.Services
{
    public class CabecaRotacaoService : ICabecaRotacaoService
    {
        private CabecaRotacao cabecaRotacao;
        private CabecaInclinacao cabecaInclinacao;

        public CabecaRotacaoService()
        {
            cabecaRotacao = Singleton<CabecaRotacao>.Instance();
            cabecaInclinacao = Singleton<CabecaInclinacao>.Instance();
            ValidaInclinacaoCabeca();
        }

        public void Movimento45Graus()
        {
            cabecaRotacao.RealizaMovimento45Graus();
        }

        public void Movimento90Graus()
        {
            cabecaRotacao.RealizaMovimento90Graus();
        }

        public void MovimentoEmRepouso()
        {
            cabecaRotacao.RealizaMovimentoEmRepouso();
        }

        public void MovimentoMenos45Graus()
        {
            cabecaRotacao.RealizaMovimentoMenos45Graus();
        }

        public void MovimentoMenos90Graus()
        {
            cabecaRotacao.RealizaMovimentoMenos90Graus();
        }

        public void ValidaInclinacaoCabeca()
        {
            if (cabecaInclinacao.Descricao == "ParaBaixo")
                throw new Exception("Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo!");
        }
    }
}
