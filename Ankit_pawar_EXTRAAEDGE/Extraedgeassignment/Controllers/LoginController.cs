using Extraedgeassignment.Model;
using Extraedgeassignment.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Extraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
       // private readonly ILoginService service;

        public LoginController(IConfiguration config)
        {
            _config = config;
           // this.service = service;
        }
        //[AllowAnonymous]
       
        private UserModel AuthenticateUser(UserModel user)
        {
            UserModel users = null;
            if(user.UserName=="Admin" && user.Password=="12345")
            {
                users = new UserModel { UserName = "user" };
            }
            return users;
        }
        private string GenerateToken(UserModel user)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"],null,
                expires:DateTime.Now.AddMinutes(1),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            IActionResult response = Unauthorized();
            var user1 = AuthenticateUser(user);
            if(user1 !=null)
            {
                var token=GenerateToken(user1);
                response=Ok(new {token=token});
            }

            return response;
        }



    }
}
