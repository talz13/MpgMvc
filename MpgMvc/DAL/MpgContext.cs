using MpgMvc.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MpgMvc.DAL
{
    public class MpgContext : DbContext
    {
        public MpgContext() : base("MpgContext")
        {
        }

        public DbSet<Mileage> Mileages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}