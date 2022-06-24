using Robo.RoboCotovelo;

namespace Robo.States.Cotovelo
{
    public class LevementeContraido : EstadoDeUmCotovelo
    {
        private static string ERROR_MESSAGE = "Sistema Corrompido";

        public void Contraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new Contraido();
        }

        public void EmRepouso(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new EmRepouso();
        }

        public void FortementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaMovimento(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new NotImplementedException();
        }

        void EstadoDeUmCotovelo.LevementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new LevementeContraido();
        }
    }
}
