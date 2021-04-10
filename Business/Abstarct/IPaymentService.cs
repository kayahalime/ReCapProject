using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IPaymentService
    {
        IResult MakePayment(IPaymentModel paymentModel);
    }
}
