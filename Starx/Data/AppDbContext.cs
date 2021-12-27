using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Starx.Models;


namespace Strax.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Servis> Servis { get; set; }
        public DbSet<Client> Clients { get; set; }


    }
}
