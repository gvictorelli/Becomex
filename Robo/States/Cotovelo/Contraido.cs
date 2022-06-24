using Robo.RoboCotovelo;

namespace Robo.States.Cotovelo
{
    public class Contraido : EstadoDeUmCotovelo
    {
        private static string ERROR_MESSAGE = "Sitema Corrompido";

        public void EmRepouso(RoboCotovelo.Cotovelo cotovelo)
        {
            throw new Exception(ERROR_MESSAGE);
        }

        public void FortementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new FortementeContraido();
            cotovelo.Descricao = "FortementeContraido";
        }

        public void LevementeContraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new LevementeContraido();
        }

        void EstadoDeUmCotovelo.Contraido(RoboCotovelo.Cotovelo cotovelo)
        {
            cotovelo.EstadoAtual = new Contraido();
        }
    }
}
