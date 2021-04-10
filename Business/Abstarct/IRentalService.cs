using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Entities.DTOs;
using System.Text;
using System.Linq.Expressions;

namespace Business.Abstarct
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
        IDataResult<Rental> GetById(int rentalId);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental );
        IDataResult<int> TotalRentedCar();
    }
}
