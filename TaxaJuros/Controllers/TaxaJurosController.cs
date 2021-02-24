using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaxaJuros.Api.Application.Service;

namespace TaxaJuros.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAppService _taxaJurosAppService;
        private readonly ILogger<TaxaJurosController> _logger;
        public TaxaJurosController(ITaxaJurosAppService taxaJurosAppService, ILogger<TaxaJurosController> logger)
        {
            _taxaJurosAppService = taxaJurosAppService;
            _logger = logger;
        }

        [HttpGet]
        [Route("taxajuros")]
        public IActionResult GetJuros()
        {
            _logger.LogInformation("Buscando o valor de taxa de Juros");
            return Ok(_taxaJurosAppService.GetTaxaJuros());
        }
    }
}
