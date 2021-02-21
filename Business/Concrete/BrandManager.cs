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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;// bağımlılığı minimize ediyoruz bana sadece IbrandDal lazım diyoruz

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new Result(true, Messages.BrandAdded);
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

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll(), true, Messages.BrandListed);
        }

        IDataResult<Brand> IBrandService.GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == brandId));
        }
    }
}
