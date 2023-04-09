﻿using System.Linq.Expressions;

namespace Asp.Net.Core_App_RepositoryPattern_Identity.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        T FindById(int id);
        T SelectOne(Expression<Func<T, bool>> match);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindAll(params string[] agers);
        Task<T> FindByIdAsync(int id);

        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindAllAsync(params string[] agers);

    }
}
