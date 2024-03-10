using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.PopularLocationRepositories;

namespace RealEstate_DapperApi_AbdulkadirArslan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var value = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(value);
        }
    
    
    }
}
