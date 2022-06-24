namespace Robo.Cabeca
{
    public interface EstadoCabecaInclinacao
    {
        void RealizaMovimentoParaCima(CabecaInclinacao cabeca);
        void EmRepouso(CabecaInclinacao cabeca);
        void RealizaMovimentoParaBaixo(CabecaInclinacao cabeca);
    }
}
