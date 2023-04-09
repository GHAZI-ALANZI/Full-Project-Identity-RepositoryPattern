using Asp.Net.Core_App_RepositoryPattern_Identity.Data;
using Asp.Net.Core_App_RepositoryPattern_Identity.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net.Core_App_RepositoryPattern_Identity.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        public MainRepository(AppDbContext context)
        {
            this.context = context;
        }

        protected AppDbContext context;

        public T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public IEnumerable<T> FindAll()
        {
            return context.Set<T>().ToList();

        }
        public async Task<T> FindByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
