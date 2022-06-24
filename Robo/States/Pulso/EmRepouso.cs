using Robo.Pulso;

namespace Robo.States.Pulso
{
    public class EmRepouso : EstadoDeUmPulso
    {
        private static string ERROR_MESSAGE = "Sitema Corrompido";

        public void RealizaRotacaoPara135Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoPara180Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoPara45Graus(Robo.Pulso.Pulso pulso)
        {
            pulso.EstadoAtual = new Rotacao45Graus();
        }

        public void RealizaRotacaoPara90Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoParaMenos45Graus(Robo.Pulso.Pulso pulso)
        {
            pulso.EstadoAtual = new RotacaoMenos45Graus();
        }

        public void RealizaRotacaoParaMenos90Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE); ;
        }

        void EstadoDeUmPulso.EmRepouso(Robo.Pulso.Pulso pulso)
        {
            pulso.EstadoAtual = new EmRepouso();
        }
    }
}
