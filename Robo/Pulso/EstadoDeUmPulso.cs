namespace Robo.Pulso
{
    public interface EstadoDeUmPulso
    {
        void RealizaRotacaoParaMenos90Graus(Pulso pulso);
        void RealizaRotacaoParaMenos45Graus(Pulso pulso);
        void EmRepouso(Pulso pulso);
        void RealizaRotacaoPara45Graus(Pulso pulso);
        void RealizaRotacaoPara90Graus(Pulso pulso);
        void RealizaRotacaoPara135Graus(Pulso pulso);
        void RealizaRotacaoPara180Graus(Pulso pulso);
    }
}
