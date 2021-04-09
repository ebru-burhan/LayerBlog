using LayerBlog.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LayerBlog.DataAccess.Abstracts
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;
        public DbSet<T> Table { get; set; }

        public BaseRepository(DataContext context)
        {
            _context = context;
            Table = _context.Set<T>();
        }

        //virtual çünkü bazılarını add delete update yapmak istemediğimz için override edicez
        public virtual T Add(T entity)
        {
            //dbset ile table ı çektik 
            // _context.Set<T>().Add(entity);
            Table.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual void Delete(T entity)
        {
            Table.Remove(entity);
            _context.SaveChanges();
        }


        public virtual void Update(T entity)
        {
            //attach ile farkı
            Table.Update(entity);
            _context.SaveChanges();
        }



        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null, int? take = null)
        {
            return GetQueryable(filter, include, orderBy, skip, take);
        }

        public IQueryable<T> GetAll()
        {
            return Get();   
        }


        public IQueryable<T> GetIncluded(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Table;
            foreach (var include in includes)
            {
                query.Include(include);
            }
            return query;
        }

        public IQueryable<T> GetFilteredIncluded(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Table.Where(filter);
            foreach (var include in includes)
            {
                query.Include(include);
            }
            return query;
        }


        protected virtual IQueryable<T> GetQueryable(Expression<Func<T, bool>> filter = null,
                                                   Expression<Func<T, object>> include = null,
                                                   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                   int? skip = null,
                                                   int? take = null)
        {
            //istenilen çekildi şuan ve query atandı organization çektik diyelim
            IQueryable<T> query = Table;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                query = query.Include(include);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }
            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            //EF değişklikleri kontrol etmesin delete ettirmedi veriyi tutuyo hayırdır diyo
            return query.AsNoTracking();
        }


    }
}
