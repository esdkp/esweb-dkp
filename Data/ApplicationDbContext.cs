using System;
using System.Collections.Generic;
using System.Text;
using DKP.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DKP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
