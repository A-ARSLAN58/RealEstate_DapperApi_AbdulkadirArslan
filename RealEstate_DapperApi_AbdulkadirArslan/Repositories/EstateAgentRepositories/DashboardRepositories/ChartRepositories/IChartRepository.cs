using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ChartDtos;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> Get5CityForChart();    
    }
}
