using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ContactDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        void CreateContact(CreateContactDto createContactDto);
        void DeleteContact(int id);
        Task<GetByIDContactDto> GetContact(int id);
    }
}
