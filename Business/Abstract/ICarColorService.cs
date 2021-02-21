using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface ICarColorService
    {
        IDataResult<List<CarColor>> GetAll();
        IDataResult<CarColor> GetById(int colorId);
        IResult Add(CarColor carColor);
    }
}
