namespace Robo.RoboCotovelo
{
    public interface EstadoDeUmCotovelo
    {
        void EmRepouso(Cotovelo cotovelo);
        void LevementeContraido(Cotovelo cotovelo);
        void Contraido(Cotovelo cotovelo);
        void FortementeContraido(Cotovelo cotovelo);
    }
}
