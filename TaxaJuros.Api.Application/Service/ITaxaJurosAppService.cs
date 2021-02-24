using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaJuros.Api.Application.Service
{
   public interface ITaxaJurosAppService: IDisposable
    {
        decimal GetTaxaJuros();
    }
}
