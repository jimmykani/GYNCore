using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

       // Task<TEntity> GetUserIdAsync(int id);

    }
}
