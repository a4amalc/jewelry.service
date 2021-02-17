using AutoMapper;
using JewelryStore.Business;
using JewelryStore.Data;

namespace JewelryStore.Business.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {

            #region Master Data
            CreateMap<User, UserDto>();
            CreateMap<Setting, SettingDto>();
            #endregion

        }
    }
}
