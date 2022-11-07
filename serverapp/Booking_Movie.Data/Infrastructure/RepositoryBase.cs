using Booking_Movie.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Booking_Movie.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private BookingMovieContext movieContext;
        private readonly DbSet<T> dbSet;
        protected IDbFactory dbFactory { get; private set; }

        protected BookingMovieContext MovieContext
        {
            get { return movieContext ??= dbFactory.InitContext(); }
        }

        public RepositoryBase(BookingMovieContext movieContext, IDbFactory dbFactory)
        {
            this.movieContext = movieContext;
            this.dbSet = movieContext.Set<T>();
            this.dbFactory = dbFactory;
        }

        public EntityEntry<T> Add(T entity)
        {
            return dbSet.Add(entity);
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public EntityEntry<T> Delete(T entity)
        {
            if (movieContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            return this.dbSet.Remove(entity);
        }

        public async Task<EntityEntry<T>> Delete(int id)
        {
            var entity = await this.dbSet.FindAsync(id);
            return this.dbSet.Remove(entity!);
        }

        public void DeleteMulti(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(string[]? includes = null)
        {
            if (includes?.Count() > 0 && includes != null)
            {
                var query = this.dbSet.Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                    return query.AsQueryable();
                }
            }
            return dbSet.AsQueryable();
        }

        public IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[]? includes = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMultiPaging(Expression<Func<T, bool>>? filter, out int total, int index = 0, int size = 50, string[]? includes = null)
        {
            int skipCount = index * size;
            IQueryable<T> _resetSet;

            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = movieContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = filter != null ? query.Where<T>(filter).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = filter != null ? movieContext.Set<T>().Where<T>(filter).AsQueryable() : movieContext.Set<T>().AsQueryable();
            }
            float totalPage = (float)_resetSet.Count() / size;
            total = Convert.ToInt32(Math.Round(totalPage));
            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            return _resetSet.AsQueryable();
        }

        public async Task<T?> GetSingleByCondition(Expression<Func<T, bool>> expression, string[]? includes = null)
        {
            if (includes?.Count() > 0 && includes != null)
            {
                var query = this.dbSet.Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                    return await query.FirstOrDefaultAsync(expression);
                }
            }
            return await dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<T?> GetSingleById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            movieContext.Entry(entity).State = EntityState.Modified;
        }
    }
}