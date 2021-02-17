using JewelryStore.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JewelryStore.Data.Repository
{
    public class AuthRepository : IAuthRepository
    {
        readonly JewelryDbContext _context;

        public AuthRepository(JewelryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public User Login(string userName, string password)
        {
            return _context.Users.FirstOrDefault(u => u.UserName.ToLower() == userName.ToLower() && u.Password == password);
        }

        public List<Setting> GetApplicationSettings()
        {
            return _context.Settings.ToList();
        }

    }
}
