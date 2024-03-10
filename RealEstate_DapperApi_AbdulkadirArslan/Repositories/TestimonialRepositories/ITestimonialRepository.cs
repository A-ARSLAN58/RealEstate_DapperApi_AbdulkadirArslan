using RealEstate_DapperApi_AbdulkadirArslan.Dtos.BottomGridDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.TestimonialDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
