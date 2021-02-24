using System;
using System.Collections.Generic;
using System.Text;
using TaxaJuros.Api.Core.DomainObjects;

namespace TaxaJuros.Api.Domain.Model
{
    public class Taxa
    {
        public decimal Juros { get; private set; }

        public Taxa(decimal juros)
        {
            Juros = juros;
            IsValid();
        }
        // Também poderia ser utilizado a lib do FluentValidation para validação
        private void IsValid()
        {
            Validacoes.ValidarSeTaxaDiferenteValorDefault(Juros, "Taxa de Juros não pode ser diferente de 0.1");
        }
    }
}
