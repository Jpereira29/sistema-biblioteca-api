using ACBaseAPI.Controllers;
using ACBaseAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(UserManager<IdentityUser<int>> userManager, TokenService tokenService, IConfiguration configuration, RoleManager<IdentityRole<int>> roleManager) : AuthBaseController<IdentityUser<int>, int>(userManager, tokenService, configuration, roleManager)
    {
    }
}
