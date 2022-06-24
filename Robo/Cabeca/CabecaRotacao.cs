using Robo.States.Cabeca.Rotacao;

namespace Robo.Cabeca
{
    public class CabecaRotacao
    {
        public EstadoCabecaRotacao EstadoAtual { get; set; }

        public CabecaRotacao()
        {
            EstadoAtual = new EmRepouso();
        }

        public void RealizaMovimentoMenos90Graus()
        {
            EstadoAtual = new Rotacao90Graus();
        }

        public void RealizaMovimentoMenos45Graus()
        {
            EstadoAtual = new Rotacao45Graus();
        }

        public void RealizaMovimentoEmRepouso()
        {
            EstadoAtual.EmRepouso(this);
        }

        public void RealizaMovimento45Graus()
        {
            EstadoAtual = new Rotacao45Graus();
        }

        public void RealizaMovimento90Graus()
        {
            EstadoAtual = new Rotacao90Graus();
        }
    }
}
