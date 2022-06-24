using Robo.Cabeca;

namespace Robo.States.Cabeca.Inclinacao
{
    public class ParaBaixo : EstadoCabecaInclinacao
    {
        private static string ERROR_MESSAGE = "Sistema Corrompido";

        public void EmRepouso(CabecaInclinacao cabeca)
        {
            cabeca.EstadoAtual = new EmRepouso();
        }

        public void RealizaMovimentoParaBaixo(CabecaInclinacao cabeca)
        {
            cabeca.EstadoAtual = new ParaBaixo();
            cabeca.Descricao = "ParaBaixo";
        }

        public void RealizaMovimentoParaCima(CabecaInclinacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }
    }
}
