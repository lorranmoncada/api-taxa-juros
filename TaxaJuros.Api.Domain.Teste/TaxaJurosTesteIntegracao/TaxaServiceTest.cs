using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxaJuros.Api.Domain.InterfaceService;

namespace TaxaJuros.Api.Domain.Teste.TaxaJurosTesteIntegracao
{
    public class TaxaServiceTest : ITaxaService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public decimal GetJuros()
        {
            return 0.01M;
        }
    }
}
