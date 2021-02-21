using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(CarColor carColor)
        {
            _carColorDal.Add(carColor);
            return new Result(true, Messages.CarColorAdded);



        }

        public IDataResult<List<CarColor>> GetAll()
        {
            //iş kodları yazılacak
            return new DataResult<List<CarColor>>(_carColorDal.GetAll(), true, Messages.ColorListed);
        }

        public DataResult<CarColor> GetById(int colorId)
        {
            //iş kodları yazılacak
            return new SuccessDataResult<CarColor>(_carColorDal.Get(c => c.ColorId == colorId));
        }

        IDataResult<CarColor> ICarColorService.GetById(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
