using Microsoft.Extensions.DependencyInjection;
using Softplan.Everson.Domain.Services.Implementations;
using Softplan.Everson.Domain.Services.Interfaces;

namespace Softplan.Everson.Domain.IoC
{
    public static class RegisterServices
    {
        public static void RegisterAllServices(this IServiceCollection services)
        {
            services.AddTransient<ICalculatorService, CalculatorService>();
        }
    }
}
