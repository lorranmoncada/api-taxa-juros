using TaxaJuros.Api.Core.DomainObjects;
using TaxaJuros.Api.Domain.Model;
using Xunit;

namespace TaxaJuros.Api.Domain.Teste
{
   
    public class TaxaTest
    {
        [Fact]
        public void VerificaTaxaJurosRetornaDomainException()
        {
            Assert.Throws<DomainException>(() => new Taxa(0.2M));
        }

        [Fact]
        public void VerificaDomainExceptionMensagemRetonada()
        {
           var execption = Assert.Throws<DomainException>(() => new Taxa(0));
            Assert.Equal("Taxa de Juros não pode ser diferente de 0.1", execption.Message);
        }
    }
}
