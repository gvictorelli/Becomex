using Robo.Cabeca;

namespace Robo.Tests
{
    public class CabecaInclinacaoServiceTest
    {
        private CabecaInclinacao cabecaInclinacao;

        private void Setup()
        {
            cabecaInclinacao = Singleton<CabecaInclinacao>.Instance();
        }

        [Fact]
        public void DeveRetornarOEstado_ParaBaixo()
        {
            Setup();

            //Act
            cabecaInclinacao.RealizaMovimentoParaBaixo();

            //Assert
            Assert.Equal(cabecaInclinacao.Descricao, "ParaBaixo");
        }

        [Fact]
        public void DeveRetornarUma_Exception()
        {
            Setup();

            //Act
            cabecaInclinacao.RealizaMovimentoParaBaixo(); 
            var exception = Assert.Throws<Exception>(() => cabecaInclinacao.RealizaMovimentoParaCima());

            // Assert
            Assert.Equal("Sistema Corrompido", exception.Message);
        }
    }
}