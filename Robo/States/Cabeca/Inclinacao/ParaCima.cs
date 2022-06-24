using Robo.Cabeca;

namespace Robo.States.Cabeca.Inclinacao
{
    public class ParaCima : EstadoCabecaInclinacao
    {
        private static string ERROR_MESSAGE = "Sistema Corrompido";

        public void EmRepouso(CabecaInclinacao cabeca)
        {
            cabeca.EstadoAtual = new EmRepouso();
        }

        public void RealizaMovimentoParaBaixo(CabecaInclinacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaMovimentoParaCima(CabecaInclinacao cabeca)
        {
            cabeca.EstadoAtual = new ParaCima();
        }
    }
}
