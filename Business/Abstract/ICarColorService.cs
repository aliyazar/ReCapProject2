using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface ICarColorService
    {
        List<CarColor> GetAll();
        CarColor GetById(int colorId); 
    }
}
