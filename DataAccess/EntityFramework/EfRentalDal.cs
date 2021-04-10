using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;

namespace DataAccess.EntityFramework
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cs in context.Customers
                             on r.CustomerId equals cs.CustomerId
                             join brd in context.Brands on c.BrandId equals brd.BrandId
                             join usr in context.Users on cs.UserId equals usr.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,
                                 BrandName = brd.BrandName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 FirstName = usr.FirstName,
                                 LastName = usr.LastName

                             };
                return result.ToList();

            }
        }
        public int TotalRentedCar()
        {
            using (CarContext context = new CarContext())
            {
                var result = context.Brands.Count();
                return result;
            }
        }
    }
}
