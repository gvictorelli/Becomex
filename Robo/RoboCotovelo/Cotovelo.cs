using Robo.States.Cotovelo;

namespace Robo.RoboCotovelo
{
    public abstract class Cotovelo
    {
        public EstadoDeUmCotovelo EstadoAtual { get; set; }
        public string Descricao { get; set; }

        public Cotovelo()
        {
            EstadoAtual = new EmRepouso();
            Descricao = "EmRepouso";
        }

        public void RealizaMovimentoEmRepouso()
        {
            EstadoAtual.EmRepouso(this);
        }

        public void RealizaMovimentoLevementeContraido()
        {
            EstadoAtual.LevementeContraido(this);
        }

        public void RealizaMovimentoContraido()
        {
            EstadoAtual.Contraido(this);
        }

        public void RealizaMovimentoFortementeContraido()
        {
            EstadoAtual.FortementeContraido(this);
        }
    }
}
