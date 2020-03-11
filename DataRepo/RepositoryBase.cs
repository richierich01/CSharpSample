﻿using CEOGroup.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CEOGroup.Data
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public T Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
            SaveChanges();
            return entity;
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
            SaveChanges();
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public bool SaveChanges()
        {
            return RepositoryContext.SaveChanges() > 0;
        }
    }
}
