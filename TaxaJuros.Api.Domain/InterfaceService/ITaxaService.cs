using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaJuros.Api.Domain.InterfaceService
{
   public interface ITaxaService: IDisposable
    {
        decimal GetJuros();
    }
}
