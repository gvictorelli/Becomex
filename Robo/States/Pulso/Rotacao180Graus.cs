using Robo.Pulso;

namespace Robo.States.Pulso
{
    public class Rotacao180Graus : EstadoDeUmPulso
    {
        private static string ERROR_MESSAGE = "Sitema Corrompido";

        public void RealizaRotacaoPara135Graus(Robo.Pulso.Pulso pulso)
        {
            pulso.EstadoAtual = new Rotacao135Graus();
        }

        public void RealizaRotacaoPara180Graus(Robo.Pulso.Pulso pulso)
        {
            pulso.EstadoAtual = new Rotacao180Graus();
        }

        public void RealizaRotacaoPara45Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoPara90Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoParaMenos45Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaRotacaoParaMenos90Graus(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        void EstadoDeUmPulso.EmRepouso(Robo.Pulso.Pulso pulso)
        {
            throw new Exception(ERROR_MESSAGE);
        }
    }
}
