using Barbecue.World.Domain.Models;
using Barbecure.World.Application.Barbecue;
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

        [HttpGet("teste")]
        public async Task<Countries> Teste(int numero, string pais)
        {
            return await _barbecureApplication.Teste(numero, pais);
            //return Ok(new List<Countries> { result });
        }
    }
}
