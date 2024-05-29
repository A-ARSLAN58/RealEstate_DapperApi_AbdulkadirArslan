﻿using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ProductDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public interface ILast5ProductsRepository
    {
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id);
    }
}
