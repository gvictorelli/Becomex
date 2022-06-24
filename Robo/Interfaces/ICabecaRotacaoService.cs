namespace Robo.Interfaces
{
    public interface ICabecaRotacaoService
    {
        void MovimentoEmRepouso();
        void MovimentoMenos45Graus();
        void MovimentoMenos90Graus();
        void Movimento45Graus();
        void Movimento90Graus();
        void ValidaInclinacaoCabeca();
    }
}
