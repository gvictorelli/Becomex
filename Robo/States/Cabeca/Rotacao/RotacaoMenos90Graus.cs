using Robo.Cabeca;

namespace Robo.States.Cabeca.Rotacao
{
    public class RotacaoMenos90Graus : EstadoCabecaRotacao
    {
        private static string ERROR_MESSAGE = "Sistema Corrompido";
        public void EmRepouso(CabecaRotacao cabeca)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoPara45Graus(CabecaRotacao cabecao)
        {
            throw new Exception(ERROR_MESSAGE);
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
            cabeca.EstadoAtual = new RotacaoMenos90Graus();
        }
    }
}
