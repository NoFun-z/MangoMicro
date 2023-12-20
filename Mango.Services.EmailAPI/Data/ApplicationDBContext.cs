using Mango.Services.EmailAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Mango.Services.EmailAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<EmailLogger> EmailLoggers { get; set; }
    }
}
