using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
                Console.WriteLine(car.DailyPrice);

            }

        }
    }
}
