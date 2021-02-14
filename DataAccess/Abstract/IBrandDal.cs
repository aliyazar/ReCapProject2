using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntitiyRepository<Brand>
    {
       

       // List<Car> GetByBrand(int brandId);// araçları markaya göre listele***** burda hata olabilir
    }
}
