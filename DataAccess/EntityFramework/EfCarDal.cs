using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cr in context.Colors
                             on c.ColorId equals cr.ColorId
                             select new CarDetailDto
                             {
                                 CarId=c.CarId , BrandName = b.BrandName, CarName=c.CarName, ColorName = cr.ColorName,DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();
                
            }
        }
    }
}
