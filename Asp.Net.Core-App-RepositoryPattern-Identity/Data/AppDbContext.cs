using Asp.Net.Core_App_RepositoryPattern_Identity.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Asp.Net.Core_App_RepositoryPattern_Identity.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
