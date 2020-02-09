using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto
{
    public class DataContext: DbContext
    {
        //datacontext
        public DbSet<Model.Entity.Modalidade> Modalidades { get; set; }
        public DbSet<Model.Entity.Funcao> Funcoes { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }

    }
}
