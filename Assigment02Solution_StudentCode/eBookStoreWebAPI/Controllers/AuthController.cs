using BusinessObject.Models;
using DataAccess.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthBussiness _context;

        public AuthController(AuthBussiness au)
        {
            _context = au;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser(string email, string pass)
        {
            var congfiguration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string adminmail = congfiguration["User:Email"];
            string adminpass = congfiguration["User:Pass"];
            if(email.Equals(adminmail) && pass.Equals(adminpass))
            {
                var adminUser = new User();
                adminUser.Role = new Role();
                adminUser.Role.Role_desc = "Admin";
                return adminUser;
            }
            else
            {
                var result = await _context.GetUser(email, pass);
                if(result == null)
                {
                    return NotFound();
                }
                return result;
            }
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(User user)
        {
            var resutl = await _context.RegisterU(user);
            return Ok(resutl);
        }
    }
}
