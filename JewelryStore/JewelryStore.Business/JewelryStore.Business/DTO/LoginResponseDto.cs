using System;

namespace JewelryStore.Business
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public RoleDto Role { get; set; }
    }
}
