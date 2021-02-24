using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxaJuros.Api.Application.Service;

namespace TaxaJuros.Api.Domain.Teste.TaxaJurosTesteIntegracao
{
    public class TaxaJurosAppServiceTest : ITaxaJurosAppService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public decimal GetTaxaJuros()
        {
            return 0.01M;
        }
    }
}
