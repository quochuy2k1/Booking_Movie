using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Linq.Expressions;

namespace Booking_Movie.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        T Add(T entity);
        Task<T> AddAsync(T entity);


        // Marks an entity as modified
        void Update(T entity);

        // Marks an entity to be removed
        EntityEntry<T> Delete(T entity);

        Task<EntityEntry<T>> Delete(int id);

        //Delete multi records
        Task<List<T>?> DeleteMulti(int [] idList);

        // Get an entity by int id
        Task<T?> GetSingleById(int id);
        Task<T?> GetSingleById(string id);
        Task<T?> GetSingleById(Guid id);

        Task<T?> GetSingleByCondition(Expression<Func<T, bool>> expression, string[]? includes = null);

        IQueryable<T> GetAll(string[]? includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[]? includes = null);

        IQueryable<T?> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[]? includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}