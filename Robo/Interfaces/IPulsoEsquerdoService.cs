namespace Robo.Interfaces
{
    public interface IPulsoEsquerdoService
    {
        void MovimentoEmRepouso();
        void MovimentoMenos45Graus();
        void MovimentoMenos90Graus();
        void Movimento45Graus();
        void Movimento90Graus();
        void Movimento135Graus();
        void Movimento180Graus();
    }
}
