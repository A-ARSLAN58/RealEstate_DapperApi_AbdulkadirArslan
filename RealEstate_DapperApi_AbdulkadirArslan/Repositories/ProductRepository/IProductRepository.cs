using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ProductDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GettAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsync(int id);
        Task<List<ResultProductWithCategoryDto>> GettAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeToTrue(int id);
        void ProductDealOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
    }   
}
