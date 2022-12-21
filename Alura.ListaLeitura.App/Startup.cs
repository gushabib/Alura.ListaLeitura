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
        }

        public void Configure(IApplicationBuilder app) 
        {
            var builder = new RouteBuilder(app);
            builder.MapRoute("Livros/ParaLer", LivrosLogica.LivrosParaLer);
            builder.MapRoute("Livros/Lendo", LivrosLogica.LivrosLendo);
            builder.MapRoute("Livros/Lidos", LivrosLogica.LivrosLidos);
            builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivroParaLer);
            builder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.ExibeDetalhes);
            builder.MapRoute("Cadastro/NovoLivro", CadastroLogica.ExibeFormulario);
            builder.MapRoute("Cadastro/incluir", CadastroLogica.ProcessaFormulario);

            var rotas = builder.Build();

            app.UseRouter(rotas);
        }        
    }
}