using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class CarColorManager : ICarColorService
    { 
        ICarColorDal _carColorDal;

        public CarColorManager(ICarColorDal carColorDal)
        {
            _carColorDal = carColorDal;
        }

        public List<CarColor> GetAll()
        {
            //iş kodları yazılacak
            return _carColorDal.GetAll();
        }

        public CarColor GetById(int colorId)
        {
            //iş kodları yazılacak
            return _carColorDal.Get(c => c.ColorId == colorId);
        }
    }
}
