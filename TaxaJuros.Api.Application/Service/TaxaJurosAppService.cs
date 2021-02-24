using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxaJuros.Api.Domain.InterfaceService;

namespace TaxaJuros.Api.Application.Service
{
    public class TaxaJurosAppService : ITaxaJurosAppService
    {
        private readonly ITaxaService _taxaService;
        public TaxaJurosAppService(ITaxaService taxaService)
        {
            _taxaService = taxaService;
        }

        public decimal GetTaxaJuros()
        {
            return _taxaService.GetJuros();
        }

        // Dispose seria utilizado somente se tivessemos utilizando algum ORM 
        public void Dispose()
        {
            _taxaService?.Dispose();
        }
    }
}
