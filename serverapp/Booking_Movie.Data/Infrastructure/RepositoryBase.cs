﻿using Booking_Movie.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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

        public T Add(T entity)
        {
            var addNew = dbSet.Add(entity);
            return addNew.Entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            var addNew = await dbSet.AddAsync(entity);
            return addNew.Entity;
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

        public async Task<List<T>?> DeleteMulti(int[] idList)
        {
            List<T> entities = new List<T>();
            try
            {
                foreach (var id in idList)
                {
                    var entity = await this.dbSet.FindAsync(id);
                    if(entity != null)
                    {
                        entities.Add(entity);
                        this.dbSet.Remove(entity!);
                    }
                    
                }

                return entities.Any() ? entities : null;


            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public async Task<List<T>?> DeleteMulti(Guid[] idList)
        {
            try
            {
                List<T> entities = new List<T>();
                foreach (var id in idList)
                {
                    var entity = await this.dbSet.FindAsync(id);
                    if(Equals(entity, null))
                    {
                        entities.Add(entity!);
                        this.dbSet.Remove(entity!);
                    }
                }

                return entities.Any() ? entities : null;

            }
            catch (Exception ex)
            {

                return null;
            }


        }
        public async Task<List<T>?> DeleteMulti(string[] idList)
        {
            try
            {
                List<T> entities = new List<T>();
                foreach (var id in idList)
                {
                    var entity = await this.dbSet.FindAsync(id);
                    if(!Equals(entity, null))
                    {
                        entities.Add(entity);
                        this.dbSet.Remove(entity);
                    }
                }

                return entities.Any() ? entities : null;

            }
            catch (Exception ex)
            {

                return null;
            }


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

        public IQueryable<T> GetMulti(Expression<Func<T, bool>> expression, string[]? includes = null)
        {
            if (includes?.Count() > 0 && includes != null)
            {
                var query = this.dbSet.Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                    return  query.Where(expression);
                }
            }
            return  dbSet.Where(expression);
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

        public async Task<T?> GetSingleById(string id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<T?> GetSingleById(Guid id)
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