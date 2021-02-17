using System;
using System.ComponentModel.DataAnnotations;

namespace JewelryStore.Data
{
    public class Setting
    {
        [Key]
        public long Id { get; set; }
        public string SettingKey { get; set; }
        public string Value { get; set; }
    }
}
