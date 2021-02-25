using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            RentalTest();
            // UserTest(); 

            // CarManagerTest();

            //BrandTest();

            //CarColorTest();

        }

        /*buradaki hatayı bulamadım
         * private static void CarColorTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            foreach (var carColor in carColorManager.GetAll())
            {
                Console.WriteLine(carColor.ColorName);
            }
        }
        */
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental {Id=20, CustomerId=2,CarId=3,RentDate=new DateTime(2020,5,10),ReturnDate= new DateTime(2020, 5, 18) });

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            
            userManager.Add(new User { FirstName = "Ahmet", LastName = "Dere", Email = "q@r.com", Password = "dela", Id = 11 });

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

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {

                Console.WriteLine("Araç No  Özellik    Renk      Marka         Kiralama Bedeli");
                foreach (var Car in carManager.GetCarDetails().Data)
                {

                    Console.WriteLine("    {0}    {1}     {2}      {3}          {4}", Car.CarId, Car.Description, Car.CarColor, Car.BrandName, Car.DailyPrice);


                }


            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
