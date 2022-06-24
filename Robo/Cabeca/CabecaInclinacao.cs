using Robo.States.Cabeca.Inclinacao;

namespace Robo.Cabeca
{
    public class CabecaInclinacao
    {
        public EstadoCabecaInclinacao EstadoAtual { get; set; }
        public string Descricao { get; set; }

        public CabecaInclinacao()
        {
            EstadoAtual = new EmRepouso();
            Descricao = "EmRepouso";
        }

        public void RealizaMovimentoEmRepouso()
        {
            EstadoAtual.EmRepouso(this);
        }
        public void RealizaMovimentoParaCima()
        {
            EstadoAtual.RealizaMovimentoParaCima(this);
        }

        public void RealizaMovimentoParaBaixo()
        {
            EstadoAtual.RealizaMovimentoParaBaixo(this);
        }
    }
}
