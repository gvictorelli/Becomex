using Robo.RoboCotovelo;

namespace Robo.States.Cotovelo
{
    public class FortementeContraido : EstadoDeUmCotovelo
    {
        private static string ERROR_MESSAGE = "Sitema Corrompido";

        public void Contraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new Contraido();
        }

        public void EmRepouso(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void LevementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void RealizaMovimento(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new NotImplementedException();
        }

        void EstadoDeUmCotovelo.FortementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new FortementeContraido();
        }
    }
}
