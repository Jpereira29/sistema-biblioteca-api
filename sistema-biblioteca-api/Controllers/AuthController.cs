using ACBaseAPI.Controllers;
using ACBaseAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(UserManager<Usuario> userManager, TokenService tokenService, IConfiguration configuration, RoleManager<IdentityRole<long>> roleManager) : AuthBaseController<Usuario, long>(userManager, tokenService, configuration, roleManager)
    {

        [AllowAnonymous]
        public override async Task<IActionResult> Register(Usuario model)
        {
            return await base.Register(model);
        }
    }
}
