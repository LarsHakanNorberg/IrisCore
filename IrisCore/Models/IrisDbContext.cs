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
        public DbSet<vWaSite> vWaSite { get; set; }
        public DbSet<tblSite> tblSite { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblSite>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .IsClustered(false);

                entity.ToTable("tblSite");
            });
            modelBuilder.Entity<vWaSite>(entity =>
            {
                entity.HasNoKey();
            });
        }
    }
}
