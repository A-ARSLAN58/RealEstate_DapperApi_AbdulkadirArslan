﻿using Dapper;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.CategoryDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.EmployeeDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Models.DapperContext;

namespace RealEstate_DapperApi_AbdulkadirArslan.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into Employee (Name,Title,Mail,PhoneNumber,ImageUrl,Status) values (@name,@title,@mail,@phonenumber,@imageurl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmployeeDto.Name);
            parameters.Add("@title", createEmployeeDto.Title);
            parameters.Add("@mail", createEmployeeDto.Mail);
            parameters.Add("@phonenumber", createEmployeeDto.PhoneNumber);
            parameters.Add("@imageurl", createEmployeeDto.ImageUrl);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "Delete from Employee where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "Select * From Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            string query = "select * from Employee where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "Update Employee Set Name=@name,Title=@title,Mail=@mail,PhoneNumber=@phonenumber,ImageUrl=@imageurl,Status=@status where EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmployeeDto.Name);
            parameters.Add("@title", updateEmployeeDto.Title);
            parameters.Add("@mail", updateEmployeeDto.Mail);
            parameters.Add("@phonenumber", updateEmployeeDto.PhoneNumber);
            parameters.Add("@imageurl", updateEmployeeDto.ImageUrl);
            parameters.Add("@status", true);
            parameters.Add("@employeeID", updateEmployeeDto.EmployeeID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
