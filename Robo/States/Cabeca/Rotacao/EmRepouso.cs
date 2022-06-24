using Robo.Cabeca;

namespace Robo.States.Cabeca.Rotacao
{
    public class EmRepouso : EstadoCabecaRotacao
    {
        private static string ERROR_MESSAGE = "Sistema Corrompido";

        public void RealizaRotacaoPara45Graus(CabecaRotacao cabeca)
        {
            cabeca.EstadoAtual = new Rotacao45Graus();
        }

        public void RealizaRotacaoPara90Graus(CabecaRotacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoParaMenos45Graus(CabecaRotacao cabeca)
        {
            cabeca.EstadoAtual = new RotacaoMenos45Graus();
        }

        public void RealizaRotacaoParaMenos90Graus(CabecaRotacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        void EstadoCabecaRotacao.EmRepouso(CabecaRotacao cabeca)
        {
            cabeca.EstadoAtual = new EmRepouso();
        }
    }
}
