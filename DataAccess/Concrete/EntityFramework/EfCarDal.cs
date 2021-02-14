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
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                var addedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                addedEntity.State = EntityState.Added;//eklenecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }

        }

        public void Delete(Car entity)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                var DeletedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                DeletedEntity.State = EntityState.Deleted;//silinecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())
            {
                return filter == null    // filter null ise
                    ? context.Set<Car>().ToList()//veritabanında ki Products sütunundaki tüm datayı listeye çevir
                    : context.Set<Car>().Where(filter).ToList();// null değilse filteryi uygulayarak ver
            }
        }


        //public List<Car> GetByBrand(int brandId)
        //{
        //    using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())
        //    {
        //        return context.Set<Brand>().SingleOrDefault(brandId);
        //    }
        //}

        public void Update(Car entity)
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
