using Barbecue.World.Domain.Models;
using Barbecue.World.Application.Barbecue;
using Microsoft.AspNetCore.Mvc;

namespace Barbecue.World.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarbecueController : ControllerBase
    {
        private readonly IBarbecueApplication _barbecureApplication;

        public BarbecueController(IBarbecueApplication barbecureApplication)
        {
            _barbecureApplication = barbecureApplication;
        }

        [HttpGet("Discover")]
        public async Task<Result> Discover(string country)
        {
            return await _barbecureApplication.Discover(country);
        }

        [HttpPost("Add/Barbecue")]
        public async Task<bool> AddBarbecue(CountriesData info)
        {
            return await _barbecureApplication.AddBarbecue(info);
        }
    }
}
