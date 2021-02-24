using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxaJuros.Api.Infraestructure.InterfaceRepository;

namespace TaxaJuros.Api.Infraestructure
{
    //Simula retorno de um data base
    public class TaxaRepository : ITaxaRepository
    {
        public decimal GetTaxaJuros()
        {
            return 0.01M;
        }

        // Dispose seria utilizado somente se tivessemos utilizando algum ORM 
        public void Dispose()
        {
            //context?.Dispose();
        }
    }
}
