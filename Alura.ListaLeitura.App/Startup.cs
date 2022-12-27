using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App.Logica
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();  
        }

        public void Configure(IApplicationBuilder app) 
        {
            //somente para desenvolvimento:
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
        }        
    }
}