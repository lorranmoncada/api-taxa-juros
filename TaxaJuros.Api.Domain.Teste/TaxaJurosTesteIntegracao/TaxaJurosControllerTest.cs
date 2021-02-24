using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using TaxaJuros.Api.Application.Service;
using TaxaJuros.Api.Domain.InterfaceService;
using TaxaJuros.Controllers;
using Xunit;

namespace TaxaJuros.Api.Domain.Teste.TaxaJurosTesteIntegracao
{
    public class TaxaJurosControllerTest : ControllerBase
    {
        private readonly ITaxaJurosAppService _taxaJurosAppService;
        private readonly ILogger<TaxaJurosController> _logger;
        private readonly ITaxaService _taxaService;
        private readonly TaxaJurosController _controller;

        public TaxaJurosControllerTest()
        {
            _taxaService = new TaxaServiceTest();
            _logger  = Mock.Of<ILogger<TaxaJurosController>>();
            _taxaJurosAppService = new TaxaJurosAppService(_taxaService);
            _controller = new TaxaJurosController(_taxaJurosAppService,_logger);
        }

        [Fact]
        private  void CriaRetornoDeTaxaJurosFluxoIntegrado()
        {
            _logger.LogInformation("");
            var okResult =  _controller.GetJuros() as OkObjectResult;
            var retorno = okResult.Value;
            var valorEsperado = 0.01M;
            Assert.Equal(valorEsperado, retorno);
        }

    }
}
