using RealEstate_DapperApi_AbdulkadirArslan.Dtos.PropertyAmentiyDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);
    }
}
