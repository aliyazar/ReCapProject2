using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {// proje çalışınca veritabanından geliyormuş gibi bellekte veriler oluşacak
            _cars = new List<Car> { 
            
                new Car{CarId=1,Description="Otomatik Vites",ModelYear=2019,ColorId=1,BrandId=1,DailyPrice=150},
                new Car{CarId=2,Description="Otomatik Vites",ModelYear=2020,ColorId=2,BrandId=2,DailyPrice=170},
                new Car{CarId=3,Description="Manuel Vites",ModelYear=2010,ColorId=1,BrandId=3,DailyPrice=130},
                new Car{CarId=4,Description="Manuel Vites",ModelYear=2010,ColorId=2,BrandId=3,DailyPrice=120},
                new Car{CarId=5,Description="Manuel Vites",ModelYear=2005,ColorId=3,BrandId=4,DailyPrice=90}


            };
        }

        public void Add(Car car)// yeni bir araba geldiğinde listeye eklenecek
        {
            _cars.Add(car);//globan _car listesine ekle
        }

        public void Delete(Car car)
        {//LINQ ile silme yapacağız dile gömülü sorgu
            Car carToDelete;//içi boş bir car nesnesi oluştur adı carToDelete olsun c sıradaki elemanın takma isim
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);//_cars listesindeki her c için o an sıradaki car id si paramere ile gönderilen car id sine eşitse
            _cars.Remove(carToDelete);//  o elemanı listeden sil
            //
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;// tüm ürünleri istediği için listemizi geri döndürüyoruz
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();//where içine yeni koşullar elenebilir.
            //burada  BrandId den gelen her c brandId ye eşitse o elalardan  liste haline getirip return eder
            //where içindeki şarta uyan elemanları yeni bir liste haline getirir.
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate;//içi boş bir car nesnesi oluştur adı carToUpdate olsun c sıradaki elemanın takma isim
            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);//_cars listesindeki her c için o an sıradaki car id si paramere ile gönderilen car id sine eşitse
            _cars.Remove(carToUpdate);//  o elemanı 
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
