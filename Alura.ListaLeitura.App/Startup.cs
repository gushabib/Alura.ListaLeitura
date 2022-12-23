using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App.Logica
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddMvc();  
        }

        public void Configure(IApplicationBuilder app) 
        {
            app.UseMvcWithDefaultRoute();
        }        
    }
}