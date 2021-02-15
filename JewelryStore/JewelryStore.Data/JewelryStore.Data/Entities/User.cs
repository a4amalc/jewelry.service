using System;
using System.ComponentModel.DataAnnotations;

namespace JewelryStore.Data
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
    }
}
