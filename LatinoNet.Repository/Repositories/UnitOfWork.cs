using LatinoNet.Entities.Interfaces;
using LatinoNet.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly LatinoNetContext Context;
        public UnitOfWork(LatinoNetContext context) { Context=context; }
        public Task<int> SaveChanges()
        {
            try
            {
                return Context.SaveChangesAsync();

            }catch (Exception ex)
            {
                throw new Exception(ex.Message,ex.InnerException);
            }
            
        }
    }
}
