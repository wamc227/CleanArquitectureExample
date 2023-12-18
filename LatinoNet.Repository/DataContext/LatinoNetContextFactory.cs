using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Repository.DataContext
{
    internal class LatinoNetContextFactory : IDesignTimeDbContextFactory<LatinoNetContext>
    {
        public LatinoNetContext CreateDbContext(string[] args)
        {
            var optionsBuilder= new DbContextOptionsBuilder<LatinoNetContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=LatinoNet;Integrated Security=SSPI");
            return new LatinoNetContext(optionsBuilder.Options);
        }
    }
}
