using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PageCreator.Models;

namespace PageCreator.Data
{
    public class PageCreatorContext : DbContext
    {
        public PageCreatorContext (DbContextOptions<PageCreatorContext> options)
            : base(options)
        {
        }

        public DbSet<PageCreator.Models.Users> Users { get; set; } = default!;

        public DbSet<PageCreator.Models.Pages> Pages { get; set; } = default!;
    }
}
