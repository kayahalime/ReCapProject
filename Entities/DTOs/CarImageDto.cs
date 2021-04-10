using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarImageDto
    {
        public IFormFile File { get; set; }
        public CarImage CarImage { get; set; }
    }
}
