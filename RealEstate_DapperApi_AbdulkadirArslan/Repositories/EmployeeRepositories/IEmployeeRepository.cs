using RealEstate_DapperApi_AbdulkadirArslan.Dtos.CategoryDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.EmployeeDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDto createEmployeeDto);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        Task<GetByIDEmployeeDto> GetEmployee(int id);

    }
}
