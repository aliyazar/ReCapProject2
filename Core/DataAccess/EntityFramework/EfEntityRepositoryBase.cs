using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase <TEntity,TContext>:IEntityRepository<TEntity>//bu base alanı IEntitiyRepository deki tüm operasyonları sağlaması lazım o yüzden <TEntity> ile implemnente edilmeli
        where TEntity:class,IEntity,new()// kısıtlamalarımızı yazıyoruz
        where TContext:DbContext,new()//kafana göre her classı yazama diye kurall veriyoruz
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())// using bittiği anda bellek temizlenir
            {
                var addedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                addedEntity.State = EntityState.Added;//eklenecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }

        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())// using bittiği anda bellek temizlenir
            {
                var DeletedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                DeletedEntity.State = EntityState.Deleted;//silinecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())// using bittiği anda bellek temizlenir
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null    // filter null ise
                    ? context.Set<TEntity>().ToList()//veritabanında ki Products sütunundaki tüm datayı listeye çevir
                    : context.Set<TEntity>().Where(filter).ToList();// null değilse filteryi uygulayarak ver
            }
        }


        //public List<Car> GetByBrand(int brandId)
        //{
        //    using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())
        //    {
        //        return context.Set<Brand>().SingleOrDefault(brandId);
        //    }
        //}

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())// using bittiği anda bellek temizlenir
            {
                var UpdatedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                UpdatedEntity.State = EntityState.Modified;//güncellenecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }
    }
}
