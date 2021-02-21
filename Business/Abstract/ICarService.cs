using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface ICarService
    {//IDataResult a T yerine parametre olarak <List<car>> gönderdik
        IDataResult<List<Car>> GetAll();//araç listesi döndürüyor bu eylem çaılıştığında data ve bir mesaj versin 
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);// data yok sadece void

        IDataResult <Car> GetById(int car);//tek bir araba döndürür
    }
}
