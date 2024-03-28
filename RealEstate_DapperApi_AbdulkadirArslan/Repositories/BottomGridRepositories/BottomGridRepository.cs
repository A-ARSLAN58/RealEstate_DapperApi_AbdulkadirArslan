using Dapper;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.BottomGridDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.CategoryDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.ServiceDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Models.DapperContext;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.BottomGridRepository;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {

        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            string query = "insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", createBottomGridDto.Icon);
            parameters.Add("@title", createBottomGridDto.Title);
            parameters.Add("@description", createBottomGridDto.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "Delete from BottomGrid where BottomGridID=@bottomgridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomgridID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            string query = "select * from BottomGrid where BottomGridID=@bottomgridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomgridID", id);
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            string query = "Update BottomGrid set Icon=@icon,Title=@title, Description=@description where BottomGridID=@bottomgridID";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", updateBottomGridDto.Icon);
            parameters.Add("@title", updateBottomGridDto.Title);
            parameters.Add("@description", updateBottomGridDto.Description);
            parameters.Add("@bottomgridID", updateBottomGridDto.BottomGridID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }
    }
}
