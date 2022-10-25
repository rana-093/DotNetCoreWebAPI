using DotNetCoreWebAPI.entities;
using DotNetCoreWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebAPI.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private readonly ICityInfoRepository _cityInfoRepository;

        public CityController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository??throw new ArgumentNullException(nameof(cityInfoRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> getCities()
        {
            var cityList = await _cityInfoRepository.GetCitiesAsync();
            return Ok(cityList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<City?>> getParticularCity(int id)
        {
            var city = await _cityInfoRepository.GetCityAsync(id, true);
            if(city ==null)
            {
                return NotFound();
            }
            return Ok(city);
        }


    }
}
