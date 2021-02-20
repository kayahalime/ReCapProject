using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();
            foreach (var rentalDetail in result.Data)
            {
                Console.WriteLine(rentalDetail.RentalId + " - " + rentalDetail.CustomerId + " - " + rentalDetail.CarName + " - " + rentalDetail.DailyPrice + " - " + rentalDetail.RentDate + " - " + rentalDetail.ReturnDate);
            }

        }


    }

}