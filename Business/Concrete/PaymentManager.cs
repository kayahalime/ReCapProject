using Business.Abstarct;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
       
        public IResult MakePayment(IPaymentModel paymentModel)
        {
            return new SuccessResult();
        }
    }
}
