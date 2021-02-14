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
    public class EfCarColorDal : ICarColorDal
    {
        public void Add(CarColor entity)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                var addedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                addedEntity.State = EntityState.Added;//eklenecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }

        public void Delete(CarColor entity)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                var DeletedEntity = context.Entry(entity);// gelen entitiy ti addetEntity değişkkenine at
                DeletedEntity.State = EntityState.Deleted;//silinecek nesnenin stateini  ekle
                context.SaveChanges();//kaydet
            }
        }

        public CarColor Get(Expression<Func<CarColor, bool>> filter)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())// using bittiği anda bellek temizlenir
            {
                return context.Set<CarColor>().SingleOrDefault(filter);
            }
        }

        public List<CarColor> GetAll(Expression<Func<CarColor, bool>> filter = null)
        {
            using (RecapProjectCarDataBase context = new RecapProjectCarDataBase())
            {
                return filter == null    // filter null ise
                    ? context.Set<CarColor>().ToList()//veritabanında ki Products sütunundaki tüm datayı listeye çevir
                    : context.Set<CarColor>().Where(filter).ToList();// null değilse filteryi uygulayarak ver
            }
        }

        //public List<CarColor> GetByCarColor(int colorId)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(CarColor entity)
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
