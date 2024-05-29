using RealEstate_DapperApi_AbdulkadirArslan.Dtos.AppUserDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);
    }
}
