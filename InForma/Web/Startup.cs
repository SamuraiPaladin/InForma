using Infra.Contexto;
using Infra.DB;
using Infra.IDAO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Model.Entity;
using Service.IService;
using Service.Service;

namespace Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IServiceRepository<Modalidade>, ServiceModalidade>();
            services.AddScoped<IServiceRepository<Funcao>, ServiceFuncao>();
            services.AddScoped<IServiceUnidade<Unidade>, ServiceUnidade>();
            services.AddScoped<IServiceTurma<Turma>, ServiceTurma>();
            services.AddScoped<IServiceColaborador<Colaborador>, ServiceColaborador>();
            services.AddScoped<IServiceAluno<Aluno>, ServiceAluno>();

            services.AddScoped<IDAO<Modalidade>, ModalidadeDAO>();
            services.AddScoped<IDAO<Funcao>, FuncaoDAO>();
            services.AddScoped<IDAO<Unidade>, UnidadeDAO>();
            services.AddScoped<IDAO<Turma>, TurmaDAO>();
            services.AddScoped<IDAO<Colaborador>, ColaboradorDAO>();
            services.AddScoped<IDAO<Aluno>, AlunoDAO>();

            services.AddDbContext<DataContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("BANCO_DE_DADOS")));

            //services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BANCO_DE_DADOS")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Principal}/{action=Index}/{id?}");
            });
        }
    }
}
