using System;
using System.Collections.Generic;
using System.Text;

namespace JewelryStore.Business.Services
{
    public class AuthService:IAuthService
    {
        public UserDto Login(LoginDto loginDto)
        {
            return new UserDto();
        }
    }
}
