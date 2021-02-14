using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                var addedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                addedEntity.State = EntityState.Added;//eklenecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }

        public void Delete(Brand entity)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                var DeletedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                DeletedEntity.State = EntityState.Deleted;//silinecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())
            {
                return filter == null    // filter null ise
                    ? context.Set<Brand>().ToList()//veritabanında ki Products sütunundaki tüm datayı listeye çevir
                    : context.Set<Brand>().Where(filter).ToList();// null değilse filteryi uygulayarak ver
            }
        }

        public void Update(Brand entity)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                var UpdatedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                UpdatedEntity.State = EntityState.Modified;//güncellenecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }
    }
}
