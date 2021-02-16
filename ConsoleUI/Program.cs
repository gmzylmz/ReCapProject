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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Ürün açıklaması: "+car.Description+", Ürün Fiyatı: "+car.DailyPrice+", Ürün Modeli: "+car.ModelYear);
            }

            carManager.Add(new Car { ColorId = 2, BrandId = 3, DailyPrice = 20000, Description = "Honda", ModelYear = 2001 });

        }
    }
}
