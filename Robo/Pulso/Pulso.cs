using Robo.States.Pulso;

namespace Robo.Pulso
{
    public abstract class Pulso
    {
        public EstadoDeUmPulso EstadoAtual { get; set; }

        public Pulso()
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

        public void RealizaMovimento135Graus()
        {
            EstadoAtual = new Rotacao90Graus();
        }

        public void RealizaMovimento180Graus()
        {
            EstadoAtual = new Rotacao90Graus();
        }
    }
}