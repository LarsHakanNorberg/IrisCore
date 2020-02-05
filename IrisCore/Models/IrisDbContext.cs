using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IrisCore.Models
{
    public class IrisDbContext : DbContext
    {
        public IrisDbContext(DbContextOptions<IrisDbContext> options) : base(options)
        { }
        public DbSet<TblSite> TblSite { get; set; }
    }
}
