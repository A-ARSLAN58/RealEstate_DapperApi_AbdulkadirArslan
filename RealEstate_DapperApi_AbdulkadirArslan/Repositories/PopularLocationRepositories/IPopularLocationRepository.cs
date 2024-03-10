using RealEstate_DapperApi_AbdulkadirArslan.Dtos.PopularLocationDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
   
    }
}
