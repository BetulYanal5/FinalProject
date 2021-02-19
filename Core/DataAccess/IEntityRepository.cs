using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmanı diğer katmanları referans almaz,alırsa bağımlı olur diğer katmanlara
namespace Core.DataAccess
{  //generic constraint
   //class : referans tip 
   //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
   //new() : new'lenebilir olmalı,IEntity new'lenebilir olmadığından devre dışı bırakılır
   public interface IEntityRepository<T> where T:class,IEntity,new()//Generic Repository Design Pattern
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//Filtre vermeyebilirsin
        T Get(Expression<Func<T, bool>> filter);//filtre vermezse tüm datayı istiyordur
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
