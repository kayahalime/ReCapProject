using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarContext>, IColorDal
    {
      
    }
}
