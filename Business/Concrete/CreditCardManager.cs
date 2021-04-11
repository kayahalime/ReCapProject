﻿using Business.Abstarct;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        private ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard card)
        {

            _creditCardDal.Add(card);
            return new SuccessResult(Messages.CreditCardAdded);
        }

        public IResult Payment(CreditCard card)
        {
            if (!card.Number.StartsWith("0")) return new ErrorResult(Messages.PaymentError);
            return new SuccessResult(Messages.PaymentSuccess);
        }

        public IDataResult<CreditCard> GetByUserId(int userId)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.Id == userId));
        }

        public IDataResult<List<CreditCard>> GetAll(int userId)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(x => x.UserId == userId), Messages.CustomerListed);

           
        }
    }
}
