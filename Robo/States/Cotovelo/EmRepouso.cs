using Robo.RoboCotovelo;

namespace Robo.States.Cotovelo
{
    public class EmRepouso : EstadoDeUmCotovelo
    {
        private static string ERROR_MESSAGE = "Sitema Corrompido";
        public void Contraido(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void FortementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void LevementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new LevementeContraido();
        }

        public void RealizaMovimento(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        void EstadoDeUmCotovelo.EmRepouso(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new EmRepouso();
        }
    }
}
