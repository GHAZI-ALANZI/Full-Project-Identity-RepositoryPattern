namespace Asp.Net.Core_App_RepositoryPattern_Identity.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        T FindById(int id);
    }
}
