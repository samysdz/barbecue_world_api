using Barbecue.World.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Barbecue.World.Data.DB
{
    public class BarbecueDbContext : DbContext
    {
        public DbSet<Countries> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB", "db_barbecue_world.db");
            optionsBuilder.UseSqlite("Data Source={dbFilePath}"); // Connection string for SQLite
        }
    }

}
