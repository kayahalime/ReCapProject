using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IFindeksService
    {
        IResult Query(int carId, int customerId);
    }
}
