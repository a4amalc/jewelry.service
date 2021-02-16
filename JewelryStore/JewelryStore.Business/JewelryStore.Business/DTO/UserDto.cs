using System;

namespace JewelryStore.Business
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long RoleId { get; set; }
        public string Token { get; set; }
    }
}
