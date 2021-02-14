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
          CarManager carManager=new CarManager(new EfCarDal());

            Console.WriteLine("Araç No  Özellik            Kiralama Bedeli");
            foreach (var Car in carManager.GetAll())
             {
                
                Console.WriteLine("{0}       {1}          {2}",Car.CarId, Car.Description,Car.DailyPrice);
                
                
            }
            
            
        }
    }
}
