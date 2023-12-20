using Mango.Services.RewardAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Mango.Services.RewardAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Rewards> Rewards { get; set; }
    }
}
