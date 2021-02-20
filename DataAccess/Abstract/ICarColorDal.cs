using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarColorDal:IEntitiyRepository<CarColor>
    {
        

       // List<CarColor> GetByCarColor(int colorId);// araçları markaya göre listele 
    }
}
