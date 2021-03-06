using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllSync();
        Task<List<T>> ListASync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task CountAsync(ISpecification<T> spec);
        Task<T> FirstAsync(ISpecification<T> spec);
        Task <T> FirstOrDefaultAsync(ISpecification<T> spec);



    }
}
