using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

using Core.Entities;

namespace Core.DataAccess
{
    // generic constraint
    // class: referans tip
    // IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new() //class olmalı, IEntity imp.eden ve new'lenebilir nesne olmalı
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre verilmemişse tüm datayı getirir
        T Get(Expression<Func<T, bool>> filter); // tek bir veriye ulaşmak
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
  
    }
}
