using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfCarImageDal: EfEntityRepositoryBase<CarImage, CarContext>, ICarImageDal
    {

    }
}
