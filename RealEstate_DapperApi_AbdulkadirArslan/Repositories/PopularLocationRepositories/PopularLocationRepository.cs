using Dapper;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.CategoryDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.PopularLocationDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Models.DapperContext;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "Select * From PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }
    }
}
