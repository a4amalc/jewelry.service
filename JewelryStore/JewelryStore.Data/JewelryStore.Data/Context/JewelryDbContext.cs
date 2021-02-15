using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JewelryStore.Data.Context
{
    public class JewelryDbContext : DbContext
    {
        public JewelryDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
    }
}
