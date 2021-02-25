using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()// T türnde veri alan bir nesne
    {
        //GetAll da filtre ekleyerek sitediğimizi geirebiliriz bunun için Expression kullanırız
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//kırmzı alt çizgi Product seçiliyken ampulden add referance to entites e bas
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    
    }

}


/*
 public interface IEntityRepository<T> 
    
 
 
 
 
 
 */