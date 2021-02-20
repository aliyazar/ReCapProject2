using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;// bağımlılığı minimize ediyoruz bana sadece IbrandDal lazım diyoruz

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            //iş kodları yazılacak
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            //İş kodları yazılacak
            return _brandDal.Get(b => b.BrandId == brandId);
        }
    }
}
