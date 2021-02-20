﻿using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto: IDto
    {
        public int RentalId { get; set; }
        public int Id { get; set; }
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
