using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaJuros.Api.Core.DomainObjects
{
   public static class Validacoes
    {
        public static void ValidarSeTaxaDiferenteValorDefault(decimal valor, string mensagem)
        {
            if (!valor.Equals(0.01M))
            {
                throw new DomainException(mensagem);
            }
        }
    }
}
