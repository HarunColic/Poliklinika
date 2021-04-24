using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Poliklinika.Model;

namespace PoliklinikaAPI.Data
{
    public class DBContext : DbContext
    {

        public DbSet<Odjel> Odjel { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
    }
}
