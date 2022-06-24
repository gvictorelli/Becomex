namespace Robo.Cabeca
{
    public interface EstadoCabecaRotacao
    {
        void RealizaRotacaoParaMenos90Graus(CabecaRotacao cabeca);
        void RealizaRotacaoParaMenos45Graus(CabecaRotacao cabeca);
        void EmRepouso(CabecaRotacao cabeca);
        void RealizaRotacaoPara45Graus(CabecaRotacao cabecao);
        void RealizaRotacaoPara90Graus(CabecaRotacao cabeca);
    }
}
