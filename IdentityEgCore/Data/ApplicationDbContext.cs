using System;
using System.Collections.Generic;
using System.Text;
using IdentityEgCore.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityEgCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityEgCoreUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
