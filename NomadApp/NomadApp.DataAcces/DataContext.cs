using System.Data.Entity;
using NomadApp.Models;

namespace NomadApp.DataAcces
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Comics> Comics { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}