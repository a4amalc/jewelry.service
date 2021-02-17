using System;
using System.Collections.Generic;
using System.Text;

namespace JewelryStore.Business.Services
{
    public interface IAuthService
    {
        UserDto Login(LoginDto loginDto);
        List<SettingDto> GetApplicationSettings();
    }
}
