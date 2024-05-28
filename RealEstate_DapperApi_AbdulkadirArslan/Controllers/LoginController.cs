using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_DapperApi_AbdulkadirArslan.Dtos.LoginDtos;
using RealEstate_DapperApi_AbdulkadirArslan.Models.DapperContext;
using RealEstate_DapperApi_AbdulkadirArslan.Tools;

namespace RealEstate_DapperApi_AbdulkadirArslan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(CreateLoginDto loginDto)
        {
            string query = "Select * from AppUser where Username=@username and Password=@password";
            string query2 = "Select UserID from AppUser where Username=@username and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@username", loginDto.Username);
            parameters.Add("@password", loginDto.Password);
            using(var connection=_context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<CreateLoginDto>(query, parameters);
                var values2 = await connection.QueryFirstAsync<GetAppUserIdDto>(query2, parameters);
                
                if(values != null)
                {
                    GetCheckAppUserViewModel model = new GetCheckAppUserViewModel();
                    model.UserName = values.Username;
                    model.Id = values2.userID;
                    var token = JwtTokenGenerator.GenerateToken(model);
                    return Ok(token);

                }
                else {
                    return Ok("Unsuccessfull");
                }
            }


        }
    }
}
