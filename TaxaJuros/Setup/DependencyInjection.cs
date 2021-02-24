
using Microsoft.Extensions.DependencyInjection;
using TaxaJuros.Api.Application.Service;
using TaxaJuros.Api.Domain.InterfaceService;
using TaxaJuros.Api.Domain.Service;
using TaxaJuros.Api.Infraestructure;
using TaxaJuros.Api.Infraestructure.InterfaceRepository;

namespace TaxaJuros.Setup
{
    public static class DependencyInjection 
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //TaxaJuros Service
            services.AddScoped<ITaxaService, TaxaService>();

            //TaxaJuros Repository
            services.AddScoped<ITaxaRepository, TaxaRepository>();

            //TaxaJuros Application
            services.AddScoped<ITaxaJurosAppService, TaxaJurosAppService>();
            
        }
    }
}
