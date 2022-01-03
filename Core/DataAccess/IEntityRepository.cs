﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        T get(Expression<Func<T, bool>> filter);

    }
}
