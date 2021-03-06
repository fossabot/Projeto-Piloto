﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using Semp.Infrastructure.Models;

namespace Semp.Infrastructure.Data
{
    public interface IRepositoryWithTypedId<T, TId> where T : IEntity<TId>
    {
        IQueryable<T> Query();

        void Add(T entity);

        IDbContextTransaction BeginTransaction();

        void SaveChanges();

        Task SaveChangesAsync();

        void Remove(T entity);
    }
}
