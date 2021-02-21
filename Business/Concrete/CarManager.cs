using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;//

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public IResult Add(Car car)//return edilecek birşey olmalı
        {
            if (car.DailyPrice<0)
            {
                return new ErrorResult(Messages.DailyPrice);
            }
            _CarDal.Add(car);
            return new Result(true,Messages.CarAdded);//iki parametre ile iş yapsın
        }// Resultın construktorı yapılandırılmadığı için kızıyor ampulden generate Constructor in Result yap ve F12 ile içeriği gör

        public IDataResult<List<Car>> GetAll()
        {
            // burada iş kodları yazılacak
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.CompanyClosed);
            }

            return new DataResult<List<Car>>(_CarDal.GetAll(),true,Messages.CarListed);//iş kodalrı kurallarına uygunsa bana araçları verebilirsin 
            
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_CarDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_CarDal.GetCarDetails());
        }
    }
}
