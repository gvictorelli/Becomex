using Robo.Cabeca;

namespace Robo.States.Cabeca.Rotacao
{
    public class Rotacao90Graus : EstadoCabecaRotacao
    {
        private static string ERROR_MESSAGE = "Sistema Corrompido";
        public void EmRepouso(CabecaRotacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoPara45Graus(CabecaRotacao cabeca)
        {
            cabeca.EstadoAtual = new Rotacao45Graus();
        }

        public void RealizaRotacaoPara90Graus(CabecaRotacao cabeca)
        {
            cabeca.EstadoAtual = new Rotacao90Graus();
        }

        public void RealizaRotacaoParaMenos45Graus(CabecaRotacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoParaMenos90Graus(CabecaRotacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }
    }
}
