using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Poliklinika.Model;

namespace PoliklinikaAPI.Data
{
    public class DBContext : IdentityDbContext<User, Role, int>
    {

        public DbSet<Odjel> Odjel { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        public DbSet<Izvjestaj> Izvjestaj { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Nalaz> Nalaz { get; set; }
        public DbSet<Osoblje> Osoblje { get; set; }
        public DbSet<Pregled> Pregled { get; set; }
        public DbSet<PregledTehnicar> PregledTehnicar { get; set; }
        public DbSet<Raspored> Raspored { get; set; }
        public DbSet<RasporedOsoblje> RasporedOsoblje { get; set; }
        public DbSet<Smjena> Smjena { get; set; }
        public DbSet<Tehnicar> Tehnicar { get; set; }
        public DbSet<Uplata> Uplata { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }


        public DBContext(DbContextOptions<DBContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
