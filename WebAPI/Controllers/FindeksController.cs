using Business.Abstarct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindeksController : ControllerBase
    {
        private IFindeksService _findeksService;

        public FindeksController(IFindeksService findeksService)
        {
            _findeksService = findeksService;
        }

        [HttpGet("query")]
        public ActionResult Query(int carId, int customerId)
        {
            Thread.Sleep(2000);
            var result = _findeksService.Query(carId, customerId);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
