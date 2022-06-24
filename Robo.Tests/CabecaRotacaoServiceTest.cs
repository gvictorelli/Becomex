using Robo.Cabeca;
using Robo.Interfaces;

namespace Robo.Tests
{
    public class CabecaRotacaoServiceTest
    {
        private CabecaInclinacao cabecaInclinacao;
        private CabecaRotacao cabecaRotacao;
        Moq.Mock<ICabecaRotacaoService> cabecaRotacaoService;

        private void Setup()
        {
            cabecaInclinacao = Singleton<CabecaInclinacao>.Instance();
            cabecaRotacao = Singleton<CabecaRotacao>.Instance();
            cabecaRotacaoService = new Moq.Mock<ICabecaRotacaoService>();
            
        }

        [Fact]
        public void DeveRetornarUma_Exception()
        {
            Setup();

            //Act
            cabecaInclinacao.RealizaMovimentoParaBaixo();

            cabecaRotacaoService.Setup(x => x.ValidaInclinacaoCabeca());
            var exception = Assert.Throws<Exception>(() => cabecaRotacaoService.Setup(x => x.ValidaInclinacaoCabeca())); 

            // Assert
            Assert.Equal("Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo!", exception.Message);
        }
    }
}