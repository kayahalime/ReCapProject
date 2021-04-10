using Business.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly IRentalService _rentalService;
        private readonly IPaymentService _paymentService;
        public RentalsController(IRentalService rentalService, IPaymentService paymentService)
        {
            _rentalService = rentalService;
            _paymentService = paymentService;

        }
        [HttpGet("getrentalbycar")]
        public IActionResult GetCarByCar(int id)
        {

            var result = _rentalService.GetRentalDetails(I => I.CarId == id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getrentalbycustomer")]
        public IActionResult GetCarByCustomer(int id)
        {

            var result = _rentalService.GetRentalDetails(I => I.CustomerId == id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("getrentaldetail")]
        public IActionResult GetRentalDetails()
        {
            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("totalrentedcar")]
        public IActionResult GetTotalRentedCar()
        {
            var result = _rentalService.TotalRentedCar();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("paymentadd")]
        public IActionResult PaymentAdd(RentalPaymentDto rentalPaymentDto)
        {
            var paymentResult = _paymentService.MakePayment(rentalPaymentDto.FakeCreditCardModel);
            if (!paymentResult.Success)
            {
                return BadRequest(paymentResult);
            }
            rentalPaymentDto.Rental.RentDate = DateTime.Now;
            var result = _rentalService.Add(rentalPaymentDto.Rental);

            if (result.Success)
                return Ok(result);

            return BadRequest(result.Message);
        }


    }
    

}
