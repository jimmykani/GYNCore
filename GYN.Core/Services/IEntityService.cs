using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IEntityService<T> : IService
      where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
        Task<List<T>> GetAllAsync();
       //Task<T> Create(T entity);
       //   void DeleteAsync(T entity);
       /// Task<IEnumerable<T>> GetAllAsync();
        // void UpdateAsync(T entity);
        //void CreateAsync(T entity);
    }
}
