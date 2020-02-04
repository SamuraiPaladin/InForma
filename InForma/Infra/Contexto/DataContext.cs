using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto
{
    public class DataContext: DbContext
    {
        public DbSet<Model.Entity.Modalidade> Modalidades { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }

    }
}
