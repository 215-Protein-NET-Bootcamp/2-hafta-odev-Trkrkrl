using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _countryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbypaymentid")]
        public IActionResult GetById(int countryId)
        {
            var result = _countryService.GetById(countryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //post-add,update ,delete
        [HttpPost("add")]
        public IActionResult Add(Country country)
        {
            var result = _countryService.Add(country);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Country country)
        {
            var result = _countryService.Update(country);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Country country)
        {
            var result = _countryService.Delete(country);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


    }
}
