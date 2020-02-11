using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-UV3K6VG\\SQLEXPRESS;Database=Informa;Integrated Security=SSPI;persist security info=True;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=TRUE");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
