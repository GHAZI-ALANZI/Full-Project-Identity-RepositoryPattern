using Asp.Net.Core_App_RepositoryPattern_Identity.Data;
using Asp.Net.Core_App_RepositoryPattern_Identity.Repository.Base;


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
    }
}
