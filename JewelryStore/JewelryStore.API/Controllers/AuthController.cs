using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JewelryStore.Business;
using JewelryStore.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JewelryStore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(ILogger<AuthController> logger, IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            if(loginDto == null)
            {
                return BadRequest();
            }
            return Ok(_authService.Login(loginDto));
        }


        //TODO remove this end point  and related methods toto App Settings controller and to appsettings service
        [HttpGet("GetAppSettings")]
        public IActionResult GetAppSettings()
        {
            return Ok(_authService.GetApplicationSettings());
        }
    }
}
