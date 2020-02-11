using Microsoft.EntityFrameworkCore;
namespace Infra.Contexto
{
    public class DataContext: DbContext
    {
        //datacontext
        public DbSet<Model.Entity.Modalidade> Modalidades { get; set; }
        public DbSet<Model.Entity.Funcao> Funcoes { get; set; }
        public DbSet<Model.Entity.Unidade> Unidades { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }

    }
}
