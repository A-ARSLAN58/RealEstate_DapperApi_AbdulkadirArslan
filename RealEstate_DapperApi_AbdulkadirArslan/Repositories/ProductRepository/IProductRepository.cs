using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ProductDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GettAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GettAllProductWithCategoryAsync();
    }   
}
