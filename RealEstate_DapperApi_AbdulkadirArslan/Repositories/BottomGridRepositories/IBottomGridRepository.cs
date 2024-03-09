using RealEstate_DapperApi_AbdulkadirArslan.Dtos.BottomGridDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ServiceDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
