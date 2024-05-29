using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ProductDetailDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ProductImageDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
