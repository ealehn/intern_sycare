using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Project.Entities;

namespace intern_sycare.Repositories
{
    public class sqldbcontext : IdentityDbContext<ApplicationUser>
    {
        public sqldbcontext(DbContextOptions<sqldbcontext> options) : base(options)
        {

        }

        public DbSet<Item> Item { get; set; }
    }

}
