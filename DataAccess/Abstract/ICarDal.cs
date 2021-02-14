using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntitiyRepository<Car>
    {
       // List<Car> GetByBrand(int brandId);// araçları markaya göre listele
    }
}
