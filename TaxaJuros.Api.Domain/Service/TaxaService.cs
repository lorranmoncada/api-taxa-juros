using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxaJuros.Api.Core.DomainObjects;
using TaxaJuros.Api.Domain.InterfaceService;
using TaxaJuros.Api.Domain.Model;
using TaxaJuros.Api.Infraestructure.InterfaceRepository;

namespace TaxaJuros.Api.Domain.Service
{
    public class TaxaService : ITaxaService
    {
        public readonly ITaxaRepository _taxaRepository;

        public TaxaService(ITaxaRepository taxaRepository)
        {
            _taxaRepository = taxaRepository;
        }
        public decimal GetJuros()
        {
            try
            {
                Taxa taxaInstance = new Taxa(_taxaRepository.GetTaxaJuros());
                return taxaInstance.Juros;
            }
            catch (Exception e)
            {
                throw new DomainException($"Erro na camada de Domain: {e.Message}", e);
            }

        }

        // Dispose seria utilizado somente se tivessemos utilizando algum ORM 
        public void Dispose()
        {
            _taxaRepository?.Dispose();
        }
    }
}
