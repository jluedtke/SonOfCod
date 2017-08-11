using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SonOfCod.Models;

namespace SonOfCod.Models
{
    public class SonOfCodContext : IdentityDbContext<ApplicationUser>
    {
        public SonOfCodContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SonOfCod;integrated security=True");
        }
        public SonOfCodContext(DbContextOptions<SonOfCodContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}