using Robo.Cabeca;

namespace Robo.States.Cabeca.Inclinacao
{
    public class EmRepouso : EstadoCabecaInclinacao
    {

        public void RealizaMovimentoParaBaixo(CabecaInclinacao cabeca)
        {
            cabeca.EstadoAtual = new ParaBaixo();
            cabeca.Descricao = "ParaBaixo";
        }

        public void RealizaMovimentoParaCima(CabecaInclinacao cabeca)
        {
            cabeca.EstadoAtual = new ParaCima();
        }

        void EstadoCabecaInclinacao.EmRepouso(CabecaInclinacao cabeca)
        {
            cabeca.EstadoAtual = new EmRepouso();
        }
    }
}
