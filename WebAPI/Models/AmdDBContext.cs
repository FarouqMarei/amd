using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Models
{
    public class AmdDBContext : DbContext
    {
        public AmdDBContext(DbContextOptions<AmdDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<AutoImage> AutoImages { get; set; }
        public DbSet<Lookup> Lookups { get; set; }
        public DbSet<LookupValue> LookupValues { get; set; }
    }
}
