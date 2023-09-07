using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIproject4.Models;

namespace WebAPIproject4.Data
{
    public class project4DbContext : DbContext
    {
        public project4DbContext (DbContextOptions<project4DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIproject4.Models.Students> Students { get; set; } = default!;

        public DbSet<WebAPIproject4.Models.Subject>? Subject { get; set; }
    }
}
