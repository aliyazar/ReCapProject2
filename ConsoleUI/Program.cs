using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManagerTest();

            // BrandTest();

            //CarColorTest();

        }

        private static void CarColorTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            foreach (var carColor in carColorManager.GetAll())
            {
                Console.WriteLine(carColor.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Araç No  Özellik    Renk      Marka         Kiralama Bedeli");
            foreach (var Car in carManager.GetCarDetails())
            {

                Console.WriteLine("    {0}    {1}     {2}      {3}          {4}", Car.CarId, Car.Description,Car.CarColor,Car.BrandName, Car.DailyPrice);


            }
        }
    }
}
