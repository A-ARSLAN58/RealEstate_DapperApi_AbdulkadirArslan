using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.TestimonialRepositories;

namespace RealEstate_DapperApi_AbdulkadirArslan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialsController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var value = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(value);
        }
    }
}
