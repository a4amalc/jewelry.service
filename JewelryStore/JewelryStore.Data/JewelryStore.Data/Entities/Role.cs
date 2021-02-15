using System;
using System.ComponentModel.DataAnnotations;

namespace JewelryStore.Data
{
    public class Role
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
