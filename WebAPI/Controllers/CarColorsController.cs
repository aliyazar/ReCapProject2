using Business.Abstract;
using Entities.Concrete;
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
    public class CarColorsController : ControllerBase
    {
        ICarColorService _carColorService;

        public CarColorsController(ICarColorService carColorService)
        {
            _carColorService = carColorService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carColorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult add(CarColor carColor)
        {
            var result = _carColorService.Add(carColor);
            if (result.Success)
            {
                return Ok(carColor);
            }
            return BadRequest(carColor);


        }

    }
}
