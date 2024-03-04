using RealEstate_DapperApi_AbdulkadirArslan.Dtos.CategoryDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GettAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);

    }
}
