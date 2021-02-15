using System;
using System.Collections.Generic;
using System.Text;

namespace JewelryStore.Data.Repository
{
    public interface IAuthRepository
    {
        User Login(string userName, string password);
    }
}
