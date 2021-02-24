using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaJuros.Api.Infraestructure.InterfaceRepository
{
    public interface ITaxaRepository: IDisposable
    {
        decimal GetTaxaJuros();
    }
}
