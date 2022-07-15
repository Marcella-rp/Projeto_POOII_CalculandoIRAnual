using Microsoft.Extensions.DependencyInjection;
using Projeto_POOII_Presentation.Interfaces;
using Projeto_POOII_Presentation.ProgramFlows;
using Projeto_POOII_Services;
using Projeto_POOII_Services.Interfaces;

namespace Projeto_POOII_Presentation
{
    public class Program
    {
        public static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var mainFlow = serviceProvider.GetService<IMainFlow>();

            mainFlow.BeginProgram();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMainFlow, MainFlow>()
                    .AddScoped<ITaxaCalculator, TaxaCalculation>();
        }

    }
}


